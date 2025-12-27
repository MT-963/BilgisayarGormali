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
            components = new System.ComponentModel.Container();
            panelSidebar = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            btnLoadImage = new System.Windows.Forms.Button();
            btnProcessImage = new System.Windows.Forms.Button();
            btnStatistics = new System.Windows.Forms.Button();
            lblStatistics = new System.Windows.Forms.Label();
            lblTheme = new System.Windows.Forms.Label();
            comboTheme = new System.Windows.Forms.ComboBox();
            lblLanguage = new System.Windows.Forms.Label();
            btnArabic = new System.Windows.Forms.Button();
            btnEnglish = new System.Windows.Forms.Button();
            btnTurkish = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            lblQuickActions = new System.Windows.Forms.Label();
            btnQuickTour = new System.Windows.Forms.Button();
            btnShortcutTips = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelKpiStrip = new System.Windows.Forms.Panel();
            panelKpiAlgorithm = new System.Windows.Forms.Panel();
            lblKpiAlgorithmValue = new System.Windows.Forms.Label();
            lblKpiAlgorithmTitle = new System.Windows.Forms.Label();
            panelKpiPixels = new System.Windows.Forms.Panel();
            lblKpiPixelsValue = new System.Windows.Forms.Label();
            lblKpiPixelsTitle = new System.Windows.Forms.Label();
            panelKpiPerformance = new System.Windows.Forms.Panel();
            lblKpiProcessingValue = new System.Windows.Forms.Label();
            lblKpiProcessingTitle = new System.Windows.Forms.Label();
            panelOriginalImage = new System.Windows.Forms.Panel();
            lblOriginalImage = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblOriginalPlaceholder = new System.Windows.Forms.Label();
            panelProcessedImage = new System.Windows.Forms.Panel();
            lblProcessedImage = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lblProcessedPlaceholder = new System.Windows.Forms.Label();
            panelProcessingControls = new System.Windows.Forms.Panel();
            lblProcessingControls = new System.Windows.Forms.Label();
            comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            lblSelectAlgorithm = new System.Windows.Forms.Label();
            lblNumberCluster = new System.Windows.Forms.Label();
            txtNumberCluster = new System.Windows.Forms.TextBox();
            lblNumIterations = new System.Windows.Forms.Label();
            txtNumIterations = new System.Windows.Forms.TextBox();
            lblIterations = new System.Windows.Forms.Label();
            txtIterations = new System.Windows.Forms.TextBox();
            lblThresholdValue = new System.Windows.Forms.Label();
            trackBarThreshold = new System.Windows.Forms.TrackBar();
            lblThresholdDisplay = new System.Windows.Forms.Label();
            btnApplyProcessing = new System.Windows.Forms.Button();
            btnCancelProcessing = new System.Windows.Forms.Button();
            panelAnalysisResults = new System.Windows.Forms.Panel();
            lblAnalysisResults = new System.Windows.Forms.Label();
            panelAnalysisResults2 = new System.Windows.Forms.Panel();
            lblAnalysisResults2 = new System.Windows.Forms.Label();
            panelStats = new System.Windows.Forms.Panel();
            lblPanelStats = new System.Windows.Forms.Label();
            listViewStats = new System.Windows.Forms.ListView();
            panelHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            panelStatus = new System.Windows.Forms.Panel();
            lblStatus = new System.Windows.Forms.Label();
            lblProcessingTime = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            lblProgressPercent = new System.Windows.Forms.Label();
            lblTotalPixels = new System.Windows.Forms.Label();
            timerProgress = new System.Windows.Forms.Timer(components);
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panelKpiStrip.SuspendLayout();
            panelKpiAlgorithm.SuspendLayout();
            panelKpiPixels.SuspendLayout();
            panelKpiPerformance.SuspendLayout();
            panelOriginalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProcessedImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelProcessingControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarThreshold).BeginInit();
            panelAnalysisResults.SuspendLayout();
            panelAnalysisResults2.SuspendLayout();
            panelStats.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(btnLoadImage);
            panelSidebar.Controls.Add(btnProcessImage);
            panelSidebar.Controls.Add(btnStatistics);
            panelSidebar.Controls.Add(lblStatistics);
            panelSidebar.Controls.Add(lblTheme);
            panelSidebar.Controls.Add(comboTheme);
            panelSidebar.Controls.Add(lblLanguage);
            panelSidebar.Controls.Add(btnArabic);
            panelSidebar.Controls.Add(btnEnglish);
            panelSidebar.Controls.Add(btnTurkish);
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnExport);
            panelSidebar.Controls.Add(lblQuickActions);
            panelSidebar.Controls.Add(btnQuickTour);
            panelSidebar.Controls.Add(btnShortcutTips);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(200, 1055);
            panelSidebar.TabIndex = 3;
            // 
            // lblLogo
            // 
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            lblLogo.Location = new System.Drawing.Point(15, 25);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(170, 50);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "CV Vision Pro";
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoadImage.FlatAppearance.BorderSize = 0;
            btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnLoadImage.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnLoadImage.Location = new System.Drawing.Point(15, 100);
            btnLoadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnLoadImage.Size = new System.Drawing.Size(170, 50);
            btnLoadImage.TabIndex = 0;
            btnLoadImage.Text = "📁  Load Image";
            btnLoadImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLoadImage.UseVisualStyleBackColor = false;
            // 
            // btnProcessImage
            // 
            btnProcessImage.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnProcessImage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnProcessImage.FlatAppearance.BorderSize = 0;
            btnProcessImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProcessImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnProcessImage.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnProcessImage.Location = new System.Drawing.Point(15, 162);
            btnProcessImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnProcessImage.Name = "btnProcessImage";
            btnProcessImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnProcessImage.Size = new System.Drawing.Size(170, 50);
            btnProcessImage.TabIndex = 1;
            btnProcessImage.Text = "⚙  Process Image";
            btnProcessImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProcessImage.UseVisualStyleBackColor = false;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnStatistics.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnStatistics.Location = new System.Drawing.Point(15, 225);
            btnStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnStatistics.Size = new System.Drawing.Size(170, 50);
            btnStatistics.TabIndex = 2;
            btnStatistics.Text = "📊  Statistics";
            btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStatistics.UseVisualStyleBackColor = false;
            // 
            // lblStatistics
            // 
            lblStatistics.AutoSize = true;
            lblStatistics.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblStatistics.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblStatistics.Location = new System.Drawing.Point(25, 288);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new System.Drawing.Size(67, 20);
            lblStatistics.TabIndex = 3;
            lblStatistics.Text = "Statistics";
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTheme.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblTheme.Location = new System.Drawing.Point(15, 325);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new System.Drawing.Size(83, 20);
            lblTheme.TabIndex = 4;
            lblTheme.Text = "🎨  Theme";
            // 
            // comboTheme
            // 
            comboTheme.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            comboTheme.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            comboTheme.Location = new System.Drawing.Point(15, 356);
            comboTheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboTheme.Name = "comboTheme";
            comboTheme.Size = new System.Drawing.Size(170, 28);
            comboTheme.TabIndex = 5;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblLanguage.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblLanguage.Location = new System.Drawing.Point(15, 400);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new System.Drawing.Size(158, 20);
            lblLanguage.TabIndex = 4;
            lblLanguage.Text = "🌐  Language / اللغات";
            // 
            // btnArabic
            // 
            btnArabic.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            btnArabic.Cursor = System.Windows.Forms.Cursors.Hand;
            btnArabic.FlatAppearance.BorderSize = 0;
            btnArabic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnArabic.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnArabic.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnArabic.Location = new System.Drawing.Point(15, 438);
            btnArabic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnArabic.Name = "btnArabic";
            btnArabic.Size = new System.Drawing.Size(80, 35);
            btnArabic.TabIndex = 5;
            btnArabic.Text = "العربية";
            btnArabic.UseVisualStyleBackColor = false;
            // 
            // btnEnglish
            // 
            btnEnglish.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            btnEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEnglish.FlatAppearance.BorderSize = 0;
            btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEnglish.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnEnglish.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnEnglish.Location = new System.Drawing.Point(105, 438);
            btnEnglish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new System.Drawing.Size(80, 35);
            btnEnglish.TabIndex = 6;
            btnEnglish.Text = "English";
            btnEnglish.UseVisualStyleBackColor = false;
            // 
            // btnTurkish
            // 
            btnTurkish.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            btnTurkish.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTurkish.FlatAppearance.BorderSize = 0;
            btnTurkish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTurkish.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnTurkish.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnTurkish.Location = new System.Drawing.Point(15, 481);
            btnTurkish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTurkish.Name = "btnTurkish";
            btnTurkish.Size = new System.Drawing.Size(80, 35);
            btnTurkish.TabIndex = 7;
            btnTurkish.Text = "Türkçe";
            btnTurkish.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSettings.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnSettings.Location = new System.Drawing.Point(15, 538);
            btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnSettings.Size = new System.Drawing.Size(170, 50);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "⚙  Settings";
            btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnExport.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnExport.Location = new System.Drawing.Point(15, 600);
            btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnExport.Size = new System.Drawing.Size(170, 50);
            btnExport.TabIndex = 10;
            btnExport.Text = "↓  Export Results";
            btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblQuickActions.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblQuickActions.Location = new System.Drawing.Point(15, 662);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new System.Drawing.Size(121, 20);
            lblQuickActions.TabIndex = 11;
            lblQuickActions.Text = "✨ Guided Tools";
            // 
            // btnQuickTour
            // 
            btnQuickTour.BackColor = System.Drawing.Color.FromArgb(67, 56, 202);
            btnQuickTour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuickTour.FlatAppearance.BorderSize = 0;
            btnQuickTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuickTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnQuickTour.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnQuickTour.Location = new System.Drawing.Point(15, 694);
            btnQuickTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnQuickTour.Name = "btnQuickTour";
            btnQuickTour.Size = new System.Drawing.Size(170, 40);
            btnQuickTour.TabIndex = 12;
            btnQuickTour.Text = "Quick Tour";
            btnQuickTour.UseVisualStyleBackColor = false;
            // 
            // btnShortcutTips
            // 
            btnShortcutTips.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnShortcutTips.Cursor = System.Windows.Forms.Cursors.Hand;
            btnShortcutTips.FlatAppearance.BorderSize = 0;
            btnShortcutTips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShortcutTips.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnShortcutTips.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnShortcutTips.Location = new System.Drawing.Point(15, 744);
            btnShortcutTips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnShortcutTips.Name = "btnShortcutTips";
            btnShortcutTips.Size = new System.Drawing.Size(170, 40);
            btnShortcutTips.TabIndex = 13;
            btnShortcutTips.Text = "UI Tips";
            btnShortcutTips.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
            panelMain.Controls.Add(panelKpiStrip);
            panelMain.Controls.Add(panelOriginalImage);
            panelMain.Controls.Add(panelProcessedImage);
            panelMain.Controls.Add(panelProcessingControls);
            panelMain.Controls.Add(panelAnalysisResults);
            panelMain.Controls.Add(panelAnalysisResults2);
            panelMain.Controls.Add(panelStats);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(200, 75);
            panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1182, 905);
            panelMain.TabIndex = 0;
            // 
            // panelKpiStrip
            // 
            panelKpiStrip.BackColor = System.Drawing.Color.FromArgb(38, 50, 66);
            panelKpiStrip.Controls.Add(panelKpiAlgorithm);
            panelKpiStrip.Controls.Add(panelKpiPixels);
            panelKpiStrip.Controls.Add(panelKpiPerformance);
            panelKpiStrip.Location = new System.Drawing.Point(20, 12);
            panelKpiStrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelKpiStrip.Name = "panelKpiStrip";
            panelKpiStrip.Size = new System.Drawing.Size(970, 88);
            panelKpiStrip.TabIndex = 6;
            // 
            // panelKpiAlgorithm
            // 
            panelKpiAlgorithm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            panelKpiAlgorithm.Controls.Add(lblKpiAlgorithmValue);
            panelKpiAlgorithm.Controls.Add(lblKpiAlgorithmTitle);
            panelKpiAlgorithm.Location = new System.Drawing.Point(650, 6);
            panelKpiAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelKpiAlgorithm.Name = "panelKpiAlgorithm";
            panelKpiAlgorithm.Size = new System.Drawing.Size(300, 75);
            panelKpiAlgorithm.TabIndex = 2;
            // 
            // lblKpiAlgorithmValue
            // 
            lblKpiAlgorithmValue.AutoSize = true;
            lblKpiAlgorithmValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblKpiAlgorithmValue.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblKpiAlgorithmValue.Location = new System.Drawing.Point(12, 38);
            lblKpiAlgorithmValue.Name = "lblKpiAlgorithmValue";
            lblKpiAlgorithmValue.Size = new System.Drawing.Size(28, 28);
            lblKpiAlgorithmValue.TabIndex = 1;
            lblKpiAlgorithmValue.Text = "--";
            // 
            // lblKpiAlgorithmTitle
            // 
            lblKpiAlgorithmTitle.AutoSize = true;
            lblKpiAlgorithmTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblKpiAlgorithmTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblKpiAlgorithmTitle.Location = new System.Drawing.Point(12, 12);
            lblKpiAlgorithmTitle.Name = "lblKpiAlgorithmTitle";
            lblKpiAlgorithmTitle.Size = new System.Drawing.Size(143, 20);
            lblKpiAlgorithmTitle.TabIndex = 0;
            lblKpiAlgorithmTitle.Text = "Current Model/Filter";
            // 
            // panelKpiPixels
            // 
            panelKpiPixels.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            panelKpiPixels.Controls.Add(lblKpiPixelsValue);
            panelKpiPixels.Controls.Add(lblKpiPixelsTitle);
            panelKpiPixels.Location = new System.Drawing.Point(330, 6);
            panelKpiPixels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelKpiPixels.Name = "panelKpiPixels";
            panelKpiPixels.Size = new System.Drawing.Size(300, 75);
            panelKpiPixels.TabIndex = 1;
            // 
            // lblKpiPixelsValue
            // 
            lblKpiPixelsValue.AutoSize = true;
            lblKpiPixelsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblKpiPixelsValue.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblKpiPixelsValue.Location = new System.Drawing.Point(12, 38);
            lblKpiPixelsValue.Name = "lblKpiPixelsValue";
            lblKpiPixelsValue.Size = new System.Drawing.Size(28, 28);
            lblKpiPixelsValue.TabIndex = 1;
            lblKpiPixelsValue.Text = "--";
            // 
            // lblKpiPixelsTitle
            // 
            lblKpiPixelsTitle.AutoSize = true;
            lblKpiPixelsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblKpiPixelsTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblKpiPixelsTitle.Location = new System.Drawing.Point(12, 12);
            lblKpiPixelsTitle.Name = "lblKpiPixelsTitle";
            lblKpiPixelsTitle.Size = new System.Drawing.Size(83, 20);
            lblKpiPixelsTitle.TabIndex = 0;
            lblKpiPixelsTitle.Text = "Total Pixels";
            // 
            // panelKpiPerformance
            // 
            panelKpiPerformance.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            panelKpiPerformance.Controls.Add(lblKpiProcessingValue);
            panelKpiPerformance.Controls.Add(lblKpiProcessingTitle);
            panelKpiPerformance.Location = new System.Drawing.Point(10, 6);
            panelKpiPerformance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelKpiPerformance.Name = "panelKpiPerformance";
            panelKpiPerformance.Size = new System.Drawing.Size(300, 75);
            panelKpiPerformance.TabIndex = 0;
            // 
            // lblKpiProcessingValue
            // 
            lblKpiProcessingValue.AutoSize = true;
            lblKpiProcessingValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblKpiProcessingValue.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblKpiProcessingValue.Location = new System.Drawing.Point(12, 38);
            lblKpiProcessingValue.Name = "lblKpiProcessingValue";
            lblKpiProcessingValue.Size = new System.Drawing.Size(28, 28);
            lblKpiProcessingValue.TabIndex = 1;
            lblKpiProcessingValue.Text = "--";
            // 
            // lblKpiProcessingTitle
            // 
            lblKpiProcessingTitle.AutoSize = true;
            lblKpiProcessingTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblKpiProcessingTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblKpiProcessingTitle.Location = new System.Drawing.Point(12, 12);
            lblKpiProcessingTitle.Name = "lblKpiProcessingTitle";
            lblKpiProcessingTitle.Size = new System.Drawing.Size(149, 20);
            lblKpiProcessingTitle.TabIndex = 0;
            lblKpiProcessingTitle.Text = "Processing Time (ms)";
            // 
            // panelOriginalImage
            // 
            panelOriginalImage.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelOriginalImage.Controls.Add(lblOriginalImage);
            panelOriginalImage.Controls.Add(pictureBox1);
            panelOriginalImage.Controls.Add(lblOriginalPlaceholder);
            panelOriginalImage.Location = new System.Drawing.Point(20, 125);
            panelOriginalImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelOriginalImage.Name = "panelOriginalImage";
            panelOriginalImage.Size = new System.Drawing.Size(380, 325);
            panelOriginalImage.TabIndex = 0;
            // 
            // lblOriginalImage
            // 
            lblOriginalImage.AutoSize = true;
            lblOriginalImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblOriginalImage.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblOriginalImage.Location = new System.Drawing.Point(10, 12);
            lblOriginalImage.Name = "lblOriginalImage";
            lblOriginalImage.Size = new System.Drawing.Size(149, 23);
            lblOriginalImage.TabIndex = 0;
            lblOriginalImage.Text = "ORIGINAL IMAGE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pictureBox1.Location = new System.Drawing.Point(10, 44);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(360, 250);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblOriginalPlaceholder
            // 
            lblOriginalPlaceholder.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblOriginalPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblOriginalPlaceholder.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblOriginalPlaceholder.Location = new System.Drawing.Point(10, 44);
            lblOriginalPlaceholder.Name = "lblOriginalPlaceholder";
            lblOriginalPlaceholder.Size = new System.Drawing.Size(360, 250);
            lblOriginalPlaceholder.TabIndex = 2;
            lblOriginalPlaceholder.Text = "Load an image to preview";
            lblOriginalPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProcessedImage
            // 
            panelProcessedImage.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelProcessedImage.Controls.Add(lblProcessedImage);
            panelProcessedImage.Controls.Add(pictureBox2);
            panelProcessedImage.Controls.Add(lblProcessedPlaceholder);
            panelProcessedImage.Location = new System.Drawing.Point(420, 125);
            panelProcessedImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelProcessedImage.Name = "panelProcessedImage";
            panelProcessedImage.Size = new System.Drawing.Size(380, 325);
            panelProcessedImage.TabIndex = 1;
            // 
            // lblProcessedImage
            // 
            lblProcessedImage.AutoSize = true;
            lblProcessedImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblProcessedImage.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblProcessedImage.Location = new System.Drawing.Point(10, 12);
            lblProcessedImage.Name = "lblProcessedImage";
            lblProcessedImage.Size = new System.Drawing.Size(165, 23);
            lblProcessedImage.TabIndex = 0;
            lblProcessedImage.Text = "PROCESSED IMAGE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pictureBox2.Location = new System.Drawing.Point(10, 44);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(360, 250);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblProcessedPlaceholder
            // 
            lblProcessedPlaceholder.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblProcessedPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblProcessedPlaceholder.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblProcessedPlaceholder.Location = new System.Drawing.Point(10, 44);
            lblProcessedPlaceholder.Name = "lblProcessedPlaceholder";
            lblProcessedPlaceholder.Size = new System.Drawing.Size(360, 250);
            lblProcessedPlaceholder.TabIndex = 2;
            lblProcessedPlaceholder.Text = "Processed preview will appear here";
            lblProcessedPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProcessingControls
            // 
            panelProcessingControls.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelProcessingControls.Controls.Add(lblProcessingControls);
            panelProcessingControls.Controls.Add(comboBoxAlgorithm);
            panelProcessingControls.Controls.Add(lblSelectAlgorithm);
            panelProcessingControls.Controls.Add(lblNumberCluster);
            panelProcessingControls.Controls.Add(txtNumberCluster);
            panelProcessingControls.Controls.Add(lblNumIterations);
            panelProcessingControls.Controls.Add(txtNumIterations);
            panelProcessingControls.Controls.Add(lblIterations);
            panelProcessingControls.Controls.Add(txtIterations);
            panelProcessingControls.Controls.Add(lblThresholdValue);
            panelProcessingControls.Controls.Add(trackBarThreshold);
            panelProcessingControls.Controls.Add(lblThresholdDisplay);
            panelProcessingControls.Controls.Add(btnApplyProcessing);
            panelProcessingControls.Controls.Add(btnCancelProcessing);
            panelProcessingControls.Location = new System.Drawing.Point(20, 475);
            panelProcessingControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelProcessingControls.Name = "panelProcessingControls";
            panelProcessingControls.Size = new System.Drawing.Size(380, 413);
            panelProcessingControls.TabIndex = 2;
            // 
            // lblProcessingControls
            // 
            lblProcessingControls.AutoSize = true;
            lblProcessingControls.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblProcessingControls.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblProcessingControls.Location = new System.Drawing.Point(100, 104);
            lblProcessingControls.Name = "lblProcessingControls";
            lblProcessingControls.Size = new System.Drawing.Size(198, 28);
            lblProcessingControls.TabIndex = 0;
            lblProcessingControls.Text = "Processing Controls";
            // 
            // comboBoxAlgorithm
            // 
            comboBoxAlgorithm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxAlgorithm.Font = new System.Drawing.Font("Segoe UI", 10F);
            comboBoxAlgorithm.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            comboBoxAlgorithm.Location = new System.Drawing.Point(15, 62);
            comboBoxAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            comboBoxAlgorithm.Size = new System.Drawing.Size(350, 31);
            comboBoxAlgorithm.TabIndex = 1;
            // 
            // lblSelectAlgorithm
            // 
            lblSelectAlgorithm.AutoSize = true;
            lblSelectAlgorithm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSelectAlgorithm.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblSelectAlgorithm.Location = new System.Drawing.Point(127, 18);
            lblSelectAlgorithm.Name = "lblSelectAlgorithm";
            lblSelectAlgorithm.Size = new System.Drawing.Size(146, 23);
            lblSelectAlgorithm.TabIndex = 2;
            lblSelectAlgorithm.Text = "Select Algorithm";
            // 
            // lblNumberCluster
            // 
            lblNumberCluster.AutoSize = true;
            lblNumberCluster.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblNumberCluster.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblNumberCluster.Location = new System.Drawing.Point(15, 156);
            lblNumberCluster.Name = "lblNumberCluster";
            lblNumberCluster.Size = new System.Drawing.Size(112, 20);
            lblNumberCluster.TabIndex = 3;
            lblNumberCluster.Text = "Number Cluster";
            // 
            // txtNumberCluster
            // 
            txtNumberCluster.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            txtNumberCluster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNumberCluster.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNumberCluster.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            txtNumberCluster.Location = new System.Drawing.Point(200, 150);
            txtNumberCluster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNumberCluster.Name = "txtNumberCluster";
            txtNumberCluster.Size = new System.Drawing.Size(100, 30);
            txtNumberCluster.TabIndex = 4;
            txtNumberCluster.Text = "5";
            txtNumberCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumIterations
            // 
            lblNumIterations.AutoSize = true;
            lblNumIterations.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblNumIterations.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblNumIterations.Location = new System.Drawing.Point(15, 206);
            lblNumIterations.Name = "lblNumIterations";
            lblNumIterations.Size = new System.Drawing.Size(103, 20);
            lblNumIterations.TabIndex = 5;
            lblNumIterations.Text = "Max Iterations";
            // 
            // txtNumIterations
            // 
            txtNumIterations.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            txtNumIterations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNumIterations.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNumIterations.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            txtNumIterations.Location = new System.Drawing.Point(200, 200);
            txtNumIterations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNumIterations.Name = "txtNumIterations";
            txtNumIterations.Size = new System.Drawing.Size(100, 30);
            txtNumIterations.TabIndex = 6;
            txtNumIterations.Text = "100";
            txtNumIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIterations
            // 
            lblIterations.AutoSize = true;
            lblIterations.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblIterations.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblIterations.Location = new System.Drawing.Point(15, 256);
            lblIterations.Name = "lblIterations";
            lblIterations.Size = new System.Drawing.Size(71, 20);
            lblIterations.TabIndex = 7;
            lblIterations.Text = "Iterations";
            // 
            // txtIterations
            // 
            txtIterations.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            txtIterations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtIterations.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtIterations.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            txtIterations.Location = new System.Drawing.Point(200, 250);
            txtIterations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtIterations.Name = "txtIterations";
            txtIterations.Size = new System.Drawing.Size(100, 30);
            txtIterations.TabIndex = 8;
            txtIterations.Text = "100";
            txtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThresholdValue
            // 
            lblThresholdValue.AutoSize = true;
            lblThresholdValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblThresholdValue.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblThresholdValue.Location = new System.Drawing.Point(10, 186);
            lblThresholdValue.Name = "lblThresholdValue";
            lblThresholdValue.Size = new System.Drawing.Size(166, 20);
            lblThresholdValue.TabIndex = 9;
            lblThresholdValue.Text = "Threshold Value (0-255)";
            lblThresholdValue.Click += lblThresholdValue_Click;
            // 
            // trackBarThreshold
            // 
            trackBarThreshold.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            trackBarThreshold.Location = new System.Drawing.Point(3, 213);
            trackBarThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            trackBarThreshold.Maximum = 255;
            trackBarThreshold.Name = "trackBarThreshold";
            trackBarThreshold.Size = new System.Drawing.Size(280, 56);
            trackBarThreshold.TabIndex = 0;
            trackBarThreshold.TickFrequency = 25;
            trackBarThreshold.Value = 128;
            // 
            // lblThresholdDisplay
            // 
            lblThresholdDisplay.AutoSize = true;
            lblThresholdDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblThresholdDisplay.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblThresholdDisplay.Location = new System.Drawing.Point(317, 225);
            lblThresholdDisplay.Name = "lblThresholdDisplay";
            lblThresholdDisplay.Size = new System.Drawing.Size(48, 28);
            lblThresholdDisplay.TabIndex = 10;
            lblThresholdDisplay.Text = "128";
            // 
            // btnApplyProcessing
            // 
            btnApplyProcessing.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            btnApplyProcessing.Cursor = System.Windows.Forms.Cursors.Hand;
            btnApplyProcessing.FlatAppearance.BorderSize = 0;
            btnApplyProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApplyProcessing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnApplyProcessing.ForeColor = System.Drawing.Color.White;
            btnApplyProcessing.Location = new System.Drawing.Point(80, 308);
            btnApplyProcessing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnApplyProcessing.Name = "btnApplyProcessing";
            btnApplyProcessing.Size = new System.Drawing.Size(200, 56);
            btnApplyProcessing.TabIndex = 11;
            btnApplyProcessing.Text = "APPLY PROCESSING";
            btnApplyProcessing.UseVisualStyleBackColor = false;
            // 
            // btnCancelProcessing
            // 
            btnCancelProcessing.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnCancelProcessing.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelProcessing.FlatAppearance.BorderSize = 0;
            btnCancelProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelProcessing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCancelProcessing.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnCancelProcessing.Location = new System.Drawing.Point(80, 369);
            btnCancelProcessing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelProcessing.Name = "btnCancelProcessing";
            btnCancelProcessing.Size = new System.Drawing.Size(200, 40);
            btnCancelProcessing.TabIndex = 12;
            btnCancelProcessing.Text = "CANCEL";
            btnCancelProcessing.UseVisualStyleBackColor = false;
            // 
            // panelAnalysisResults
            // 
            panelAnalysisResults.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelAnalysisResults.Controls.Add(lblAnalysisResults);
            panelAnalysisResults.Location = new System.Drawing.Point(420, 475);
            panelAnalysisResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelAnalysisResults.Name = "panelAnalysisResults";
            panelAnalysisResults.Size = new System.Drawing.Size(380, 200);
            panelAnalysisResults.TabIndex = 3;
            // 
            // lblAnalysisResults
            // 
            lblAnalysisResults.AutoSize = true;
            lblAnalysisResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAnalysisResults.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblAnalysisResults.Location = new System.Drawing.Point(10, 12);
            lblAnalysisResults.Name = "lblAnalysisResults";
            lblAnalysisResults.Size = new System.Drawing.Size(135, 23);
            lblAnalysisResults.TabIndex = 0;
            lblAnalysisResults.Text = "Analysis Results";
            // 
            // panelAnalysisResults2
            // 
            panelAnalysisResults2.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelAnalysisResults2.Controls.Add(lblAnalysisResults2);
            panelAnalysisResults2.Location = new System.Drawing.Point(420, 688);
            panelAnalysisResults2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelAnalysisResults2.Name = "panelAnalysisResults2";
            panelAnalysisResults2.Size = new System.Drawing.Size(380, 200);
            panelAnalysisResults2.TabIndex = 4;
            // 
            // lblAnalysisResults2
            // 
            lblAnalysisResults2.AutoSize = true;
            lblAnalysisResults2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAnalysisResults2.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblAnalysisResults2.Location = new System.Drawing.Point(10, 12);
            lblAnalysisResults2.Name = "lblAnalysisResults2";
            lblAnalysisResults2.Size = new System.Drawing.Size(135, 23);
            lblAnalysisResults2.TabIndex = 0;
            lblAnalysisResults2.Text = "Analysis Results";
            // 
            // panelStats
            // 
            panelStats.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelStats.Controls.Add(lblPanelStats);
            panelStats.Controls.Add(listViewStats);
            panelStats.Location = new System.Drawing.Point(820, 125);
            panelStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelStats.Name = "panelStats";
            panelStats.Size = new System.Drawing.Size(170, 325);
            panelStats.TabIndex = 5;
            // 
            // lblPanelStats
            // 
            lblPanelStats.AutoSize = true;
            lblPanelStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPanelStats.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblPanelStats.Location = new System.Drawing.Point(10, 12);
            lblPanelStats.Name = "lblPanelStats";
            lblPanelStats.Size = new System.Drawing.Size(78, 20);
            lblPanelStats.TabIndex = 0;
            lblPanelStats.Text = "panelStats";
            // 
            // listViewStats
            // 
            listViewStats.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            listViewStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            listViewStats.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            listViewStats.FullRowSelect = true;
            listViewStats.GridLines = true;
            listViewStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewStats.Location = new System.Drawing.Point(10, 44);
            listViewStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStats.Name = "listViewStats";
            listViewStats.Size = new System.Drawing.Size(150, 262);
            listViewStats.TabIndex = 0;
            listViewStats.UseCompatibleStateImageBehavior = false;
            listViewStats.View = System.Windows.Forms.View.Details;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(200, 0);
            panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1182, 75);
            panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            lblTitle.Location = new System.Drawing.Point(350, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(686, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Computer Vision - Advanced Image Processing";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            panelStatus.Controls.Add(lblStatus);
            panelStatus.Controls.Add(lblProcessingTime);
            panelStatus.Controls.Add(progressBar);
            panelStatus.Controls.Add(lblProgressPercent);
            panelStatus.Controls.Add(lblTotalPixels);
            panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelStatus.Location = new System.Drawing.Point(200, 980);
            panelStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new System.Drawing.Size(1182, 75);
            panelStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblStatus.Location = new System.Drawing.Point(20, 12);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(97, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status: Ready";
            // 
            // lblProcessingTime
            // 
            lblProcessingTime.AutoSize = true;
            lblProcessingTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblProcessingTime.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblProcessingTime.Location = new System.Drawing.Point(700, 12);
            lblProcessingTime.Name = "lblProcessingTime";
            lblProcessingTime.Size = new System.Drawing.Size(150, 20);
            lblProcessingTime.TabIndex = 1;
            lblProcessingTime.Text = "Processing Time: 0ms";
            // 
            // progressBar
            // 
            progressBar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            progressBar.Location = new System.Drawing.Point(100, 44);
            progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(300, 19);
            progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // lblProgressPercent
            // 
            lblProgressPercent.AutoSize = true;
            lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblProgressPercent.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblProgressPercent.Location = new System.Drawing.Point(20, 44);
            lblProgressPercent.Name = "lblProgressPercent";
            lblProgressPercent.Size = new System.Drawing.Size(52, 20);
            lblProgressPercent.TabIndex = 2;
            lblProgressPercent.Text = "Status:";
            // 
            // lblTotalPixels
            // 
            lblTotalPixels.AutoSize = true;
            lblTotalPixels.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTotalPixels.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblTotalPixels.Location = new System.Drawing.Point(420, 44);
            lblTotalPixels.Name = "lblTotalPixels";
            lblTotalPixels.Size = new System.Drawing.Size(98, 20);
            lblTotalPixels.TabIndex = 3;
            lblTotalPixels.Text = "Total Pixels: 0";
            // 
            // timerProgress
            // 
            timerProgress.Interval = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
            ClientSize = new System.Drawing.Size(1382, 1055);
            Controls.Add(panelMain);
            Controls.Add(panelStatus);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1100, 800);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CV Vision Pro";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelKpiStrip.ResumeLayout(false);
            panelKpiAlgorithm.ResumeLayout(false);
            panelKpiAlgorithm.PerformLayout();
            panelKpiPixels.ResumeLayout(false);
            panelKpiPixels.PerformLayout();
            panelKpiPerformance.ResumeLayout(false);
            panelKpiPerformance.PerformLayout();
            panelOriginalImage.ResumeLayout(false);
            panelOriginalImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProcessedImage.ResumeLayout(false);
            panelProcessedImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelProcessingControls.ResumeLayout(false);
            panelProcessingControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarThreshold).EndInit();
            panelAnalysisResults.ResumeLayout(false);
            panelAnalysisResults.PerformLayout();
            panelAnalysisResults2.ResumeLayout(false);
            panelAnalysisResults2.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        // Paneller
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelKpiStrip;
        private System.Windows.Forms.Panel panelKpiAlgorithm;
        private System.Windows.Forms.Panel panelKpiPixels;
        private System.Windows.Forms.Panel panelKpiPerformance;
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
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox comboTheme;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnArabic;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnTurkish;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Button btnQuickTour;
        private System.Windows.Forms.Button btnShortcutTips;
        
        // Header
        private System.Windows.Forms.Label lblTitle;
        
        // Resim panelleri
        private System.Windows.Forms.Label lblOriginalImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProcessedImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOriginalPlaceholder;
        private System.Windows.Forms.Label lblProcessedPlaceholder;
        
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
        private System.Windows.Forms.Button btnCancelProcessing;
        
        // Analysis Results
        private System.Windows.Forms.Label lblAnalysisResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblAnalysisResults2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblKpiAlgorithmValue;
        private System.Windows.Forms.Label lblKpiAlgorithmTitle;
        private System.Windows.Forms.Label lblKpiPixelsValue;
        private System.Windows.Forms.Label lblKpiPixelsTitle;
        private System.Windows.Forms.Label lblKpiProcessingValue;
        private System.Windows.Forms.Label lblKpiProcessingTitle;
        
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
