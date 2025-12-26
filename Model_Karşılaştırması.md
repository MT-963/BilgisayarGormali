# 🎯 Model Karşılaştırma Raporu: 4x DS vs 8x DS vs Orijinal

## ASVspoof5 Deepfake Audio Detection - Performans Analizi

---

## 📊 Özet Karşılaştırma Tablosu

| **Model**               | **Özellik Yapısı** | **Downsampling** | **Dev EER** | **Eval EER** | **Durum**     |
| ----------------------- | ------------------ | ---------------- | ----------- | ------------ | ------------- |
| **Orijinal (Baseline)** | HuBERT + WavLM     | 1× (full)        | **0.44%**   | 7.23%        | Baseline      |
| **Hybrid 8× DS**        | WavLM + SSPS       | 8×               | 0.52%       | 5.74%        | İyileşme      |
| **Hybrid 4× DS**        | WavLM + SSPS       | 4×               | 0.52%       | **5.37%**    | **En İyi** 🏆 |

---

## 🏆 Kazanan: Hybrid 4x Downsample

```
┌─────────────────────────────────────────────────────────────┐
│                    EVAL EER KARŞILAŞTIRMASI                 │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  Orijinal (HuBERT+WavLM):  ████████████████████████  7.23%  │
│                                                             │
│  Hybrid 8x DS (WavLM+SSPS): ██████████████████      5.74%   │
│                                                             │
│  Hybrid 4x DS (WavLM+SSPS): █████████████████       5.37%   │
│                            ↑                                │
│                         EN İYİ                              │
└─────────────────────────────────────────────────────────────┘
```

---

## 📈 İyileşme Oranları

| **Karşılaştırma**      | **Eval EER Değişimi** | **Göreceli İyileşme** |
| ---------------------- | --------------------- | --------------------- |
| **4× DS vs. Orijinal** | 7.23% → **5.37%**     | **%25.7**             |
| **8× DS vs. Orijinal** | 7.23% → 5.74%         | %20.6                 |
| **4× DS vs. 8× DS**    | 5.74% → **5.37%**     | %6.4                  |


---

## 🔬 Model Mimarileri

### 1. Orijinal Model (HuBERT + WavLM + NeXt-TDNN)

```
┌──────────────────────────────────────────────────────────────┐
│                     ORİJİNAL MODEL                           │
├──────────────────────────────────────────────────────────────┤
│                                                              │
│   Audio ──► HuBERT ──► Frame-level Features (1024-D)         │
│                              │                               │
│   Audio ──► WavLM  ──► Frame-level Features (1024-D)         │
│                              │                               │
│                        ┌─────▼─────┐                         │
│                        │  Concat   │                         │
│                        │ (2048-D)  │                         │
│                        └─────┬─────┘                         │
│                              │                               │
│                    ┌─────────▼─────────┐                     │
│                    │  NeXt-TDNN-ECA    │                     │
│                    │    (Backbone)     │                     │
│                    └─────────┬─────────┘                     │
│                              │                               │
│                    ┌─────────▼─────────┐                     │
│                    │    Classifier     │                     │
│                    │  (Bonafide/Spoof) │                     │
│                    └───────────────────┘                     │
│                                                              │
│  Feature Length: 750 frames (full resolution)                │
│  Feature Dim: 2048 (HuBERT 1024 + WavLM 1024)               │
│  Disk Space: ~500GB (çok büyük)                              │
└──────────────────────────────────────────────────────────────┘
```

### 2. Hybrid 8x Downsample Model (WavLM + SSPS)

```
┌──────────────────────────────────────────────────────────────┐
│                  HYBRID 8x DOWNSAMPLE MODEL                  │
├──────────────────────────────────────────────────────────────┤
│                                                              │
│   Audio ──► WavLM ──► Frame-level (1024-D, 93 frames)        │
│                              │                               │
│                    ┌─────────▼─────────┐                     │
│                    │  NeXt-TDNN-ECA    │                     │
│                    │    (Backbone)     │ ──► WavLM Embedding │
│                    └───────────────────┘        (256-D)      │
│                                                    │         │
│   Audio ──► SSPS ──► Utterance-level (512-D)       │         │
│                              │                     │         │
│                    ┌─────────▼─────────┐           │         │
│                    │    Linear + BN    │           │         │
│                    │      + ReLU       │ ──► SSPS Embedding  │
│                    └───────────────────┘       (256-D)       │
│                                                    │         │
│                        ┌───────────────────────────┘         │
│                        │                                     │
│               ┌────────▼────────┐                            │
│               │ Attention Fusion │                           │
│               │   (α·WavLM +     │                           │
│               │    β·SSPS)       │                           │
│               └────────┬────────┘                            │
│                        │                                     │
│               ┌────────▼────────┐                            │
│               │   Classifier    │                            │
│               │ (Bonafide/Spoof)│                            │
│               └─────────────────┘                            │
│                                                              │
│  Feature Length: 93 frames (8x downsampled)                  │
│  Disk Space: ~60GB (kompakt)                                 │
└──────────────────────────────────────────────────────────────┘
```

### 3. Hybrid 4x Downsample Model (WavLM + SSPS) - EN İYİ

```
┌──────────────────────────────────────────────────────────────┐
│             🏆 HYBRID 4x DOWNSAMPLE MODEL (EN İYİ)           │
├──────────────────────────────────────────────────────────────┤
│                                                              │
│   Audio ──► WavLM ──► Frame-level (1024-D, 187 frames)       │
│                              │                               │
│                    ┌─────────▼─────────┐                     │
│                    │  NeXt-TDNN-ECA    │                     │
│                    │    (Backbone)     │ ──► WavLM Embedding │
│                    └───────────────────┘        (256-D)      │
│                                                    │         │
│   Audio ──► SSPS ──► Utterance-level (512-D)       │         │
│                              │                     │         │
│                    ┌─────────▼─────────┐           │         │
│                    │    Linear + BN    │           │         │
│                    │      + ReLU       │ ──► SSPS Embedding  │
│                    └───────────────────┘       (256-D)       │
│                                                    │         │
│                        ┌───────────────────────────┘         │
│                        │                                     │
│               ┌────────▼────────┐                            │
│               │ Attention Fusion │                           │
│               │   (α·WavLM +     │                           │
│               │    β·SSPS)       │                           │
│               └────────┬────────┘                            │
│                        │                                     │
│               ┌────────▼────────┐                            │
│               │   Classifier    │                            │
│               │ (Bonafide/Spoof)│                            │
│               └─────────────────┘                            │
│                                                              │
│  Feature Length: 187 frames (4x downsampled)                 │
│  Disk Space: ~120GB (orta)                                   │
│  Temporal Resolution: 2x daha iyi (8x DS'ye göre)            │
└──────────────────────────────────────────────────────────────┘
```

---

## 📋 Detaylı Teknik Karşılaştırma

### Feature Özellikleri

| **Özellik**                        | **Orijinal Model** | **8× DS Hybrid**  | **4× DS Hybrid**  |
| ---------------------------------- | ------------------ | ----------------- | ----------------- |
| **SSL Model**                      | HuBERT + WavLM     | WavLM             | WavLM             |
| **Speaker Model**                  | –                  | SSPS (ECAPA-TDNN) | SSPS (ECAPA-TDNN) |
| **Frame-level Feature Boyutu**     | 2048               | 1024              | 1024              |
| **Utterance-level Feature Boyutu** | –                  | 512               | 512               |
| **Zamansal Uzunluk (T)**           | 750                | 93 (8× DS)        | 187 (4× DS)       |
| **Sayısal Hassasiyet (Precision)** | float32            | float16           | float16           |
| **Disk Alanı Kullanımı**           | ~500 GB            | ~60 GB            | ~120 GB           |


### Eğitim Hiperparametreleri

| **Parametre**               | **Orijinal Model** | **8× DS Hybrid** | **4× DS Hybrid** |
| --------------------------- | ------------------ | ---------------- | ---------------- |
| **Learning Rate**           | 1e-4               | 1e-4             | 1e-4             |
| **Batch Size**              | 14                 | 64               | 64               |
| **Optimizer**               | Adam               | Adam             | Adam             |
| **Loss Function**           | OC-Softmax         | OC-Softmax       | OC-Softmax       |
| **LR Decay Factor**         | 0.5                | 0.5              | 0.5              |
| **LR Decay Aralığı**        | 10 epoch           | 20 epoch         | 20 epoch         |
| **Gradient Clipping**       | –                  | 1.0              | 1.0              |
| **Early Stopping Patience** | –                  | 20               | 20               |


### Dataset İstatistikleri

| **Set**   | **Bonafide** | **Spoof** | **Toplam** |
| --------- | ------------ | --------- | ---------- |
| **Train** | 18,797       | 163,560   | 182,357    |
| **Dev**   | 31,334       | 109,616   | 140,950    |
| **Eval**  | 138,688      | 542,086   | 680,774    |

---

## 🔍 Neden 4x DS Daha İyi?

### 1. Temporal Resolution Avantajı

```
Orijinal Audio: 3 saniye = 48000 sample (16kHz)
                            ↓
WavLM Output:   750 frames (20ms stride)

8x Downsample:  750 → 93 frames  (160ms stride)
4x Downsample:  750 → 187 frames (80ms stride)

📈 4x DS, 8x DS'ye göre 2x daha fazla temporal bilgi içerir
```

### 2. Spoofing Artifact Detection

```
┌─────────────────────────────────────────────────────────────┐
│                 SPOOFING ARTİFACT ÖRNEKLERİ                 │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  Vocoders:      Ses dalgası reconstruction hataları         │
│  TTS Systems:   Prosody ve timing tutarsızlıkları           │
│  VC Systems:    Formant transition anomalileri              │
│  Concatenative: Birleşim noktalarında süreksizlikler        │
│                                                             │
│  Bu artifactlar genellikle:                                 │
│  • 10-50ms aralıklarında görünür                            │
│  • Yüksek temporal çözünürlük gerektirir                    │
│                                                             │
│  4x DS (80ms stride): Bu artifactları yakalayabilir ✅      │
│  8x DS (160ms stride): Bazı artifactları kaçırabilir ⚠️     │
└─────────────────────────────────────────────────────────────┘
```

### 3. SSPS Katkısı

```
┌─────────────────────────────────────────────────────────────┐
│                      SSPS AVANTAJLARI                       │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  Speaker Verification'dan Gelen Bilgiler:                   │
│                                                             │
│  ✓ Global speaker characteristics                          │
│  ✓ Voice quality features                                  │
│  ✓ Naturalness indicators                                  │
│  ✓ Channel/recording consistency                           │
│                                                             │
│  WavLM (Frame-level) + SSPS (Utterance-level)               │
│  = Hem lokal hem global bilgi                               │
│  = Daha robust detection                                    │
└─────────────────────────────────────────────────────────────┘
```

---

## 💾 Disk Alanı Karşılaştırması

```
┌─────────────────────────────────────────────────────────────┐
│                    DİSK ALANI KULLANIMI                     │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│  Orijinal:    ████████████████████████████████████  ~500GB  │
│                                                             │
│  4x DS:       ████████████                          ~120GB  │
│                                                             │
│  8x DS:       ██████                                ~60GB   │
│                                                             │
│  SSPS:        ██                                    ~15GB   │
│                                                             │
└─────────────────────────────────────────────────────────────┘

Toplam (4x DS Hybrid): ~135GB
Toplam (8x DS Hybrid): ~75GB
Tasarruf: %73-85 (Orijinale göre)
```


---

