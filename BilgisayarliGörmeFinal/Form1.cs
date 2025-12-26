using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO;

namespace BilgisayarliGörmeFinal
{
    public partial class Form1 : Form
    {
        // Ana değişkenler
        private Bitmap originalImage = null;
        private Bitmap processedImage = null;
        private Random random = new Random();
        private int[] histogramValues = new int[256];
        private int[] histogramR = new int[256];
        private int[] histogramG = new int[256];
        private int[] histogramB = new int[256];
        private Stopwatch stopwatch = new Stopwatch();
        private int totalPixels = 0;
        private bool isProcessing = false;

        // İşlenmiş histogram
        private int[] processedHistogramValues = new int[256];
        private int[] processedHistogramR = new int[256];
        private int[] processedHistogramG = new int[256];
        private int[] processedHistogramB = new int[256];

        // Renkler
        private readonly Color darkBackground = Color.FromArgb(26, 32, 44);
        private readonly Color sidebarColor = Color.FromArgb(30, 41, 59);
        private readonly Color panelColor = Color.FromArgb(45, 55, 72);
        private readonly Color accentColor = Color.FromArgb(16, 185, 129);
        private readonly Color textColor = Color.FromArgb(226, 232, 240);
        private readonly Color secondaryText = Color.FromArgb(148, 163, 184);

        // Mevcut dil
        private string currentLanguage = "en";

        public Form1()
        {
            InitializeComponent();
            SetupControls();
            SetupCharts();
            SetupListView();
            SetupEventHandlers();
            UpdateParameterVisibility();
        }

        private void SetupControls()
        {
            // ComboBox algoritma seçenekleri
            comboBoxAlgorithm.Items.AddRange(new string[] {
                "K-Means Clustering",
                "Grayscale",
                "Y Channel (Luminance)",
                "Histogram Equalization",
                "Edge Detection (Sobel)",
                "KM Euclidean RGB",
                "KM Mahalanobis",
                "Binary Threshold",
                "Gaussian Blur",
                "Sharpen Filter",
                "Invert Colors"
            });
            comboBoxAlgorithm.SelectedIndex = 0;

            // Varsayılan değerler
            txtNumberCluster.Text = "5";
            txtNumIterations.Text = "100";
            txtIterations.Text = "100";
            trackBarThreshold.Value = 128;
            lblThresholdDisplay.Text = "128";
        }

        private void SetupEventHandlers()
        {
            // Buton olayları
            btnLoadImage.Click += BtnLoadImage_Click;
            btnProcessImage.Click += BtnApplyProcessing_Click;
            btnApplyProcessing.Click += BtnApplyProcessing_Click;
            btnStatistics.Click += BtnStatistics_Click;
            btnExport.Click += BtnExport_Click;
            btnSettings.Click += BtnSettings_Click;

            // Dil butonları
            btnTurkish.Click += (s, e) => ChangeLanguage("tr");
            btnEnglish.Click += (s, e) => ChangeLanguage("en");
            btnEnglish2.Click += (s, e) => ChangeLanguage("en");
            btnArabic.Click += (s, e) => ChangeLanguage("ar");

            // TrackBar
            trackBarThreshold.ValueChanged += TrackBarThreshold_ValueChanged;

            // Algoritma değişikliği
            comboBoxAlgorithm.SelectedIndexChanged += ComboBoxAlgorithm_SelectedIndexChanged;

            // Hover efektleri
            SetupButtonHoverEffects();
        }

        private void ComboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParameterVisibility();
        }

        private void UpdateParameterVisibility()
        {
            string selected = comboBoxAlgorithm.SelectedItem?.ToString() ?? "";

            // K-Means algoritmaları: Cluster ve Iterations göster
            bool needsCluster = selected.Contains("K-Means") || selected.Contains("KM");
            bool needsThreshold = selected.Contains("Threshold") || selected.Contains("Edge");
            bool needsIterations = selected.Contains("K-Means") || selected.Contains("KM");

            // Parametre görünürlükleri
            lblNumberCluster.Visible = needsCluster;
            txtNumberCluster.Visible = needsCluster;

            lblNumIterations.Visible = needsIterations;
            txtNumIterations.Visible = needsIterations;

            lblIterations.Visible = needsIterations;
            txtIterations.Visible = needsIterations;

            lblThresholdValue.Visible = needsThreshold;
            trackBarThreshold.Visible = needsThreshold;
            lblThresholdDisplay.Visible = needsThreshold;
        }

        private void SetupButtonHoverEffects()
        {
            Button[] buttons = { btnLoadImage, btnProcessImage, btnStatistics, btnSettings, btnExport };

            foreach (var btn in buttons)
            {
                btn.MouseEnter += (s, e) => {
                    btn.BackColor = Color.FromArgb(71, 85, 105);
                };
                btn.MouseLeave += (s, e) => {
                    btn.BackColor = Color.FromArgb(51, 65, 85);
                };
            }

            btnApplyProcessing.MouseEnter += (s, e) => {
                btnApplyProcessing.BackColor = Color.FromArgb(5, 150, 105);
            };
            btnApplyProcessing.MouseLeave += (s, e) => {
                btnApplyProcessing.BackColor = accentColor;
            };
        }

        private void SetupCharts()
        {
            // Chart 1 - Histogram/Analysis
            chart1.Series.Clear();
            chart1.Legends.Clear();

            var legend1 = new Legend();
            legend1.ForeColor = textColor;
            legend1.BackColor = Color.Transparent;
            chart1.Legends.Add(legend1);

            Series seriesRed = new Series("Red");
            seriesRed.ChartType = SeriesChartType.Line;
            seriesRed.Color = Color.FromArgb(239, 68, 68);
            seriesRed.BorderWidth = 2;
            chart1.Series.Add(seriesRed);

            Series seriesGreen = new Series("Green");
            seriesGreen.ChartType = SeriesChartType.Line;
            seriesGreen.Color = Color.FromArgb(34, 197, 94);
            seriesGreen.BorderWidth = 2;
            chart1.Series.Add(seriesGreen);

            Series seriesBlue = new Series("Blue");
            seriesBlue.ChartType = SeriesChartType.Line;
            seriesBlue.Color = Color.FromArgb(59, 130, 246);
            seriesBlue.BorderWidth = 2;
            chart1.Series.Add(seriesBlue);

            // Chart 2 - İkinci analiz grafiği
            chart2.Series.Clear();
            chart2.Legends.Clear();

            var legend2 = new Legend();
            legend2.ForeColor = textColor;
            legend2.BackColor = Color.Transparent;
            chart2.Legends.Add(legend2);

            Series seriesOriginal = new Series("Original");
            seriesOriginal.ChartType = SeriesChartType.Line;
            seriesOriginal.Color = Color.FromArgb(139, 92, 246);
            seriesOriginal.BorderWidth = 2;
            chart2.Series.Add(seriesOriginal);

            Series seriesProcessed = new Series("Processed");
            seriesProcessed.ChartType = SeriesChartType.Line;
            seriesProcessed.Color = Color.FromArgb(236, 72, 153);
            seriesProcessed.BorderWidth = 2;
            chart2.Series.Add(seriesProcessed);

            Series seriesDiff = new Series("Difference");
            seriesDiff.ChartType = SeriesChartType.Line;
            seriesDiff.Color = accentColor;
            seriesDiff.BorderWidth = 2;
            chart2.Series.Add(seriesDiff);
        }

        private void SetupListView()
        {
            listViewStats.Columns.Clear();
            listViewStats.Columns.Add("Channel", 75);
            listViewStats.Columns.Add("Value", 70);

            UpdateStatsListView();
        }

        private void UpdateStatsListView()
        {
            listViewStats.Items.Clear();

            string[] channels = { "Original", "Processed", "Red", "Green", "Blue", "Difference" };

            foreach (var channel in channels)
            {
                var item = new ListViewItem(channel);
                item.SubItems.Add("-");
                item.ForeColor = textColor;
                listViewStats.Items.Add(item);
            }
        }

        private async void BtnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff|All Files|*.*";
                openFileDialog.Title = currentLanguage == "tr" ? "Resim Seç" : "Select Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        lblStatus.Text = currentLanguage == "tr" ? "Durum: Yükleniyor..." : "Status: Loading...";
                        progressBar.Value = 0;
                        btnLoadImage.Enabled = false;
                        btnApplyProcessing.Enabled = false;

                        string filePath = openFileDialog.FileName;
                        Bitmap loadedImage = null;

                        // Dosyadan yükle (UI thread dışında)
                        await Task.Run(() =>
                        {
                            using (var tempImage = new Bitmap(filePath))
                            {
                                // Yeni bir kopya oluştur (dosyayı serbest bırakmak için)
                                loadedImage = new Bitmap(tempImage.Width, tempImage.Height, PixelFormat.Format24bppRgb);
                                using (Graphics g = Graphics.FromImage(loadedImage))
                                {
                                    g.DrawImage(tempImage, 0, 0, tempImage.Width, tempImage.Height);
                                }
                            }
                        });

                        // Eski resmi temizle
                        if (originalImage != null)
                        {
                            pictureBox1.Image = null;
                            originalImage.Dispose();
                        }

                        originalImage = loadedImage;
                        pictureBox1.Image = originalImage;
                        pictureBox2.Image = null;
                        
                        if (processedImage != null)
                        {
                            processedImage.Dispose();
                            processedImage = null;
                        }

                        totalPixels = originalImage.Width * originalImage.Height;
                        lblTotalPixels.Text = $"Total Pixels: {totalPixels:N0}";

                        // Histogram hesapla - kopya üzerinde
                        Bitmap histogramCopy = CloneBitmap(originalImage);
                        await Task.Run(() => CalculateHistogramsFast(histogramCopy));
                        histogramCopy.Dispose();

                        UpdateCharts();
                        UpdateStatsWithImageData();

                        lblStatus.Text = currentLanguage == "tr" ? "Durum: Resim yüklendi" : "Status: Image loaded";
                        progressBar.Value = 100;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = currentLanguage == "tr" ? "Durum: Hata oluştu" : "Status: Error";
                    }
                    finally
                    {
                        btnLoadImage.Enabled = true;
                        btnApplyProcessing.Enabled = true;
                    }
                }
            }
        }

        // Thread-safe bitmap kopyalama
        private Bitmap CloneBitmap(Bitmap source)
        {
            lock (source)
            {
                Bitmap clone = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);
                using (Graphics g = Graphics.FromImage(clone))
                {
                    g.DrawImage(source, 0, 0, source.Width, source.Height);
                }
                return clone;
            }
        }

        private async void BtnApplyProcessing_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                string msg = currentLanguage == "tr" ? "Lütfen önce bir resim yükleyin!" : "Please load an image first!";
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isProcessing) return;
            isProcessing = true;

            lblStatus.Text = currentLanguage == "tr" ? "Durum: İşleniyor..." : "Status: Processing...";
            progressBar.Value = 0;
            btnLoadImage.Enabled = false;
            btnApplyProcessing.Enabled = false;
            stopwatch.Restart();

            try
            {
                string selectedAlgorithm = comboBoxAlgorithm.SelectedItem?.ToString() ?? "K-Means Clustering";

                // UI değerlerini önceden al (cross-thread hatası önlenir)
                int thresholdValue = trackBarThreshold.Value;
                int clusterCount = int.TryParse(txtNumberCluster.Text, out int kVal) ? kVal : 5;
                int maxIterations = int.TryParse(txtIterations.Text, out int maxIter) ? maxIter : 100;

                // Progress güncelleme
                var progress = new Progress<int>(percent =>
                {
                    if (percent <= 100)
                    {
                        progressBar.Value = percent;
                        lblProgressPercent.Text = $"{percent}%";
                    }
                });

                // İşleme için orijinal resmin kopyasını oluştur
                Bitmap workingCopy = CloneBitmap(originalImage);

                Bitmap result = await Task.Run(() =>
                {
                    switch (selectedAlgorithm)
                    {
                        case "K-Means Clustering":
                            return ApplyKMeansIntensityFast(workingCopy, clusterCount, maxIterations, progress);
                        case "Grayscale":
                            return ApplyGrayscaleFast(workingCopy, progress);
                        case "Y Channel (Luminance)":
                            return ApplyYChannelFast(workingCopy, progress);
                        case "Histogram Equalization":
                            return ApplyHistogramEqualizationFast(workingCopy, progress);
                        case "Edge Detection (Sobel)":
                            return ApplyEdgeDetectionFast(workingCopy, thresholdValue, progress);
                        case "KM Euclidean RGB":
                            return ApplyKMeansRGBFast(workingCopy, clusterCount, maxIterations, progress);
                        case "KM Mahalanobis":
                            return ApplyKMeansIntensityFast(workingCopy, clusterCount, maxIterations, progress);
                        case "Binary Threshold":
                            return ApplyBinaryThresholdFast(workingCopy, thresholdValue, progress);
                        case "Gaussian Blur":
                            return ApplyGaussianBlurFast(workingCopy, progress);
                        case "Sharpen Filter":
                            return ApplySharpenFilterFast(workingCopy, progress);
                        case "Invert Colors":
                            return ApplyInvertColorsFast(workingCopy, progress);
                        default:
                            return ApplyGrayscaleFast(workingCopy, progress);
                    }
                });

                // Çalışma kopyasını temizle
                workingCopy.Dispose();

                // Eski işlenmiş resmi temizle
                if (processedImage != null)
                {
                    pictureBox2.Image = null;
                    processedImage.Dispose();
                }

                processedImage = result;
                stopwatch.Stop();
                pictureBox2.Image = processedImage;

                lblProcessingTime.Text = $"Processing Time: {stopwatch.ElapsedMilliseconds}ms";
                lblStatus.Text = currentLanguage == "tr" ? "Durum: İşlem tamamlandı" : "Status: Completed";
                progressBar.Value = 100;

                if (processedImage != null)
                {
                    Bitmap histCopy = CloneBitmap(processedImage);
                    await Task.Run(() => CalculateProcessedHistogramsFast(histCopy));
                    histCopy.Dispose();
                    UpdateChartsWithComparison();
                    UpdateStatsWithImageData();
                }
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                lblStatus.Text = currentLanguage == "tr" ? "Durum: Hata" : "Status: Error";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isProcessing = false;
                btnLoadImage.Enabled = true;
                btnApplyProcessing.Enabled = true;
            }
        }

        // ==================
        // HIZLI PİKSEL ERİŞİMİ (LockBits)
        // ==================

        private void CalculateHistogramsFast(Bitmap image)
        {
            Array.Clear(histogramValues, 0, 256);
            Array.Clear(histogramR, 0, 256);
            Array.Clear(histogramG, 0, 256);
            Array.Clear(histogramB, 0, 256);

            BitmapData bmpData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            int bytes = Math.Abs(stride) * image.Height;
            byte[] pixels = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, pixels, 0, bytes);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int idx = y * stride + x * 3;
                    byte b = pixels[idx];
                    byte g = pixels[idx + 1];
                    byte r = pixels[idx + 2];

                    int gray = (r + g + b) / 3;
                    histogramValues[gray]++;
                    histogramR[r]++;
                    histogramG[g]++;
                    histogramB[b]++;
                }
            }

            image.UnlockBits(bmpData);
        }

        private void CalculateProcessedHistogramsFast(Bitmap image)
        {
            Array.Clear(processedHistogramValues, 0, 256);
            Array.Clear(processedHistogramR, 0, 256);
            Array.Clear(processedHistogramG, 0, 256);
            Array.Clear(processedHistogramB, 0, 256);

            BitmapData bmpData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            int bytes = Math.Abs(stride) * image.Height;
            byte[] pixels = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, pixels, 0, bytes);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int idx = y * stride + x * 3;
                    byte b = pixels[idx];
                    byte g = pixels[idx + 1];
                    byte r = pixels[idx + 2];

                    int gray = (r + g + b) / 3;
                    processedHistogramValues[gray]++;
                    processedHistogramR[r]++;
                    processedHistogramG[g]++;
                    processedHistogramB[b]++;
                }
            }

            image.UnlockBits(bmpData);
        }

        // ==================
        // HIZLI ALGORİTMALAR
        // ==================

        private Bitmap ApplyGrayscaleFast(Bitmap source, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;
            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    byte gray = (byte)((srcPixels[idx] + srcPixels[idx + 1] + srcPixels[idx + 2]) / 3);
                    dstPixels[idx] = gray;
                    dstPixels[idx + 1] = gray;
                    dstPixels[idx + 2] = gray;
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyYChannelFast(Bitmap source, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;
            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    byte b = srcPixels[idx];
                    byte g = srcPixels[idx + 1];
                    byte r = srcPixels[idx + 2];

                    byte yVal = (byte)Math.Min(255, Math.Max(0, (int)(0.299 * r + 0.587 * g + 0.114 * b)));
                    dstPixels[idx] = yVal;
                    dstPixels[idx + 1] = yVal;
                    dstPixels[idx + 2] = yVal;
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyHistogramEqualizationFast(Bitmap source, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;

            // Kümülatif histogram
            int[] cumulative = new int[256];
            cumulative[0] = histogramValues[0];
            for (int i = 1; i < 256; i++)
                cumulative[i] = cumulative[i - 1] + histogramValues[i];

            // Mapping
            byte[] mapping = new byte[256];
            for (int i = 0; i < 256; i++)
                mapping[i] = (byte)(((double)cumulative[i] / totalPixels) * 255);

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    byte gray = (byte)((srcPixels[idx] + srcPixels[idx + 1] + srcPixels[idx + 2]) / 3);
                    byte newGray = mapping[gray];
                    dstPixels[idx] = newGray;
                    dstPixels[idx + 1] = newGray;
                    dstPixels[idx + 2] = newGray;
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyBinaryThresholdFast(Bitmap source, int threshold, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    int gray = (srcPixels[idx] + srcPixels[idx + 1] + srcPixels[idx + 2]) / 3;
                    byte value = (byte)(gray > threshold ? 255 : 0);
                    dstPixels[idx] = value;
                    dstPixels[idx + 1] = value;
                    dstPixels[idx + 2] = value;
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyInvertColorsFast(Bitmap source, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;
            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    dstPixels[idx] = (byte)(255 - srcPixels[idx]);
                    dstPixels[idx + 1] = (byte)(255 - srcPixels[idx + 1]);
                    dstPixels[idx + 2] = (byte)(255 - srcPixels[idx + 2]);
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyEdgeDetectionFast(Bitmap source, int threshold, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            // Gri görüntü
            int[,] gray = new int[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    gray[x, y] = (srcPixels[idx] + srcPixels[idx + 1] + srcPixels[idx + 2]) / 3;
                }
            }

            // Sobel
            int[,] sobelX = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] sobelY = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int gx = 0, gy = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            gx += gray[x + j, y + i] * sobelX[i + 1, j + 1];
                            gy += gray[x + j, y + i] * sobelY[i + 1, j + 1];
                        }
                    }

                    int magnitude = (int)Math.Sqrt(gx * gx + gy * gy);
                    byte value = (byte)(magnitude > threshold ? 255 : 0);

                    int idx = y * stride + x * 3;
                    dstPixels[idx] = value;
                    dstPixels[idx + 1] = value;
                    dstPixels[idx + 2] = value;
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyGaussianBlurFast(Bitmap source, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;

            double[,] kernel = {
                { 1, 4, 7, 4, 1 },
                { 4, 16, 26, 16, 4 },
                { 7, 26, 41, 26, 7 },
                { 4, 16, 26, 16, 4 },
                { 1, 4, 7, 4, 1 }
            };
            double kernelSum = 273;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);
            Array.Copy(srcPixels, dstPixels, bytes); // Kenarlar için

            for (int y = 2; y < height - 2; y++)
            {
                for (int x = 2; x < width - 2; x++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int i = -2; i <= 2; i++)
                    {
                        for (int j = -2; j <= 2; j++)
                        {
                            int idx = (y + i) * stride + (x + j) * 3;
                            double weight = kernel[i + 2, j + 2];
                            b += srcPixels[idx] * weight;
                            g += srcPixels[idx + 1] * weight;
                            r += srcPixels[idx + 2] * weight;
                        }
                    }

                    int dstIdx = y * stride + x * 3;
                    dstPixels[dstIdx] = (byte)Math.Min(255, Math.Max(0, b / kernelSum));
                    dstPixels[dstIdx + 1] = (byte)Math.Min(255, Math.Max(0, g / kernelSum));
                    dstPixels[dstIdx + 2] = (byte)Math.Min(255, Math.Max(0, r / kernelSum));
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplySharpenFilterFast(Bitmap source, IProgress<int> progress)
        {
            int width = source.Width;
            int height = source.Height;

            int[,] kernel = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            byte[] dstPixels = new byte[bytes];

            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);
            Array.Copy(srcPixels, dstPixels, bytes);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int r = 0, g = 0, b = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int idx = (y + i) * stride + (x + j) * 3;
                            int weight = kernel[i + 1, j + 1];
                            b += srcPixels[idx] * weight;
                            g += srcPixels[idx + 1] * weight;
                            r += srcPixels[idx + 2] * weight;
                        }
                    }

                    int dstIdx = y * stride + x * 3;
                    dstPixels[dstIdx] = (byte)Math.Min(255, Math.Max(0, b));
                    dstPixels[dstIdx + 1] = (byte)Math.Min(255, Math.Max(0, g));
                    dstPixels[dstIdx + 2] = (byte)Math.Min(255, Math.Max(0, r));
                }

                if (y % 50 == 0)
                    progress?.Report((y * 100) / height);
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);

            source.UnlockBits(srcData);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyKMeansIntensityFast(Bitmap source, int k, int maxIterations, IProgress<int> progress)
        {

            int width = source.Width;
            int height = source.Height;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            // Gri değerler
            byte[,] grayImage = new byte[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int idx = y * stride + x * 3;
                    grayImage[x, y] = (byte)((srcPixels[idx] + srcPixels[idx + 1] + srcPixels[idx + 2]) / 3);
                }
            }

            source.UnlockBits(srcData);

            // K-Means
            int[] centers = new int[k];
            int[,] clusters = new int[width, height];

            for (int i = 0; i < k; i++)
                centers[i] = random.Next(0, 256);

            bool changed = true;
            int iteration = 0;

            while (changed && iteration < maxIterations)
            {
                changed = false;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int value = grayImage[x, y];
                        int nearestCluster = 0;
                        int minDistance = Math.Abs(value - centers[0]);

                        for (int c = 1; c < k; c++)
                        {
                            int distance = Math.Abs(value - centers[c]);
                            if (distance < minDistance)
                            {
                                minDistance = distance;
                                nearestCluster = c;
                            }
                        }

                        if (clusters[x, y] != nearestCluster)
                        {
                            clusters[x, y] = nearestCluster;
                            changed = true;
                        }
                    }
                }

                // Merkezleri güncelle
                long[] sums = new long[k];
                int[] counts = new int[k];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int c = clusters[x, y];
                        sums[c] += grayImage[x, y];
                        counts[c]++;
                    }
                }

                for (int c = 0; c < k; c++)
                {
                    if (counts[c] > 0)
                        centers[c] = (int)(sums[c] / counts[c]);
                }

                iteration++;
                progress?.Report((iteration * 100) / maxIterations);
            }

            // Sonuç oluştur
            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            byte[] dstPixels = new byte[bytes];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    byte value = (byte)centers[clusters[x, y]];
                    int idx = y * stride + x * 3;
                    dstPixels[idx] = value;
                    dstPixels[idx + 1] = value;
                    dstPixels[idx + 2] = value;
                }
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        private Bitmap ApplyKMeansRGBFast(Bitmap source, int k, int maxIterations, IProgress<int> progress)
        {

            int width = source.Width;
            int height = source.Height;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int stride = srcData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] srcPixels = new byte[bytes];
            Marshal.Copy(srcData.Scan0, srcPixels, 0, bytes);

            source.UnlockBits(srcData);

            // RGB merkezleri
            int[,] centers = new int[k, 3];
            int[,] clusters = new int[width, height];

            for (int i = 0; i < k; i++)
            {
                centers[i, 0] = random.Next(0, 256);
                centers[i, 1] = random.Next(0, 256);
                centers[i, 2] = random.Next(0, 256);
            }

            bool changed = true;
            int iteration = 0;

            while (changed && iteration < maxIterations)
            {
                changed = false;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int idx = y * stride + x * 3;
                        int b = srcPixels[idx];
                        int g = srcPixels[idx + 1];
                        int r = srcPixels[idx + 2];

                        int nearestCluster = 0;
                        double minDist = double.MaxValue;

                        for (int c = 0; c < k; c++)
                        {
                            double dist = Math.Sqrt(
                                Math.Pow(r - centers[c, 0], 2) +
                                Math.Pow(g - centers[c, 1], 2) +
                                Math.Pow(b - centers[c, 2], 2));

                            if (dist < minDist)
                            {
                                minDist = dist;
                                nearestCluster = c;
                            }
                        }

                        if (clusters[x, y] != nearestCluster)
                        {
                            clusters[x, y] = nearestCluster;
                            changed = true;
                        }
                    }
                }

                // Merkezleri güncelle
                long[,] sums = new long[k, 3];
                int[] counts = new int[k];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int idx = y * stride + x * 3;
                        int c = clusters[x, y];
                        sums[c, 2] += srcPixels[idx];     // B
                        sums[c, 1] += srcPixels[idx + 1]; // G
                        sums[c, 0] += srcPixels[idx + 2]; // R
                        counts[c]++;
                    }
                }

                for (int c = 0; c < k; c++)
                {
                    if (counts[c] > 0)
                    {
                        centers[c, 0] = (int)(sums[c, 0] / counts[c]);
                        centers[c, 1] = (int)(sums[c, 1] / counts[c]);
                        centers[c, 2] = (int)(sums[c, 2] / counts[c]);
                    }
                }

                iteration++;
                progress?.Report((iteration * 100) / maxIterations);
            }

            // Sonuç oluştur
            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            byte[] dstPixels = new byte[bytes];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int c = clusters[x, y];
                    int idx = y * stride + x * 3;
                    dstPixels[idx] = (byte)centers[c, 2];     // B
                    dstPixels[idx + 1] = (byte)centers[c, 1]; // G
                    dstPixels[idx + 2] = (byte)centers[c, 0]; // R
                }
            }

            Marshal.Copy(dstPixels, 0, dstData.Scan0, bytes);
            result.UnlockBits(dstData);

            progress?.Report(100);
            return result;
        }

        // ==================
        // UI GÜNCELLEME
        // ==================

        private void UpdateCharts()
        {
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();

            for (int i = 0; i < 256; i += 5)
            {
                chart1.Series["Red"].Points.AddXY(i, histogramR[i]);
                chart1.Series["Green"].Points.AddXY(i, histogramG[i]);
                chart1.Series["Blue"].Points.AddXY(i, histogramB[i]);
            }
        }

        private void UpdateChartsWithComparison()
        {
            UpdateCharts();

            chart2.Series["Original"].Points.Clear();
            chart2.Series["Processed"].Points.Clear();
            chart2.Series["Difference"].Points.Clear();

            for (int i = 0; i < 256; i += 5)
            {
                chart2.Series["Original"].Points.AddXY(i, histogramValues[i]);
                chart2.Series["Processed"].Points.AddXY(i, processedHistogramValues[i]);
                chart2.Series["Difference"].Points.AddXY(i, Math.Abs(histogramValues[i] - processedHistogramValues[i]));
            }
        }

        private void UpdateStatsWithImageData()
        {
            listViewStats.Items.Clear();

            if (originalImage != null && totalPixels > 0)
            {
                double avgOriginal = histogramValues.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
                AddStatItem("Original", avgOriginal.ToString("F1"));

                if (processedImage != null)
                {
                    double avgProcessed = processedHistogramValues.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
                    AddStatItem("Processed", avgProcessed.ToString("F1"));
                }

                AddStatItem("Red", (histogramR.Select((v, i) => (long)v * i).Sum() / (double)totalPixels).ToString("F1"));
                AddStatItem("Green", (histogramG.Select((v, i) => (long)v * i).Sum() / (double)totalPixels).ToString("F1"));
                AddStatItem("Blue", (histogramB.Select((v, i) => (long)v * i).Sum() / (double)totalPixels).ToString("F1"));

                if (processedImage != null)
                {
                    double avgOrig = histogramValues.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
                    double avgProc = processedHistogramValues.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
                    AddStatItem("Difference", Math.Abs(avgOrig - avgProc).ToString("F2"));
                }
            }
        }

        private void AddStatItem(string channel, string value)
        {
            var item = new ListViewItem(channel);
            item.SubItems.Add(value);
            item.ForeColor = textColor;
            listViewStats.Items.Add(item);
        }

        private void TrackBarThreshold_ValueChanged(object sender, EventArgs e)
        {
            lblThresholdDisplay.Text = trackBarThreshold.Value.ToString();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                string msg = currentLanguage == "tr" ? "Lütfen önce bir resim yükleyin!" : "Please load an image first!";
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double avgR = histogramR.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
            double avgG = histogramG.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
            double avgB = histogramB.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;
            double avgGray = histogramValues.Select((v, i) => (long)v * i).Sum() / (double)totalPixels;

            string title = currentLanguage == "tr" ? "Görüntü İstatistikleri" : "Image Statistics";
            string stats = currentLanguage == "tr" ?
                $"Görüntü İstatistikleri\n" +
                $"====================\n\n" +
                $"Genişlik: {originalImage.Width}px\n" +
                $"Yükseklik: {originalImage.Height}px\n" +
                $"Toplam Piksel: {totalPixels:N0}\n\n" +
                $"Ortalama Yoğunluk: {avgGray:F2}\n" +
                $"Kırmızı Kanal Ort: {avgR:F2}\n" +
                $"Yeşil Kanal Ort: {avgG:F2}\n" +
                $"Mavi Kanal Ort: {avgB:F2}"
                :
                $"Image Statistics\n" +
                $"================\n\n" +
                $"Width: {originalImage.Width}px\n" +
                $"Height: {originalImage.Height}px\n" +
                $"Total Pixels: {totalPixels:N0}\n\n" +
                $"Average Intensity: {avgGray:F2}\n" +
                $"Red Channel Avg: {avgR:F2}\n" +
                $"Green Channel Avg: {avgG:F2}\n" +
                $"Blue Channel Avg: {avgB:F2}";

            MessageBox.Show(stats, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (processedImage == null)
            {
                string msg = currentLanguage == "tr" ? "Dışa aktarılacak işlenmiş görüntü yok!" : "No processed image to export!";
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap|*.bmp";
                saveDialog.Title = currentLanguage == "tr" ? "İşlenmiş Görüntüyü Kaydet" : "Export Processed Image";
                saveDialog.FileName = "processed_image";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Png;
                        if (saveDialog.FileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                            format = ImageFormat.Jpeg;
                        else if (saveDialog.FileName.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                            format = ImageFormat.Bmp;

                        processedImage.Save(saveDialog.FileName, format);
                        string msg = currentLanguage == "tr" ? "Görüntü başarıyla kaydedildi!" : "Image exported successfully!";
                        MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            string title = currentLanguage == "tr" ? "Ayarlar" : "Settings";
            string msg = currentLanguage == "tr" ?
                $"Mevcut Ayarlar:\n\n" +
                $"• Küme Sayısı: {txtNumberCluster.Text}\n" +
                $"• Maksimum İterasyon: {txtIterations.Text}\n" +
                $"• Eşik Değeri: {trackBarThreshold.Value}"
                :
                $"Current Settings:\n\n" +
                $"• Cluster Count: {txtNumberCluster.Text}\n" +
                $"• Max Iterations: {txtIterations.Text}\n" +
                $"• Threshold: {trackBarThreshold.Value}";

            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeLanguage(string lang)
        {
            currentLanguage = lang;

            switch (lang)
            {
                case "tr":
                    lblTitle.Text = "Bilgisayarlı Görme - Gelişmiş Görüntü İşleme";
                    btnLoadImage.Text = "📁  Resim Yükle";
                    btnProcessImage.Text = "⚙  Resmi İşle";
                    btnStatistics.Text = "📊  İstatistikler";
                    btnSettings.Text = "⚙  Ayarlar";
                    btnExport.Text = "↓  Sonucu Kaydet";
                    lblOriginalImage.Text = "ORİJİNAL RESİM";
                    lblProcessedImage.Text = "İŞLENMİŞ RESİM";
                    lblProcessingControls.Text = "İşlem Kontrolleri";
                    lblSelectAlgorithm.Text = "Algoritma Seç";
                    lblNumberCluster.Text = "Küme Sayısı";
                    lblNumIterations.Text = "Max İterasyon";
                    lblIterations.Text = "İterasyon";
                    lblThresholdValue.Text = "Eşik Değeri (0-255)";
                    btnApplyProcessing.Text = "İŞLEMİ UYGULA";
                    lblAnalysisResults.Text = "Analiz Sonuçları";
                    lblAnalysisResults2.Text = "Karşılaştırma";
                    lblStatus.Text = "Durum: Hazır";
                    break;
                case "en":
                    lblTitle.Text = "Computer Vision - Advanced Image Processing";
                    btnLoadImage.Text = "📁  Load Image";
                    btnProcessImage.Text = "⚙  Process Image";
                    btnStatistics.Text = "📊  Statistics";
                    btnSettings.Text = "⚙  Settings";
                    btnExport.Text = "↓  Export Results";
                    lblOriginalImage.Text = "ORIGINAL IMAGE";
                    lblProcessedImage.Text = "PROCESSED IMAGE";
                    lblProcessingControls.Text = "Processing Controls";
                    lblSelectAlgorithm.Text = "Select Algorithm";
                    lblNumberCluster.Text = "Cluster Count";
                    lblNumIterations.Text = "Max Iterations";
                    lblIterations.Text = "Iterations";
                    lblThresholdValue.Text = "Threshold (0-255)";
                    btnApplyProcessing.Text = "APPLY PROCESSING";
                    lblAnalysisResults.Text = "Analysis Results";
                    lblAnalysisResults2.Text = "Comparison";
                    lblStatus.Text = "Status: Ready";
                    break;
                case "ar":
                    lblTitle.Text = "الرؤية الحاسوبية - معالجة الصور المتقدمة";
                    btnLoadImage.Text = "📁  تحميل الصورة";
                    btnProcessImage.Text = "⚙  معالجة الصورة";
                    btnStatistics.Text = "📊  إحصائيات";
                    btnSettings.Text = "⚙  الإعدادات";
                    btnExport.Text = "↓  تصدير النتائج";
                    lblOriginalImage.Text = "الصورة الأصلية";
                    lblProcessedImage.Text = "الصورة المعالجة";
                    lblProcessingControls.Text = "عناصر التحكم";
                    lblSelectAlgorithm.Text = "اختر الخوارزمية";
                    lblNumberCluster.Text = "عدد المجموعات";
                    lblNumIterations.Text = "الحد الأقصى";
                    lblIterations.Text = "التكرارات";
                    lblThresholdValue.Text = "قيمة العتبة (0-255)";
                    btnApplyProcessing.Text = "تطبيق المعالجة";
                    lblAnalysisResults.Text = "نتائج التحليل";
                    lblAnalysisResults2.Text = "مقارنة";
                    lblStatus.Text = "الحالة: جاهز";
                    break;
            }
        }
    }
}
