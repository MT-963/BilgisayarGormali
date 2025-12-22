using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BilgisayarliGörmeFinal
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage = null;
        private Bitmap islenecekResim = null;
        private Bitmap sonucResim = null;
        private Random random = new Random();
        private int[] histogramDegerleri = new int[256];
        private TrackBar trackBarThreshold;
        private Label labelThreshold;
        private int kenarEsikDegeri = 128;

        public Form1()
        {
            InitializeComponent();
            ComboBoxItemleriEkle();
            ButonlariAyarla();
            ChartAyarla();
            ListViewleriAyarla();
            TrackBarAyarla();
        }

        private void ComboBoxItemleriEkle()
        {
            comboBox1.Items.AddRange(new string[] {
                "Gri Yap",
                "Y Yap",
                "Histogram",
                "Kenar Bulma",
                "KM İntesity",
                "KM Öklit RGB",
                "KM Mahalanobis",
                "KM Mahalanobis ND"
            });
            comboBox1.SelectedIndex = 0;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 50 };
            comboBox2.Items.AddRange(numbers.Select(x => x.ToString()).ToArray());
            comboBox2.SelectedIndex = 0;
        }

        private void ButonlariAyarla()
        {
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ResimKontrol() == false) return;

            string secilenIslem = comboBox1.SelectedItem.ToString();
            islenecekResim = new Bitmap(pictureBox1.Image);

            switch (secilenIslem)
            {
                case "Gri Yap":
                    GriYap();
                    break;
                case "Y Yap":
                    YYap();
                    break;
                case "Histogram":
                    HistogramHesapla();
                    break;
                case "Kenar Bulma":
                    KenarBul();
                    break;
                case "KM İntesity":
                    KMIntensity();
                    break;
                case "KM Öklit RGB":
                    KMOklitRGB();
                    break;
                case "KM Mahalanobis":
                    KMMahalanobis();
                    break;
                case "KM Mahalanobis ND":
                    KMMahalanobisND();
                    break;
            }

            SonucuGoster();
        }

        private void TrackBarAyarla()
        {
            // TrackBar oluştur
            trackBarThreshold = new TrackBar();
            trackBarThreshold.Location = new Point(1040, 600);
            trackBarThreshold.Size = new Size(200, 45);
            trackBarThreshold.Minimum = 0;
            trackBarThreshold.Maximum = 255;
            trackBarThreshold.Value = 128;
            trackBarThreshold.TickFrequency = 15;
            trackBarThreshold.ValueChanged += TrackBarThreshold_ValueChanged;

            // Label oluştur
            labelThreshold = new Label();
            labelThreshold.Location = new Point(1040, 580);
            labelThreshold.Size = new Size(200, 20);
            labelThreshold.Text = "Eşik Değeri: 128";

            // Kontrolleri forma ekle
            this.Controls.Add(trackBarThreshold);
            this.Controls.Add(labelThreshold);
        }

        private void TrackBarThreshold_ValueChanged(object sender, EventArgs e)
        {
            kenarEsikDegeri = trackBarThreshold.Value;
            labelThreshold.Text = $"Eşik Değeri: {kenarEsikDegeri}";
            
            // Eğer kenar bulma seçili ise, değişikliği hemen uygula
            if (comboBox1.SelectedItem.ToString() == "Kenar Bulma" && pictureBox1.Image != null)
            {
                KenarBul();
                SonucuGoster();
            }
        }

        private void KenarBul()
        {
            if (pictureBox1.Image == null) return;

            // Önce görüntüyü gri tonlamaya çevir
            Bitmap giriş = new Bitmap(pictureBox1.Image);
            Bitmap çıkış = new Bitmap(giriş.Width, giriş.Height);

            // Gri tonlamaya çevir
            for (int x = 0; x < giriş.Width; x++)
            {
                for (int y = 0; y < giriş.Height; y++)
                {
                    Color renk = giriş.GetPixel(x, y);
                    int griDeger = (renk.R + renk.G + renk.B) / 3;
                    giriş.SetPixel(x, y, Color.FromArgb(griDeger, griDeger, griDeger));
                }
            }

            // Sobel operatörleri
            int[,] sobelX = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] sobelY = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            // X ve Y matrislerini saklamak için diziler
            int[,] matrixX = new int[giriş.Height, giriş.Width];
            int[,] matrixY = new int[giriş.Height, giriş.Width];

            // Her piksel için X ve Y matrislerini hesapla
            for (int y = 1; y < giriş.Height - 1; y++)
            {
                for (int x = 1; x < giriş.Width - 1; x++)
                {
                    int sumX = 0;
                    int sumY = 0;

                    // 3x3'lük komşuluk üzerinde işlem yap
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = giriş.GetPixel(x + j, y + i);
                            int grayValue = pixel.R; // Gri görüntüde R=G=B
                            
                            // X ve Y yönündeki değerleri hesapla
                            sumX += grayValue * sobelX[i + 1, j + 1];
                            sumY += grayValue * sobelY[i + 1, j + 1];
                        }
                    }

                    // Mutlak değerleri al ve matrislere kaydet
                    matrixX[y, x] = Math.Abs(sumX);
                    matrixY[y, x] = Math.Abs(sumY);
                }
            }

            // X ve Y matrislerini topla ve eşikleme uygula
            for (int y = 1; y < giriş.Height - 1; y++)
            {
                for (int x = 1; x < giriş.Width - 1; x++)
                {
                    int sum = matrixX[y, x] + matrixY[y, x];
                    int value = sum > kenarEsikDegeri ? 255 : 0;
                    çıkış.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }

            // Sonuçları ListView2'de göster
            listView2.Items.Clear();
            
            // X matrisinin maksimum değeri
            int maxX = 0;
            for (int y = 0; y < giriş.Height; y++)
                for (int x = 0; x < giriş.Width; x++)
                    maxX = Math.Max(maxX, matrixX[y, x]);

            ListViewItem itemX = new ListViewItem("X Matrisi Max");
            itemX.SubItems.Add(maxX.ToString());
            listView2.Items.Add(itemX);

            // Y matrisinin maksimum değeri
            int maxY = 0;
            for (int y = 0; y < giriş.Height; y++)
                for (int x = 0; x < giriş.Width; x++)
                    maxY = Math.Max(maxY, matrixY[y, x]);

            ListViewItem itemY = new ListViewItem("Y Matrisi Max");
            itemY.SubItems.Add(maxY.ToString());
            listView2.Items.Add(itemY);

            // Toplam maksimum değer
            int maxSum = maxX + maxY;
            ListViewItem itemTotal = new ListViewItem("Toplam Max");
            itemTotal.SubItems.Add(maxSum.ToString());
            listView2.Items.Add(itemTotal);

            // Resmi göster
            pictureBox2.Image = çıkış;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private bool ResimKontrol()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir resim yükleyin!", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void GriYap()
        {
            sonucResim = new Bitmap(islenecekResim.Width, islenecekResim.Height);
            
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    Color piksel = islenecekResim.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;
                    sonucResim.SetPixel(x, y, Color.FromArgb(griDeger, griDeger, griDeger));
                }
            }
        }

        private void YYap()
        {
            sonucResim = new Bitmap(islenecekResim.Width, islenecekResim.Height);
            
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    Color piksel = islenecekResim.GetPixel(x, y);
                    int yDeger = (int)(0.299 * piksel.R + 0.587 * piksel.G + 0.114 * piksel.B);
                    yDeger = Math.Max(0, Math.Min(255, yDeger));
                    sonucResim.SetPixel(x, y, Color.FromArgb(yDeger, yDeger, yDeger));
                }
            }
        }

        private void ChartAyarla()
        {
            chart1.Series.Clear();
            
            // Histogram serisi
            Series histogramSeries = new Series("Histogram");
            histogramSeries.ChartType = SeriesChartType.Column;
            chart1.Series.Add(histogramSeries);

            // Tepe noktaları serisi
            Series tepeSeries = new Series("Tepe Noktaları");
            tepeSeries.ChartType = SeriesChartType.Point;
            tepeSeries.MarkerStyle = MarkerStyle.Circle;
            tepeSeries.MarkerSize = 10;
            tepeSeries.Color = Color.Red;
            chart1.Series.Add(tepeSeries);
            
            chart1.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            chart1.ChartAreas[0].AxisY.Title = "Piksel Sayısı";
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
        }

        private void ListViewleriAyarla()
        {
            // ListView1 için sütunlar
            listView1.View = View.Details;
            listView1.Columns.Add("T Değeri", 70);
            listView1.Columns.Add("R", 50);
            listView1.Columns.Add("G", 50);
            listView1.Columns.Add("B", 50);

            // ListView2 için sütunlar
            listView2.View = View.Details;
            listView2.Columns.Add("Piksel Sayısı", 80);
            listView2.Columns.Add("T Değeri", 70);
            listView2.Columns.Add("R", 50);
            listView2.Columns.Add("G", 50);
            listView2.Columns.Add("B", 50);
        }

        private void KMIntensity()
        {
            // ListView'ları temizle
            listView1.Items.Clear();
            listView2.Items.Clear();

            // Resmi önce gri tonlamaya çevir ve histogram değerlerini hesapla
            Array.Clear(histogramDegerleri, 0, histogramDegerleri.Length);
            int[,] griResim = new int[islenecekResim.Width, islenecekResim.Height];
            
            // Toplam piksel sayısını hesapla ve göster
            int toplamPiksel = islenecekResim.Width * islenecekResim.Height;
            label8.Text = toplamPiksel.ToString();

            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    Color piksel = islenecekResim.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;
                    griResim[x, y] = griDeger;
                    histogramDegerleri[griDeger]++;
                }
            }

            // Histogramı göster
            chart1.Series.Clear();
            Series histogramSeries = new Series("Histogram");
            histogramSeries.ChartType = SeriesChartType.Column;
            chart1.Series.Add(histogramSeries);

            Series tepeSeries = new Series("Tepe Noktaları");
            tepeSeries.ChartType = SeriesChartType.Point;
            tepeSeries.MarkerStyle = MarkerStyle.Circle;
            tepeSeries.MarkerSize = 10;
            tepeSeries.Color = Color.Red;
            chart1.Series.Add(tepeSeries);

            // Histogram verilerini ekle ve maksimum değeri bul
            int maxHistogramDegeri = 0;
            for (int i = 0; i < 256; i++)
            {
                histogramSeries.Points.AddXY(i, histogramDegerleri[i]);
                maxHistogramDegeri = Math.Max(maxHistogramDegeri, histogramDegerleri[i]);
            }

            // Chart ayarları
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            chart1.ChartAreas[0].AxisY.Title = "Piksel Sayısı";
            
            // Y eksenini dinamik olarak ayarla
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = maxHistogramDegeri + (maxHistogramDegeri * 0.1); // %10 margin ekle
            chart1.ChartAreas[0].AxisY.Interval = maxHistogramDegeri / 10; // 10 aralık göster

            // Grid çizgilerini ve arka planı ayarla
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].BackColor = Color.White;

            // K-Means parametreleri
            int k = int.Parse(comboBox2.SelectedItem.ToString());
            int maxIterasyon = 100;
            
            // Küme merkezlerini rastgele başlat
            int[] merkezler = new int[k];
            for (int i = 0; i < k; i++)
            {
                merkezler[i] = random.Next(0, 256);
                // Rastgele başlangıç değerlerini ListView1'e ekle
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString()); // R değeri
                item.SubItems.Add(merkezler[i].ToString()); // G değeri
                item.SubItems.Add(merkezler[i].ToString()); // B değeri
                listView1.Items.Add(item);
            }

            int[,] kümeler = new int[islenecekResim.Width, islenecekResim.Height];
            bool değişimVar;
            int iterasyon = 0;
            double tDegeri = 0;
            int[] pikselSayilari = new int[k];

            do
            {
                değişimVar = false;
                double eskiTDegeri = tDegeri;
                tDegeri = 0;
                Array.Clear(pikselSayilari, 0, pikselSayilari.Length);

                // Her pikseli en yakın kümeye ata
                for (int x = 0; x < islenecekResim.Width; x++)
                {
                    for (int y = 0; y < islenecekResim.Height; y++)
                    {
                        int pikselDeğer = griResim[x, y];
                        int enYakınKüme = 0;
                        int enKüçükUzaklık = Math.Abs(pikselDeğer - merkezler[0]);

                        for (int c = 1; c < k; c++)
                        {
                            int uzaklık = Math.Abs(pikselDeğer - merkezler[c]);
                            if (uzaklık < enKüçükUzaklık)
                            {
                                enKüçükUzaklık = uzaklık;
                                enYakınKüme = c;
                            }
                        }

                        if (kümeler[x, y] != enYakınKüme)
                        {
                            değişimVar = true;
                            kümeler[x, y] = enYakınKüme;
                        }

                        pikselSayilari[enYakınKüme]++;
                        tDegeri += enKüçükUzaklık;
                    }
                }

                // T değerini normalize et ve göster
                tDegeri = tDegeri / toplamPiksel;
                label4.Text = tDegeri.ToString("F2");

                // Küme merkezlerini güncelle
                if (değişimVar)
                {
                    for (int c = 0; c < k; c++)
                    {
                        long toplam = 0;
                        int sayı = pikselSayilari[c];

                        for (int x = 0; x < islenecekResim.Width; x++)
                        {
                            for (int y = 0; y < islenecekResim.Height; y++)
                            {
                                if (kümeler[x, y] == c)
                                {
                                    toplam += griResim[x, y];
                                }
                            }
                        }

                        if (sayı > 0)
                        {
                            merkezler[c] = (int)(toplam / sayı);
                        }
                    }
                }

                iterasyon++;
                // İterasyon sayısını göster
                label6.Text = iterasyon.ToString();

                // Tepe noktalarını güncelle
                tepeSeries.Points.Clear();
                foreach (int merkez in merkezler)
                {
                    tepeSeries.Points.AddXY(merkez, histogramDegerleri[merkez]);
                }

            } while (değişimVar && iterasyon < maxIterasyon);

            // Son merkez değerlerini ListView2'ye ekle
            listView2.Items.Clear();
            for (int i = 0; i < k; i++)
            {
                int pikselSayisi = 0;
                // Her küme için piksel sayısını hesapla
                for (int x = 0; x < islenecekResim.Width; x++)
                {
                    for (int y = 0; y < islenecekResim.Height; y++)
                    {
                        if (kümeler[x, y] == i)
                        {
                            pikselSayisi++;
                        }
                    }
                }

                ListViewItem item = new ListViewItem(pikselSayisi.ToString());
                item.SubItems.Add((i + 1).ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                listView2.Items.Add(item);
            }

            // Sonuç resmini oluştur
            sonucResim = new Bitmap(islenecekResim.Width, islenecekResim.Height);
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    int kümeIndex = kümeler[x, y];
                    int yeniDeğer = merkezler[kümeIndex];
                    sonucResim.SetPixel(x, y, Color.FromArgb(yeniDeğer, yeniDeğer, yeniDeğer));
                }
            }

            // Toplam piksel sayısını kontrol et ve göster
            int toplamKümePikseli = 0;
            for (int i = 0; i < k; i++)
            {
                toplamKümePikseli += pikselSayilari[i];
            }

            if (toplamKümePikseli != toplamPiksel)
            {
                MessageBox.Show("Uyarı: Toplam piksel sayısı ile kümelerdeki piksel sayısı eşleşmiyor!", 
                    "Piksel Sayısı Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            label8.Text = $"{toplamPiksel} ({toplamKümePikseli})";
        }

        private void KMOklitRGB()
        {
            // ListView'ları temizle
            listView1.Items.Clear();
            listView2.Items.Clear();

            // Histogram dizisini sıfırla
            Array.Clear(histogramDegerleri, 0, histogramDegerleri.Length);

            // Her piksel için RGB histogram değerlerini hesapla
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    Color piksel = islenecekResim.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;
                    histogramDegerleri[griDeger]++;
                }
            }

            // Chart'ı temizle ve yeni seriler oluştur
            chart1.Series.Clear();
            Series histogramSeries = new Series("Histogram");
            histogramSeries.ChartType = SeriesChartType.Column;
            chart1.Series.Add(histogramSeries);

            Series tepeSeries = new Series("Tepe Noktaları");
            tepeSeries.ChartType = SeriesChartType.Point;
            tepeSeries.MarkerStyle = MarkerStyle.Circle;
            tepeSeries.MarkerSize = 10;
            tepeSeries.Color = Color.Red;
            chart1.Series.Add(tepeSeries);

            // Histogram verilerini ekle
            for (int i = 0; i < 256; i++)
            {
                histogramSeries.Points.AddXY(i, histogramDegerleri[i]);
            }

            // Chart ayarları
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            chart1.ChartAreas[0].AxisY.Title = "Piksel Sayısı";

            // K-Means parametreleri
            int k = int.Parse(comboBox2.SelectedItem.ToString());
            int maxIterasyon = 100;
            
            // Küme merkezlerini rastgele başlat (RGB için)
            int[,] merkezler = new int[k, 3]; // Her merkez için R,G,B değerleri
            int[] pikselSayilari = new int[k]; // Her küme için piksel sayısı

            // Rastgele başlangıç merkezlerini seç ve ListView1'e ekle
            for (int i = 0; i < k; i++)
            {
                // Her renk kanalı için 0-255 arası rastgele değer seç
                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);

                merkezler[i, 0] = r;
                merkezler[i, 1] = g;
                merkezler[i, 2] = b;

                // ListView1'e ekle
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(r.ToString());
                item.SubItems.Add(g.ToString());
                item.SubItems.Add(b.ToString());
                listView1.Items.Add(item);
            }

            int[,] kümeler = new int[islenecekResim.Width, islenecekResim.Height];
            bool değişimVar;
            int iterasyon = 0;
            double tDegeri = 0;

            do
            {
                değişimVar = false;
                tDegeri = 0;
                Array.Clear(pikselSayilari, 0, pikselSayilari.Length);

                // Her pikseli en yakın kümeye ata
                for (int x = 0; x < islenecekResim.Width; x++)
                {
                    for (int y = 0; y < islenecekResim.Height; y++)
                    {
                        Color piksel = islenecekResim.GetPixel(x, y);
                        int enYakınKüme = 0;
                        double enKüçükUzaklık = Math.Sqrt(
                            Math.Pow(piksel.R - merkezler[0, 0], 2) +
                            Math.Pow(piksel.G - merkezler[0, 1], 2) +
                            Math.Pow(piksel.B - merkezler[0, 2], 2)
                        );

                        // Her küme merkezi için uzaklık hesapla
                        for (int c = 1; c < k; c++)
                        {
                            double uzaklık = Math.Sqrt(
                                Math.Pow(piksel.R - merkezler[c, 0], 2) +
                                Math.Pow(piksel.G - merkezler[c, 1], 2) +
                                Math.Pow(piksel.B - merkezler[c, 2], 2)
                            );

                            if (uzaklık < enKüçükUzaklık)
                            {
                                enKüçükUzaklık = uzaklık;
                                enYakınKüme = c;
                            }
                        }

                        if (kümeler[x, y] != enYakınKüme)
                        {
                            değişimVar = true;
                            kümeler[x, y] = enYakınKüme;
                        }

                        pikselSayilari[enYakınKüme]++;
                        tDegeri += enKüçükUzaklık;
                    }
                }

                // T değerini normalize et ve göster
                tDegeri = tDegeri / (islenecekResim.Width * islenecekResim.Height);
                label4.Text = tDegeri.ToString("F2");

                // Küme merkezlerini güncelle
                if (değişimVar)
                {
                    for (int c = 0; c < k; c++)
                    {
                        long toplamR = 0, toplamG = 0, toplamB = 0;
                        int sayı = pikselSayilari[c];

                        if (sayı > 0)
                        {
                            for (int x = 0; x < islenecekResim.Width; x++)
                            {
                                for (int y = 0; y < islenecekResim.Height; y++)
                                {
                                    if (kümeler[x, y] == c)
                                    {
                                        Color piksel = islenecekResim.GetPixel(x, y);
                                        toplamR += piksel.R;
                                        toplamG += piksel.G;
                                        toplamB += piksel.B;
                                    }
                                }
                            }

                            merkezler[c, 0] = (int)(toplamR / sayı);
                            merkezler[c, 1] = (int)(toplamG / sayı);
                            merkezler[c, 2] = (int)(toplamB / sayı);
                        }
                    }

                    // Sadece tepe noktalarını güncelle, histogram grafiğini koruyarak
                    chart1.Series["Tepe Noktaları"].Points.Clear();
                    for (int i = 0; i < k; i++)
                    {
                        int griMerkez = (merkezler[i, 0] + merkezler[i, 1] + merkezler[i, 2]) / 3;
                        chart1.Series["Tepe Noktaları"].Points.AddXY(griMerkez, histogramDegerleri[griMerkez]);
                    }
                }

                iterasyon++;
                // İterasyon sayısını göster
                label6.Text = iterasyon.ToString();

            } while (değişimVar && iterasyon < maxIterasyon);

            // Son merkez değerlerini ListView2'ye ekle
            listView2.Items.Clear();
            for (int i = 0; i < k; i++)
            {
                ListViewItem item = new ListViewItem(pikselSayilari[i].ToString());
                item.SubItems.Add((i + 1).ToString());
                item.SubItems.Add(merkezler[i, 0].ToString());
                item.SubItems.Add(merkezler[i, 1].ToString());
                item.SubItems.Add(merkezler[i, 2].ToString());
                listView2.Items.Add(item);
            }

            // Sonuç resmini oluştur
            sonucResim = new Bitmap(islenecekResim.Width, islenecekResim.Height);
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    int kümeIndex = kümeler[x, y];
                    sonucResim.SetPixel(x, y, Color.FromArgb(
                        merkezler[kümeIndex, 0],
                        merkezler[kümeIndex, 1],
                        merkezler[kümeIndex, 2]
                    ));
                }
            }

            // Toplam piksel sayısını göster
            label8.Text = (islenecekResim.Width * islenecekResim.Height).ToString();
        }

        private void HistogramHesapla()
        {
            if (islenecekResim == null) return;

            // Histogram dizisini sıfırla
            Array.Clear(histogramDegerleri, 0, histogramDegerleri.Length);

            // Her piksel için gri değeri hesapla ve histogram değerlerini güncelle
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    Color piksel = islenecekResim.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;
                    histogramDegerleri[griDeger]++;
                }
            }

            // Chart'ı güncelle
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Grafiğin başlığını ayarla
            chart1.Titles.Add("Histogram");

            // Yeni bir seri oluştur
            Series seri = new Series("Histogram");
            seri.ChartType = SeriesChartType.Column;
            seri.Color = Color.Blue;
            seri.BorderWidth = 1;
            chart1.Series.Add(seri);

            // Histogramdaki en yüksek değeri bul
            int maxHistogramDegeri = 0;
            for (int i = 0; i < 256; i++)
            {
                if (histogramDegerleri[i] > maxHistogramDegeri)
                    maxHistogramDegeri = histogramDegerleri[i];
            }

            // Her gri seviye için histogram değerlerini grafiğe ekle
            for (int i = 0; i < 256; i++)
            {
                seri.Points.AddXY(i, histogramDegerleri[i]);
            }

            // X ekseni ayarları
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Interval = 51;
            chart1.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

            // Y ekseni ayarları
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = maxHistogramDegeri * 1.1; // En yüksek değerin %10 üstüne kadar göster
            chart1.ChartAreas[0].AxisY.Interval = maxHistogramDegeri / 10; // 10 aralık olacak şekilde ayarla
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = maxHistogramDegeri / 10;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
            chart1.ChartAreas[0].AxisY.Title = "Piksel Sayısı";
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Arka plan ayarları
            chart1.ChartAreas[0].BackColor = Color.White;

            // Gri resmi oluştur
            sonucResim = new Bitmap(islenecekResim.Width, islenecekResim.Height);
            for (int x = 0; x < islenecekResim.Width; x++)
            {
                for (int y = 0; y < islenecekResim.Height; y++)
                {
                    Color piksel = islenecekResim.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;
                    sonucResim.SetPixel(x, y, Color.FromArgb(griDeger, griDeger, griDeger));
                }
            }

            // Toplam piksel sayısını göster
            label8.Text = (islenecekResim.Width * islenecekResim.Height).ToString();
        }

        private void SonucuGoster()
        {
            if (sonucResim != null)
            {
                pictureBox2.Image = sonucResim;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Resim Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        originalImage = new Bitmap(pictureBox1.Image);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message, "Hata", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private class Point3D
        {
            public double[] Values { get; set; }
            public int ClusterIndex { get; set; }

            public Point3D(double[] values)
            {
                Values = values;
                ClusterIndex = -1;
            }
        }

        private class Cluster
        {
            public double[] Centroid { get; set; }
            public List<Point3D> Points { get; set; }
            public double[,] CovarianceMatrix { get; set; }
            public double[,] InverseCovarianceMatrix { get; set; }

            public Cluster(double[] centroid)
            {
                Centroid = centroid;
                Points = new List<Point3D>();
                CovarianceMatrix = new double[3, 3];
                InverseCovarianceMatrix = new double[3, 3];
            }
        }

        private double[,] CalculateCovarianceMatrix(List<Point3D> points, double[] centroid)
        {
            double[,] covariance = new double[3, 3];
            int n = points.Count;

            if (n <= 1) return covariance;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double sum = 0;
                    foreach (var point in points)
                    {
                        sum += (point.Values[i] - centroid[i]) * (point.Values[j] - centroid[j]);
                    }
                    covariance[i, j] = sum / (n - 1);
                }
            }

            return covariance;
        }

        private double MahalanobisDistance(double[] point, double[] centroid, double[,] inverseCovariance)
        {
            double[] diff = new double[3];
            for (int i = 0; i < 3; i++)
                diff[i] = point[i] - centroid[i];

            double distance = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    distance += diff[i] * inverseCovariance[i, j] * diff[j];

            return Math.Sqrt(distance);
        }

        private void KMMahalanobis()
        {
            if (islenecekResim == null) return;

            listView1.Items.Clear();
            listView2.Items.Clear();
            Array.Clear(histogramDegerleri, 0, histogramDegerleri.Length);

            int width = islenecekResim.Width;
            int height = islenecekResim.Height;
            int k = int.Parse(comboBox2.SelectedItem.ToString());

            // Gri değerler ve küme bilgileri için diziler
            int[] merkezler = new int[k];
            int[,] kume = new int[width, height];
            int[,] griResim = new int[width, height];

            // Resmi gri tonlamaya çevir ve histogram hesapla
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = islenecekResim.GetPixel(x, y);
                    int griDeger = (pixel.R + pixel.G + pixel.B) / 3;
                    griResim[x, y] = griDeger;
                    histogramDegerleri[griDeger]++;
                }
            }

            // Rastgele başlangıç merkezleri seç
            Random rnd = new Random();
            HashSet<int> secilenMerkezler = new HashSet<int>();
            for (int i = 0; i < k; i++)
            {
                int merkez;
                do
                {
                    int x = rnd.Next(width);
                    int y = rnd.Next(height);
                    merkez = griResim[x, y];
                } while (secilenMerkezler.Contains(merkez));

                secilenMerkezler.Add(merkez);
                merkezler[i] = merkez;

                // İlk merkezleri ListView1'de göster
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                listView1.Items.Add(item);
            }

            // K-means iterasyonları
            bool devam = true;
            int maxIter = 100;
            int iter = 0;

            while (devam && iter < maxIter)
            {
                devam = false;
                Array.Clear(kume, 0, kume.Length);

                // Her piksel için en yakın kümeyi bul
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int griDeger = griResim[x, y];
                        int minKume = 0;
                        double minDist = double.MaxValue;

                        // Her küme için Mahalanobis uzaklığını hesapla
                        for (int i = 0; i < k; i++)
                        {
                            double diff = griDeger - merkezler[i];
                            double kovaryans = diff * diff;
                            if (kovaryans < 1e-6) kovaryans = 1e-6;
                            double dist = (diff * diff) / kovaryans;

                            if (dist < minDist)
                            {
                                minDist = dist;
                                minKume = i;
                            }
                        }

                        if (kume[x, y] != minKume)
                        {
                            kume[x, y] = minKume;
                            devam = true;
                        }
                    }
                }

                // Küme merkezlerini güncelle
                int[] yeniMerkezler = new int[k];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int kumeNo = kume[x, y];
                        yeniMerkezler[kumeNo] += griResim[x, y];
                    }
                }

                for (int i = 0; i < k; i++)
                {
                    if (yeniMerkezler[i] > 0)
                    {
                        merkezler[i] = yeniMerkezler[i] / (width * height);
                    }
                }

                iter++;
            }

            // Sonuç görüntüsünü oluştur
            sonucResim = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int kumeNo = kume[x, y];
                    int griDeger = merkezler[kumeNo];
                    // Orijinal gri değeri ile küme merkezinin ortalamasını al
                    int sonGriDeger = (griResim[x, y] + griDeger) / 2;
                    sonucResim.SetPixel(x, y, Color.FromArgb(sonGriDeger, sonGriDeger, sonGriDeger));
                }
            }

            // Sonuçları ListView2'de göster
            for (int i = 0; i < k; i++)
            {
                ListViewItem item = new ListViewItem(histogramDegerleri[merkezler[i]].ToString());
                item.SubItems.Add((i + 1).ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                item.SubItems.Add(merkezler[i].ToString());
                listView2.Items.Add(item);
            }

            // Histogram grafiğini güncelle
            chart1.Series["Histogram"].Points.Clear();
            chart1.Series["Tepe Noktaları"].Points.Clear();

            int maxHistogramDegeri = 0;
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Histogram"].Points.AddXY(i, histogramDegerleri[i]);
                maxHistogramDegeri = Math.Max(maxHistogramDegeri, histogramDegerleri[i]);
            }

            // Tepe noktalarını göster
            for (int i = 0; i < k; i++)
            {
                chart1.Series["Tepe Noktaları"].Points.AddXY(merkezler[i], histogramDegerleri[merkezler[i]]);
            }

            // Y eksenini ayarla
            chart1.ChartAreas[0].AxisY.Maximum = maxHistogramDegeri + (maxHistogramDegeri * 0.1);
            chart1.ChartAreas[0].AxisY.Interval = maxHistogramDegeri / 10;

            // Sonuç görüntüsünü göster
            pictureBox2.Image = sonucResim;

            // Toplam piksel sayısını göster
            label8.Text = "Toplam Piksel: " + (width * height).ToString();
        }

        private double[,] MatrisTersiniAl(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] result = new double[n, n];
            double epsilon = 1e-6;

            double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                        - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                        + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            if (Math.Abs(det) < epsilon)
            {
                for (int i = 0; i < n; i++)
                {
                    result[i, i] = 1.0;
                }
                return result;
            }

            double[,] cofactor = new double[n, n];
            cofactor[0, 0] = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
            cofactor[0, 1] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            cofactor[0, 2] = matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0];
            cofactor[1, 0] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]);
            cofactor[1, 1] = matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0];
            cofactor[1, 2] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]);
            cofactor[2, 0] = matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1];
            cofactor[2, 1] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]);
            cofactor[2, 2] = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = cofactor[j, i] / det;
                }
            }

            return result;
        }

        private double[,] HesaplaKovaryansMatrisi(double[] x, double[] ortalama)
        {
            double[,] kovaryans = new double[3, 3];
            
            // Kovaryans matrisini hesapla
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kovaryans[i, j] = (x[i] - ortalama[i]) * (x[j] - ortalama[j]);
                }
            }

            // Sayısal kararlılık için diagonal elemanlara küçük bir değer ekle
            double epsilon = 1e-6;
            for (int i = 0; i < 3; i++)
            {
                kovaryans[i, i] += epsilon;
            }

            return kovaryans;
        }

        private void KMMahalanobisND()
        {
            if (islenecekResim == null) return;

            listView1.Items.Clear();
            listView2.Items.Clear();
            Array.Clear(histogramDegerleri, 0, histogramDegerleri.Length);

            int k = int.Parse(comboBox2.SelectedItem.ToString());
            int maxIterasyon = 100000;
            double threshold = 5;
            int iterasyon = 0;

            // RGB değerlerini diziye al
            List<Point3D> points = new List<Point3D>();
            for (int y = 0; y < islenecekResim.Height; y++)
            {
                for (int x = 0; x < islenecekResim.Width; x++)
                {
                    Color pixel = islenecekResim.GetPixel(x, y);
                    double[] values = new double[] { pixel.R, pixel.G, pixel.B };
                    points.Add(new Point3D(values));

                    int griDeger = (pixel.R + pixel.G + pixel.B) / 3;
                    histogramDegerleri[griDeger]++;
                }
            }

            // Küme merkezlerini RGB uzayında rastgele seç
            List<Cluster> clusters = new List<Cluster>();
            Dictionary<Color, int> initialClusterCounts = new Dictionary<Color, int>();

            while (clusters.Count < k)
            {
                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                
                Color clusterColor = Color.FromArgb(r, g, b);
                
                if (!initialClusterCounts.ContainsKey(clusterColor))
                {
                    double[] values = new double[] { r, g, b };
                    clusters.Add(new Cluster(values));
                    initialClusterCounts.Add(clusterColor, 0);

                    // Başlangıç merkezlerini ListView1'e ekle
                    ListViewItem item = new ListViewItem((clusters.Count).ToString());
                    item.SubItems.Add(r.ToString());
                    item.SubItems.Add(g.ToString());
                    item.SubItems.Add(b.ToString());
                    listView1.Items.Add(item);
                }
            }

            bool converged = false;
            while (!converged && iterasyon < maxIterasyon)
            {
                // Her küme için kovaryans matrisini hesapla
                foreach (var cluster in clusters)
                {
                    if (cluster.Points.Count > 1)
                    {
                        cluster.CovarianceMatrix = CalculateCovarianceMatrix(cluster.Points, cluster.Centroid);
                        cluster.InverseCovarianceMatrix = MatrisTersiniAl(cluster.CovarianceMatrix);
                    }
                    else
                    {
                        cluster.CovarianceMatrix = new double[3, 3];
                        cluster.InverseCovarianceMatrix = new double[3, 3];
                        for (int i = 0; i < 3; i++)
                        {
                            cluster.CovarianceMatrix[i, i] = 1.0;
                            cluster.InverseCovarianceMatrix[i, i] = 1.0;
                        }
                    }
                }

                // Noktaları kümelere ata
                bool pointsChanged = false;
                foreach (var point in points)
                {
                    double minDistance = double.MaxValue;
                    int newClusterIndex = point.ClusterIndex;

                    for (int i = 0; i < clusters.Count; i++)
                    {
                        double distance = MahalanobisDistance(point.Values, clusters[i].Centroid, clusters[i].InverseCovarianceMatrix);
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            newClusterIndex = i;
                        }
                    }

                    if (point.ClusterIndex != newClusterIndex)
                    {
                        point.ClusterIndex = newClusterIndex;
                        pointsChanged = true;
                    }
                }

                // Kümeleri güncelle
                foreach (var cluster in clusters)
                {
                    cluster.Points.Clear();
                }

                foreach (var point in points)
                {
                    clusters[point.ClusterIndex].Points.Add(point);
                }

                // Merkezleri güncelle
                double totalChange = 0;
                for (int i = 0; i < clusters.Count; i++)
                {
                    var cluster = clusters[i];
                    if (cluster.Points.Count > 0)
                    {
                        double[] newCentroid = new double[3];
                        foreach (var point in cluster.Points)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                newCentroid[j] += point.Values[j];
                            }
                        }

                        for (int j = 0; j < 3; j++)
                        {
                            newCentroid[j] /= cluster.Points.Count;
                            totalChange += Math.Abs(newCentroid[j] - cluster.Centroid[j]);
                        }

                        cluster.Centroid = newCentroid;
                    }

                }

                converged = !pointsChanged || totalChange < threshold;
                iterasyon++;
                label6.Text = iterasyon.ToString();
            }

            // Sonuçları ListView2'ye ekle
            listView2.Items.Clear();
            for (int i = 0; i < clusters.Count; i++)
            {
                var cluster = clusters[i];
                ListViewItem item = new ListViewItem(cluster.Points.Count.ToString());
                item.SubItems.Add((i + 1).ToString());
                item.SubItems.Add(((int)cluster.Centroid[0]).ToString());
                item.SubItems.Add(((int)cluster.Centroid[1]).ToString());
                item.SubItems.Add(((int)cluster.Centroid[2]).ToString());
                listView2.Items.Add(item);
            }

            // Sonuç resmini oluştur
            sonucResim = new Bitmap(islenecekResim.Width, islenecekResim.Height);
            int pixelIndex = 0;
            for (int y = 0; y < islenecekResim.Height; y++)
            {
                for (int x = 0; x < islenecekResim.Width; x++)
                {
                    var point = points[pixelIndex];
                    var cluster = clusters[point.ClusterIndex];

                    int r = (int)Math.Round(cluster.Centroid[0]);
                    int g = (int)Math.Round(cluster.Centroid[1]);
                    int b = (int)Math.Round(cluster.Centroid[2]);

                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));

                    sonucResim.SetPixel(x, y, Color.FromArgb(r, g, b));
                    pixelIndex++;
                }
            }

            // Chart'ı güncelle
            chart1.Series.Clear();
            Series histogramSeries = new Series("Histogram");
            histogramSeries.ChartType = SeriesChartType.Column;
            histogramSeries.Color = Color.Blue;
            histogramSeries.BorderWidth = 1;
            chart1.Series.Add(histogramSeries);

            Series tepeSeries = new Series("Tepe Noktaları");
            tepeSeries.ChartType = SeriesChartType.Point;
            tepeSeries.MarkerStyle = MarkerStyle.Circle;
            tepeSeries.MarkerSize = 12;
            tepeSeries.BorderWidth = 2;
            tepeSeries.Color = Color.Red;
            chart1.Series.Add(tepeSeries);

            // Histogram verilerini ekle ve maksimum değeri bul
            int maxHistogramDegeri = 0;
            for (int i = 0; i < 256; i++)
            {
                histogramSeries.Points.AddXY(i, histogramDegerleri[i]);
                maxHistogramDegeri = Math.Max(maxHistogramDegeri, histogramDegerleri[i]);
            }

            // Chart ayarları
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            chart1.ChartAreas[0].AxisY.Title = "Piksel Sayısı";
            
            // Y eksenini dinamik olarak ayarla
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = maxHistogramDegeri + (maxHistogramDegeri * 0.1); // %10 margin ekle
            chart1.ChartAreas[0].AxisY.Interval = maxHistogramDegeri / 10; // 10 aralık göster

            // Grid çizgilerini ve arka planı ayarla
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].BackColor = Color.White;

            // Tepe noktalarını ekle
            foreach (var cluster in clusters)
            {
                int griMerkez = (int)((cluster.Centroid[0] + cluster.Centroid[1] + cluster.Centroid[2]) / 3);
                tepeSeries.Points.AddXY(griMerkez, histogramDegerleri[griMerkez]);
            }

            label8.Text = points.Count.ToString();
        }
    }
}

