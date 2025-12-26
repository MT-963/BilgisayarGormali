namespace BilgisayarliGörmeFinal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnArabic = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnEnglish2 = new System.Windows.Forms.Button();
            this.btnTurkish = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOriginalImage = new System.Windows.Forms.Panel();
            this.lblOriginalImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelProcessedImage = new System.Windows.Forms.Panel();
            this.lblProcessedImage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelProcessingControls = new System.Windows.Forms.Panel();
            this.lblProcessingControls = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblSelectAlgorithm = new System.Windows.Forms.Label();
            this.lblNumberCluster = new System.Windows.Forms.Label();
            this.txtNumberCluster = new System.Windows.Forms.TextBox();
            this.lblNumIterations = new System.Windows.Forms.Label();
            this.txtNumIterations = new System.Windows.Forms.TextBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.lblThresholdValue = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.lblThresholdDisplay = new System.Windows.Forms.Label();
            this.btnApplyProcessing = new System.Windows.Forms.Button();
            this.panelAnalysisResults = new System.Windows.Forms.Panel();
            this.lblAnalysisResults = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelAnalysisResults2 = new System.Windows.Forms.Panel();
            this.lblAnalysisResults2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblPanelStats = new System.Windows.Forms.Label();
            this.listViewStats = new System.Windows.Forms.ListView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProcessingTime = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.lblTotalPixels = new System.Windows.Forms.Label();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelOriginalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelProcessedImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelProcessingControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            this.panelAnalysisResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelAnalysisResults2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panelStats.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Controls.Add(this.btnLoadImage);
            this.panelSidebar.Controls.Add(this.btnProcessImage);
            this.panelSidebar.Controls.Add(this.btnStatistics);
            this.panelSidebar.Controls.Add(this.lblStatistics);
            this.panelSidebar.Controls.Add(this.lblLanguage);
            this.panelSidebar.Controls.Add(this.btnArabic);
            this.panelSidebar.Controls.Add(this.btnEnglish);
            this.panelSidebar.Controls.Add(this.btnEnglish2);
            this.panelSidebar.Controls.Add(this.btnTurkish);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnExport);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 850);
            this.panelSidebar.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblLogo.Location = new System.Drawing.Point(15, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(170, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "CV Vision Pro";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadImage.FlatAppearance.BorderSize = 0;
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnLoadImage.Location = new System.Drawing.Point(15, 80);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadImage.Size = new System.Drawing.Size(170, 40);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "📁  Load Image";
            this.btnLoadImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnProcessImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessImage.FlatAppearance.BorderSize = 0;
            this.btnProcessImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProcessImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnProcessImage.Location = new System.Drawing.Point(15, 130);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProcessImage.Size = new System.Drawing.Size(170, 40);
            this.btnProcessImage.TabIndex = 1;
            this.btnProcessImage.Text = "⚙  Process Image";
            this.btnProcessImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessImage.UseVisualStyleBackColor = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnStatistics.Location = new System.Drawing.Point(15, 180);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(170, 40);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "📊  Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = false;
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatistics.Location = new System.Drawing.Point(25, 230);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(67, 20);
            this.lblStatistics.TabIndex = 3;
            this.lblStatistics.Text = "Statistics";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLanguage.Location = new System.Drawing.Point(15, 260);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(150, 20);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "🌐  Language / صلية";
            // 
            // btnArabic
            // 
            this.btnArabic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnArabic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArabic.FlatAppearance.BorderSize = 0;
            this.btnArabic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArabic.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnArabic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnArabic.Location = new System.Drawing.Point(15, 290);
            this.btnArabic.Name = "btnArabic";
            this.btnArabic.Size = new System.Drawing.Size(80, 28);
            this.btnArabic.TabIndex = 5;
            this.btnArabic.Text = "الناضجن";
            this.btnArabic.UseVisualStyleBackColor = false;
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnglish.FlatAppearance.BorderSize = 0;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnEnglish.Location = new System.Drawing.Point(105, 290);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(80, 28);
            this.btnEnglish.TabIndex = 6;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            // 
            // btnEnglish2
            // 
            this.btnEnglish2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnEnglish2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnglish2.FlatAppearance.BorderSize = 0;
            this.btnEnglish2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEnglish2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnEnglish2.Location = new System.Drawing.Point(15, 325);
            this.btnEnglish2.Name = "btnEnglish2";
            this.btnEnglish2.Size = new System.Drawing.Size(80, 28);
            this.btnEnglish2.TabIndex = 7;
            this.btnEnglish2.Text = "English";
            this.btnEnglish2.UseVisualStyleBackColor = false;
            // 
            // btnTurkish
            // 
            this.btnTurkish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnTurkish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurkish.FlatAppearance.BorderSize = 0;
            this.btnTurkish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurkish.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnTurkish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnTurkish.Location = new System.Drawing.Point(105, 325);
            this.btnTurkish.Name = "btnTurkish";
            this.btnTurkish.Size = new System.Drawing.Size(80, 28);
            this.btnTurkish.TabIndex = 8;
            this.btnTurkish.Text = "Türkçe";
            this.btnTurkish.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnSettings.Location = new System.Drawing.Point(15, 380);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(170, 40);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "⚙  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnExport.Location = new System.Drawing.Point(15, 430);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(170, 40);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "↓  Export Results";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panelMain.Controls.Add(this.panelOriginalImage);
            this.panelMain.Controls.Add(this.panelProcessedImage);
            this.panelMain.Controls.Add(this.panelProcessingControls);
            this.panelMain.Controls.Add(this.panelAnalysisResults);
            this.panelMain.Controls.Add(this.panelAnalysisResults2);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1180, 730);
            this.panelMain.TabIndex = 0;
            // 
            // panelOriginalImage
            // 
            this.panelOriginalImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelOriginalImage.Controls.Add(this.lblOriginalImage);
            this.panelOriginalImage.Controls.Add(this.pictureBox1);
            this.panelOriginalImage.Location = new System.Drawing.Point(20, 20);
            this.panelOriginalImage.Name = "panelOriginalImage";
            this.panelOriginalImage.Size = new System.Drawing.Size(380, 280);
            this.panelOriginalImage.TabIndex = 0;
            // 
            // lblOriginalImage
            // 
            this.lblOriginalImage.AutoSize = true;
            this.lblOriginalImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOriginalImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblOriginalImage.Location = new System.Drawing.Point(10, 10);
            this.lblOriginalImage.Name = "lblOriginalImage";
            this.lblOriginalImage.Size = new System.Drawing.Size(149, 23);
            this.lblOriginalImage.TabIndex = 0;
            this.lblOriginalImage.Text = "ORIGINAL IMAGE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelProcessedImage
            // 
            this.panelProcessedImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelProcessedImage.Controls.Add(this.lblProcessedImage);
            this.panelProcessedImage.Controls.Add(this.pictureBox2);
            this.panelProcessedImage.Location = new System.Drawing.Point(420, 20);
            this.panelProcessedImage.Name = "panelProcessedImage";
            this.panelProcessedImage.Size = new System.Drawing.Size(380, 280);
            this.panelProcessedImage.TabIndex = 1;
            // 
            // lblProcessedImage
            // 
            this.lblProcessedImage.AutoSize = true;
            this.lblProcessedImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProcessedImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblProcessedImage.Location = new System.Drawing.Point(10, 10);
            this.lblProcessedImage.Name = "lblProcessedImage";
            this.lblProcessedImage.Size = new System.Drawing.Size(165, 23);
            this.lblProcessedImage.TabIndex = 0;
            this.lblProcessedImage.Text = "PROCESSED IMAGE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pictureBox2.Location = new System.Drawing.Point(10, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelProcessingControls
            // 
            this.panelProcessingControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelProcessingControls.Controls.Add(this.lblProcessingControls);
            this.panelProcessingControls.Controls.Add(this.comboBoxAlgorithm);
            this.panelProcessingControls.Controls.Add(this.lblSelectAlgorithm);
            this.panelProcessingControls.Controls.Add(this.lblNumberCluster);
            this.panelProcessingControls.Controls.Add(this.txtNumberCluster);
            this.panelProcessingControls.Controls.Add(this.lblNumIterations);
            this.panelProcessingControls.Controls.Add(this.txtNumIterations);
            this.panelProcessingControls.Controls.Add(this.lblIterations);
            this.panelProcessingControls.Controls.Add(this.txtIterations);
            this.panelProcessingControls.Controls.Add(this.lblThresholdValue);
            this.panelProcessingControls.Controls.Add(this.trackBarThreshold);
            this.panelProcessingControls.Controls.Add(this.lblThresholdDisplay);
            this.panelProcessingControls.Controls.Add(this.btnApplyProcessing);
            this.panelProcessingControls.Location = new System.Drawing.Point(20, 320);
            this.panelProcessingControls.Name = "panelProcessingControls";
            this.panelProcessingControls.Size = new System.Drawing.Size(380, 400);
            this.panelProcessingControls.TabIndex = 2;
            // 
            // lblProcessingControls
            // 
            this.lblProcessingControls.AutoSize = true;
            this.lblProcessingControls.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProcessingControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblProcessingControls.Location = new System.Drawing.Point(15, 15);
            this.lblProcessingControls.Name = "lblProcessingControls";
            this.lblProcessingControls.Size = new System.Drawing.Size(198, 28);
            this.lblProcessingControls.TabIndex = 0;
            this.lblProcessingControls.Text = "Processing Controls";
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAlgorithm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(15, 50);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(350, 31);
            this.comboBoxAlgorithm.TabIndex = 1;
            // 
            // lblSelectAlgorithm
            // 
            this.lblSelectAlgorithm.AutoSize = true;
            this.lblSelectAlgorithm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblSelectAlgorithm.Location = new System.Drawing.Point(15, 90);
            this.lblSelectAlgorithm.Name = "lblSelectAlgorithm";
            this.lblSelectAlgorithm.Size = new System.Drawing.Size(146, 23);
            this.lblSelectAlgorithm.TabIndex = 2;
            this.lblSelectAlgorithm.Text = "Select Algorithm";
            // 
            // lblNumberCluster
            // 
            this.lblNumberCluster.AutoSize = true;
            this.lblNumberCluster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumberCluster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNumberCluster.Location = new System.Drawing.Point(15, 125);
            this.lblNumberCluster.Name = "lblNumberCluster";
            this.lblNumberCluster.Size = new System.Drawing.Size(112, 20);
            this.lblNumberCluster.TabIndex = 3;
            this.lblNumberCluster.Text = "Number Cluster";
            // 
            // txtNumberCluster
            // 
            this.txtNumberCluster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNumberCluster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberCluster.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumberCluster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtNumberCluster.Location = new System.Drawing.Point(200, 120);
            this.txtNumberCluster.Name = "txtNumberCluster";
            this.txtNumberCluster.Size = new System.Drawing.Size(100, 30);
            this.txtNumberCluster.TabIndex = 4;
            this.txtNumberCluster.Text = "5";
            this.txtNumberCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumIterations
            // 
            this.lblNumIterations.AutoSize = true;
            this.lblNumIterations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNumIterations.Location = new System.Drawing.Point(15, 165);
            this.lblNumIterations.Name = "lblNumIterations";
            this.lblNumIterations.Size = new System.Drawing.Size(96, 20);
            this.lblNumIterations.TabIndex = 5;
            this.lblNumIterations.Text = "Max Iterations";
            // 
            // txtNumIterations
            // 
            this.txtNumIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNumIterations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumIterations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtNumIterations.Location = new System.Drawing.Point(200, 160);
            this.txtNumIterations.Name = "txtNumIterations";
            this.txtNumIterations.Size = new System.Drawing.Size(100, 30);
            this.txtNumIterations.TabIndex = 6;
            this.txtNumIterations.Text = "100";
            this.txtNumIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblIterations.Location = new System.Drawing.Point(15, 205);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(71, 20);
            this.lblIterations.TabIndex = 7;
            this.lblIterations.Text = "Iterations";
            // 
            // txtIterations
            // 
            this.txtIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtIterations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIterations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtIterations.Location = new System.Drawing.Point(200, 200);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 30);
            this.txtIterations.TabIndex = 8;
            this.txtIterations.Text = "100";
            this.txtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThresholdValue
            // 
            this.lblThresholdValue.AutoSize = true;
            this.lblThresholdValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThresholdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblThresholdValue.Location = new System.Drawing.Point(15, 245);
            this.lblThresholdValue.Name = "lblThresholdValue";
            this.lblThresholdValue.Size = new System.Drawing.Size(166, 20);
            this.lblThresholdValue.TabIndex = 9;
            this.lblThresholdValue.Text = "Threshold Value (0-255)";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.trackBarThreshold.Location = new System.Drawing.Point(15, 275);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(280, 56);
            this.trackBarThreshold.TabIndex = 0;
            this.trackBarThreshold.TickFrequency = 25;
            this.trackBarThreshold.Value = 128;
            // 
            // lblThresholdDisplay
            // 
            this.lblThresholdDisplay.AutoSize = true;
            this.lblThresholdDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThresholdDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblThresholdDisplay.Location = new System.Drawing.Point(300, 280);
            this.lblThresholdDisplay.Name = "lblThresholdDisplay";
            this.lblThresholdDisplay.Size = new System.Drawing.Size(48, 28);
            this.lblThresholdDisplay.TabIndex = 10;
            this.lblThresholdDisplay.Text = "128";
            // 
            // btnApplyProcessing
            // 
            this.btnApplyProcessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnApplyProcessing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyProcessing.FlatAppearance.BorderSize = 0;
            this.btnApplyProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyProcessing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnApplyProcessing.ForeColor = System.Drawing.Color.White;
            this.btnApplyProcessing.Location = new System.Drawing.Point(80, 340);
            this.btnApplyProcessing.Name = "btnApplyProcessing";
            this.btnApplyProcessing.Size = new System.Drawing.Size(200, 45);
            this.btnApplyProcessing.TabIndex = 11;
            this.btnApplyProcessing.Text = "APPLY PROCESSING";
            this.btnApplyProcessing.UseVisualStyleBackColor = false;
            // 
            // panelAnalysisResults
            // 
            this.panelAnalysisResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelAnalysisResults.Controls.Add(this.lblAnalysisResults);
            this.panelAnalysisResults.Controls.Add(this.chart1);
            this.panelAnalysisResults.Location = new System.Drawing.Point(420, 320);
            this.panelAnalysisResults.Name = "panelAnalysisResults";
            this.panelAnalysisResults.Size = new System.Drawing.Size(380, 195);
            this.panelAnalysisResults.TabIndex = 3;
            // 
            // lblAnalysisResults
            // 
            this.lblAnalysisResults.AutoSize = true;
            this.lblAnalysisResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnalysisResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblAnalysisResults.Location = new System.Drawing.Point(10, 10);
            this.lblAnalysisResults.Name = "lblAnalysisResults";
            this.lblAnalysisResults.Size = new System.Drawing.Size(135, 23);
            this.lblAnalysisResults.TabIndex = 0;
            this.lblAnalysisResults.Text = "Analysis Results";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(10, 35);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(360, 150);
            this.chart1.TabIndex = 0;
            // 
            // panelAnalysisResults2
            // 
            this.panelAnalysisResults2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelAnalysisResults2.Controls.Add(this.lblAnalysisResults2);
            this.panelAnalysisResults2.Controls.Add(this.chart2);
            this.panelAnalysisResults2.Location = new System.Drawing.Point(420, 525);
            this.panelAnalysisResults2.Name = "panelAnalysisResults2";
            this.panelAnalysisResults2.Size = new System.Drawing.Size(380, 195);
            this.panelAnalysisResults2.TabIndex = 4;
            // 
            // lblAnalysisResults2
            // 
            this.lblAnalysisResults2.AutoSize = true;
            this.lblAnalysisResults2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnalysisResults2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblAnalysisResults2.Location = new System.Drawing.Point(10, 10);
            this.lblAnalysisResults2.Name = "lblAnalysisResults2";
            this.lblAnalysisResults2.Size = new System.Drawing.Size(135, 23);
            this.lblAnalysisResults2.TabIndex = 0;
            this.lblAnalysisResults2.Text = "Analysis Results";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(10, 35);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(360, 150);
            this.chart2.TabIndex = 0;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelStats.Controls.Add(this.lblPanelStats);
            this.panelStats.Controls.Add(this.listViewStats);
            this.panelStats.Location = new System.Drawing.Point(820, 20);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(170, 280);
            this.panelStats.TabIndex = 5;
            // 
            // lblPanelStats
            // 
            this.lblPanelStats.AutoSize = true;
            this.lblPanelStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPanelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPanelStats.Location = new System.Drawing.Point(10, 10);
            this.lblPanelStats.Name = "lblPanelStats";
            this.lblPanelStats.Size = new System.Drawing.Size(78, 20);
            this.lblPanelStats.TabIndex = 0;
            this.lblPanelStats.Text = "panelStats";
            // 
            // listViewStats
            // 
            this.listViewStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.listViewStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listViewStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.listViewStats.FullRowSelect = true;
            this.listViewStats.GridLines = true;
            this.listViewStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStats.HideSelection = false;
            this.listViewStats.Location = new System.Drawing.Point(10, 35);
            this.listViewStats.Name = "listViewStats";
            this.listViewStats.Size = new System.Drawing.Size(150, 235);
            this.listViewStats.TabIndex = 0;
            this.listViewStats.UseCompatibleStateImageBehavior = false;
            this.listViewStats.View = System.Windows.Forms.View.Details;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1180, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(350, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(686, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Computer Vision - Advanced Image Processing";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Controls.Add(this.lblProcessingTime);
            this.panelStatus.Controls.Add(this.progressBar);
            this.panelStatus.Controls.Add(this.lblProgressPercent);
            this.panelStatus.Controls.Add(this.lblTotalPixels);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(200, 790);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1180, 60);
            this.panelStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: Ready";
            // 
            // lblProcessingTime
            // 
            this.lblProcessingTime.AutoSize = true;
            this.lblProcessingTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProcessingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblProcessingTime.Location = new System.Drawing.Point(700, 10);
            this.lblProcessingTime.Name = "lblProcessingTime";
            this.lblProcessingTime.Size = new System.Drawing.Size(150, 20);
            this.lblProcessingTime.TabIndex = 1;
            this.lblProcessingTime.Text = "Processing Time: 0ms";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.progressBar.Location = new System.Drawing.Point(100, 35);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 15);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProgressPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblProgressPercent.Location = new System.Drawing.Point(20, 35);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(52, 20);
            this.lblProgressPercent.TabIndex = 2;
            this.lblProgressPercent.Text = "Status:";
            // 
            // lblTotalPixels
            // 
            this.lblTotalPixels.AutoSize = true;
            this.lblTotalPixels.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalPixels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTotalPixels.Location = new System.Drawing.Point(420, 35);
            this.lblTotalPixels.Name = "lblTotalPixels";
            this.lblTotalPixels.Size = new System.Drawing.Size(98, 20);
            this.lblTotalPixels.TabIndex = 3;
            this.lblTotalPixels.Text = "Total Pixels: 0";
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1380, 850);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV Vision Pro";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelOriginalImage.ResumeLayout(false);
            this.panelOriginalImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelProcessedImage.ResumeLayout(false);
            this.panelProcessedImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelProcessingControls.ResumeLayout(false);
            this.panelProcessingControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            this.panelAnalysisResults.ResumeLayout(false);
            this.panelAnalysisResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelAnalysisResults2.ResumeLayout(false);
            this.panelAnalysisResults2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Paneller
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelOriginalImage;
        private System.Windows.Forms.Panel panelProcessedImage;
        private System.Windows.Forms.Panel panelProcessingControls;
        private System.Windows.Forms.Panel panelAnalysisResults;
        private System.Windows.Forms.Panel panelAnalysisResults2;
        
        // Sidebar kontrolleri
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnArabic;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnEnglish2;
        private System.Windows.Forms.Button btnTurkish;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExport;
        
        // Header
        private System.Windows.Forms.Label lblTitle;
        
        // Resim panelleri
        private System.Windows.Forms.Label lblOriginalImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProcessedImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        
        // Processing Controls
        private System.Windows.Forms.Label lblProcessingControls;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label lblSelectAlgorithm;
        private System.Windows.Forms.Label lblNumberCluster;
        private System.Windows.Forms.TextBox txtNumberCluster;
        private System.Windows.Forms.Label lblNumIterations;
        private System.Windows.Forms.TextBox txtNumIterations;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label lblThresholdValue;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label lblThresholdDisplay;
        private System.Windows.Forms.Button btnApplyProcessing;
        
        // Analysis Results
        private System.Windows.Forms.Label lblAnalysisResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblAnalysisResults2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        
        // Stats Panel
        private System.Windows.Forms.Label lblPanelStats;
        private System.Windows.Forms.ListView listViewStats;
        
        // Status Bar
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProcessingTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Label lblTotalPixels;
        
        // Timer
        private System.Windows.Forms.Timer timerProgress;
    }
}
