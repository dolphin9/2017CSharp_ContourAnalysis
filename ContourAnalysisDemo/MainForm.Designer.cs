namespace ContourAnalysisDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ibMain = new Emgu.CV.UI.ImageBox();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.cbShowBinarized = new System.Windows.Forms.CheckBox();
            this.cbShowContours = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudMaxACFdesc = new System.Windows.Forms.NumericUpDown();
            this.nudMinACF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAllowAngleMore45 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMinICF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMinDefinition = new System.Windows.Forms.NumericUpDown();
            this.cbNoiseFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinContourLength = new System.Windows.Forms.NumericUpDown();
            this.nudMinContourArea = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAdaptiveNoiseFilter = new System.Windows.Forms.CheckBox();
            this.nudAdaptiveThBlockSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBlur = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCaptureFromCam = new System.Windows.Forms.CheckBox();
            this.cbCamResolution = new System.Windows.Forms.ComboBox();
            this.btLoadImage = new System.Windows.Forms.Button();
            this.cbAutoContrast = new System.Windows.Forms.CheckBox();
            this.cbShowAngle = new System.Windows.Forms.CheckBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lbFPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbContoursCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbRecognized = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tmUpdateState = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNewTemplates = new System.Windows.Forms.ToolStripButton();
            this.btOpenTemplates = new System.Windows.Forms.ToolStripButton();
            this.btSaveTemplates = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btCreateTemplate = new System.Windows.Forms.ToolStripButton();
            this.btAutoGenerate = new System.Windows.Forms.ToolStripButton();
            this.btTemplateEditor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).BeginInit();
            this.pnSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxACFdesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinACF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinICF)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDefinition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveThBlockSize)).BeginInit();
            this.ssMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibMain
            // 
            this.ibMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibMain.Location = new System.Drawing.Point(0, 25);
            this.ibMain.Name = "ibMain";
            this.ibMain.Size = new System.Drawing.Size(522, 417);
            this.ibMain.TabIndex = 2;
            this.ibMain.TabStop = false;
            this.ibMain.Paint += new System.Windows.Forms.PaintEventHandler(this.ibMain_Paint);
            // 
            // pnSettings
            // 
            this.pnSettings.AutoScroll = true;
            this.pnSettings.Controls.Add(this.cbShowBinarized);
            this.pnSettings.Controls.Add(this.cbShowContours);
            this.pnSettings.Controls.Add(this.groupBox3);
            this.pnSettings.Controls.Add(this.groupBox2);
            this.pnSettings.Controls.Add(this.groupBox1);
            this.pnSettings.Controls.Add(this.cbShowAngle);
            this.pnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSettings.Location = new System.Drawing.Point(527, 25);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(209, 417);
            this.pnSettings.TabIndex = 3;
            // 
            // cbShowBinarized
            // 
            this.cbShowBinarized.AutoSize = true;
            this.cbShowBinarized.Location = new System.Drawing.Point(6, 164);
            this.cbShowBinarized.Name = "cbShowBinarized";
            this.cbShowBinarized.Size = new System.Drawing.Size(102, 16);
            this.cbShowBinarized.TabIndex = 21;
            this.cbShowBinarized.Text = "显示角度+轮廓";
            this.cbShowBinarized.UseVisualStyleBackColor = true;
            // 
            // cbShowContours
            // 
            this.cbShowContours.AutoSize = true;
            this.cbShowContours.Location = new System.Drawing.Point(95, 143);
            this.cbShowContours.Name = "cbShowContours";
            this.cbShowContours.Size = new System.Drawing.Size(72, 16);
            this.cbShowContours.TabIndex = 20;
            this.cbShowContours.Text = "显示轮廓";
            this.cbShowContours.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudMaxACFdesc);
            this.groupBox3.Controls.Add(this.nudMinACF);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbAllowAngleMore45);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nudMinICF);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 118);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "识别参数";
            // 
            // nudMaxACFdesc
            // 
            this.nudMaxACFdesc.Location = new System.Drawing.Point(6, 33);
            this.nudMaxACFdesc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxACFdesc.Name = "nudMaxACFdesc";
            this.nudMaxACFdesc.Size = new System.Drawing.Size(78, 21);
            this.nudMaxACFdesc.TabIndex = 15;
            this.nudMaxACFdesc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxACFdesc.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinACF
            // 
            this.nudMinACF.DecimalPlaces = 2;
            this.nudMinACF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinACF.Location = new System.Drawing.Point(6, 69);
            this.nudMinACF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinACF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinACF.Name = "nudMinACF";
            this.nudMinACF.Size = new System.Drawing.Size(78, 21);
            this.nudMinACF.TabIndex = 11;
            this.nudMinACF.Value = new decimal(new int[] {
            96,
            0,
            0,
            131072});
            this.nudMinACF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "最小ACF";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbAllowAngleMore45
            // 
            this.cbAllowAngleMore45.AutoSize = true;
            this.cbAllowAngleMore45.Location = new System.Drawing.Point(7, 97);
            this.cbAllowAngleMore45.Name = "cbAllowAngleMore45";
            this.cbAllowAngleMore45.Size = new System.Drawing.Size(102, 16);
            this.cbAllowAngleMore45.TabIndex = 6;
            this.cbAllowAngleMore45.Text = "允许角度 > 45";
            this.cbAllowAngleMore45.UseVisualStyleBackColor = true;
            this.cbAllowAngleMore45.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "最大 ACF 描述误差";
            // 
            // nudMinICF
            // 
            this.nudMinICF.DecimalPlaces = 2;
            this.nudMinICF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinICF.Location = new System.Drawing.Point(101, 69);
            this.nudMinICF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinICF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinICF.Name = "nudMinICF";
            this.nudMinICF.Size = new System.Drawing.Size(78, 21);
            this.nudMinICF.TabIndex = 13;
            this.nudMinICF.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.nudMinICF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "最小ICF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMinDefinition);
            this.groupBox2.Controls.Add(this.cbNoiseFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudMinContourLength);
            this.groupBox2.Controls.Add(this.nudMinContourArea);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 84);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轮廓过滤";
            // 
            // nudMinDefinition
            // 
            this.nudMinDefinition.Enabled = false;
            this.nudMinDefinition.Location = new System.Drawing.Point(100, 58);
            this.nudMinDefinition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMinDefinition.Name = "nudMinDefinition";
            this.nudMinDefinition.Size = new System.Drawing.Size(78, 21);
            this.nudMinDefinition.TabIndex = 12;
            this.nudMinDefinition.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMinDefinition.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbNoiseFilter
            // 
            this.cbNoiseFilter.AutoSize = true;
            this.cbNoiseFilter.Location = new System.Drawing.Point(6, 59);
            this.cbNoiseFilter.Name = "cbNoiseFilter";
            this.cbNoiseFilter.Size = new System.Drawing.Size(72, 16);
            this.cbNoiseFilter.TabIndex = 11;
            this.cbNoiseFilter.Text = "噪音填充";
            this.cbNoiseFilter.UseVisualStyleBackColor = true;
            this.cbNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "最小轮廓长度";
            // 
            // nudMinContourLength
            // 
            this.nudMinContourLength.Location = new System.Drawing.Point(5, 31);
            this.nudMinContourLength.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourLength.Name = "nudMinContourLength";
            this.nudMinContourLength.Size = new System.Drawing.Size(78, 21);
            this.nudMinContourLength.TabIndex = 7;
            this.nudMinContourLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinContourLength.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinContourArea
            // 
            this.nudMinContourArea.Location = new System.Drawing.Point(100, 31);
            this.nudMinContourArea.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourArea.Name = "nudMinContourArea";
            this.nudMinContourArea.Size = new System.Drawing.Size(78, 21);
            this.nudMinContourArea.TabIndex = 9;
            this.nudMinContourArea.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinContourArea.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "最小轮廓范围";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAdaptiveNoiseFilter);
            this.groupBox1.Controls.Add(this.nudAdaptiveThBlockSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbBlur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCaptureFromCam);
            this.groupBox1.Controls.Add(this.cbCamResolution);
            this.groupBox1.Controls.Add(this.btLoadImage);
            this.groupBox1.Controls.Add(this.cbAutoContrast);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 135);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "源";
            // 
            // cbAdaptiveNoiseFilter
            // 
            this.cbAdaptiveNoiseFilter.AutoSize = true;
            this.cbAdaptiveNoiseFilter.Checked = true;
            this.cbAdaptiveNoiseFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdaptiveNoiseFilter.Location = new System.Drawing.Point(105, 114);
            this.cbAdaptiveNoiseFilter.Name = "cbAdaptiveNoiseFilter";
            this.cbAdaptiveNoiseFilter.Size = new System.Drawing.Size(84, 16);
            this.cbAdaptiveNoiseFilter.TabIndex = 13;
            this.cbAdaptiveNoiseFilter.Text = "噪声过滤器";
            this.cbAdaptiveNoiseFilter.UseVisualStyleBackColor = true;
            this.cbAdaptiveNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudAdaptiveThBlockSize
            // 
            this.nudAdaptiveThBlockSize.Location = new System.Drawing.Point(11, 113);
            this.nudAdaptiveThBlockSize.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.Name = "nudAdaptiveThBlockSize";
            this.nudAdaptiveThBlockSize.Size = new System.Drawing.Size(78, 21);
            this.nudAdaptiveThBlockSize.TabIndex = 11;
            this.nudAdaptiveThBlockSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "自适应阈值块大小";
            // 
            // cbBlur
            // 
            this.cbBlur.AutoSize = true;
            this.cbBlur.Checked = true;
            this.cbBlur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBlur.Location = new System.Drawing.Point(106, 78);
            this.cbBlur.Name = "cbBlur";
            this.cbBlur.Size = new System.Drawing.Size(48, 16);
            this.cbBlur.TabIndex = 6;
            this.cbBlur.Text = "模糊";
            this.cbBlur.UseVisualStyleBackColor = true;
            this.cbBlur.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "相机分辨率";
            // 
            // cbCaptureFromCam
            // 
            this.cbCaptureFromCam.AutoSize = true;
            this.cbCaptureFromCam.Checked = true;
            this.cbCaptureFromCam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCaptureFromCam.Location = new System.Drawing.Point(11, 15);
            this.cbCaptureFromCam.Name = "cbCaptureFromCam";
            this.cbCaptureFromCam.Size = new System.Drawing.Size(84, 16);
            this.cbCaptureFromCam.TabIndex = 2;
            this.cbCaptureFromCam.Text = "从相机获取";
            this.cbCaptureFromCam.UseVisualStyleBackColor = true;
            this.cbCaptureFromCam.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbCamResolution
            // 
            this.cbCamResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamResolution.FormattingEnabled = true;
            this.cbCamResolution.Items.AddRange(new object[] {
            "800x600",
            "640x480",
            "320x240"});
            this.cbCamResolution.Location = new System.Drawing.Point(11, 47);
            this.cbCamResolution.Name = "cbCamResolution";
            this.cbCamResolution.Size = new System.Drawing.Size(89, 20);
            this.cbCamResolution.TabIndex = 3;
            this.cbCamResolution.TextChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // btLoadImage
            // 
            this.btLoadImage.Enabled = false;
            this.btLoadImage.Location = new System.Drawing.Point(105, 35);
            this.btLoadImage.Name = "btLoadImage";
            this.btLoadImage.Size = new System.Drawing.Size(68, 32);
            this.btLoadImage.TabIndex = 5;
            this.btLoadImage.Text = "识别图片";
            this.btLoadImage.UseVisualStyleBackColor = true;
            this.btLoadImage.Click += new System.EventHandler(this.btLoadImage_Click);
            // 
            // cbAutoContrast
            // 
            this.cbAutoContrast.AutoSize = true;
            this.cbAutoContrast.Location = new System.Drawing.Point(11, 78);
            this.cbAutoContrast.Name = "cbAutoContrast";
            this.cbAutoContrast.Size = new System.Drawing.Size(84, 16);
            this.cbAutoContrast.TabIndex = 1;
            this.cbAutoContrast.Text = "自动对比度";
            this.cbAutoContrast.UseVisualStyleBackColor = true;
            this.cbAutoContrast.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbShowAngle
            // 
            this.cbShowAngle.AutoSize = true;
            this.cbShowAngle.Location = new System.Drawing.Point(6, 143);
            this.cbShowAngle.Name = "cbShowAngle";
            this.cbShowAngle.Size = new System.Drawing.Size(72, 16);
            this.cbShowAngle.TabIndex = 0;
            this.cbShowAngle.Text = "显示角度";
            this.cbShowAngle.UseVisualStyleBackColor = true;
            this.cbShowAngle.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbFPS,
            this.lbContoursCount,
            this.lbRecognized});
            this.ssMain.Location = new System.Drawing.Point(0, 442);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(736, 22);
            this.ssMain.TabIndex = 4;
            this.ssMain.Text = "statusStrip1";
            // 
            // lbFPS
            // 
            this.lbFPS.AutoSize = false;
            this.lbFPS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbFPS.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lbFPS.Name = "lbFPS";
            this.lbFPS.Size = new System.Drawing.Size(52, 17);
            this.lbFPS.Text = "0 fps";
            // 
            // lbContoursCount
            // 
            this.lbContoursCount.AutoSize = false;
            this.lbContoursCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbContoursCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lbContoursCount.Name = "lbContoursCount";
            this.lbContoursCount.Size = new System.Drawing.Size(120, 17);
            this.lbContoursCount.Text = "总轮廓: ";
            this.lbContoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecognized
            // 
            this.lbRecognized.AutoSize = false;
            this.lbRecognized.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbRecognized.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lbRecognized.Name = "lbRecognized";
            this.lbRecognized.Size = new System.Drawing.Size(150, 17);
            this.lbRecognized.Text = "已识别轮廓: ";
            this.lbRecognized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(522, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 417);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // tmUpdateState
            // 
            this.tmUpdateState.Enabled = true;
            this.tmUpdateState.Interval = 1000;
            this.tmUpdateState.Tick += new System.EventHandler(this.tmUpdateState_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNewTemplates,
            this.btOpenTemplates,
            this.btSaveTemplates,
            this.toolStripSeparator,
            this.btCreateTemplate,
            this.btAutoGenerate,
            this.btTemplateEditor,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNewTemplates
            // 
            this.btNewTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNewTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btNewTemplates.Image")));
            this.btNewTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNewTemplates.Name = "btNewTemplates";
            this.btNewTemplates.Size = new System.Drawing.Size(23, 22);
            this.btNewTemplates.Text = "新建轮廓库";
            this.btNewTemplates.Click += new System.EventHandler(this.btNewTemplates_Click);
            // 
            // btOpenTemplates
            // 
            this.btOpenTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpenTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btOpenTemplates.Image")));
            this.btOpenTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpenTemplates.Name = "btOpenTemplates";
            this.btOpenTemplates.Size = new System.Drawing.Size(23, 22);
            this.btOpenTemplates.Text = "打开轮廓库";
            this.btOpenTemplates.Click += new System.EventHandler(this.btOpenTemplates_Click);
            // 
            // btSaveTemplates
            // 
            this.btSaveTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSaveTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btSaveTemplates.Image")));
            this.btSaveTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSaveTemplates.Name = "btSaveTemplates";
            this.btSaveTemplates.Size = new System.Drawing.Size(23, 22);
            this.btSaveTemplates.Text = "保存轮廓库";
            this.btSaveTemplates.Click += new System.EventHandler(this.btSaveTemplates_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btCreateTemplate
            // 
            this.btCreateTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCreateTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btCreateTemplate.Image")));
            this.btCreateTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCreateTemplate.Name = "btCreateTemplate";
            this.btCreateTemplate.Size = new System.Drawing.Size(23, 22);
            this.btCreateTemplate.Text = "创建轮廓";
            this.btCreateTemplate.Click += new System.EventHandler(this.btCreateTemplate_Click);
            // 
            // btAutoGenerate
            // 
            this.btAutoGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAutoGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btAutoGenerate.Image")));
            this.btAutoGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAutoGenerate.Name = "btAutoGenerate";
            this.btAutoGenerate.Size = new System.Drawing.Size(23, 22);
            this.btAutoGenerate.Text = "自动生成轮廓";
            this.btAutoGenerate.Click += new System.EventHandler(this.btAutoGenerate_Click);
            // 
            // btTemplateEditor
            // 
            this.btTemplateEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btTemplateEditor.Image = ((System.Drawing.Image)(resources.GetObject("btTemplateEditor.Image")));
            this.btTemplateEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTemplateEditor.Name = "btTemplateEditor";
            this.btTemplateEditor.Size = new System.Drawing.Size(23, 22);
            this.btTemplateEditor.Text = "模板浏览";
            this.btTemplateEditor.ToolTipText = "轮廓浏览";
            this.btTemplateEditor.Click += new System.EventHandler(this.btTemplateEditor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "显示tips";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 464);
            this.Controls.Add(this.ibMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "2017C# 大作业  Contour Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).EndInit();
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxACFdesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinACF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinICF)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDefinition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveThBlockSize)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibMain;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel lbFPS;
        private System.Windows.Forms.ToolStripStatusLabel lbContoursCount;
        private System.Windows.Forms.Timer tmUpdateState;
        private System.Windows.Forms.ToolStripStatusLabel lbRecognized;
        private System.Windows.Forms.CheckBox cbShowAngle;
        private System.Windows.Forms.CheckBox cbAutoContrast;
        private System.Windows.Forms.Button btLoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCamResolution;
        private System.Windows.Forms.CheckBox cbCaptureFromCam;
        private System.Windows.Forms.CheckBox cbAllowAngleMore45;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinContourArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinContourLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinICF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMinACF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMaxACFdesc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBlur;
        private System.Windows.Forms.CheckBox cbNoiseFilter;
        private System.Windows.Forms.NumericUpDown nudMinDefinition;
        private System.Windows.Forms.NumericUpDown nudAdaptiveThBlockSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btCreateTemplate;
        private System.Windows.Forms.ToolStripButton btNewTemplates;
        private System.Windows.Forms.ToolStripButton btOpenTemplates;
        private System.Windows.Forms.ToolStripButton btSaveTemplates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.CheckBox cbShowContours;
        private System.Windows.Forms.ToolStripButton btTemplateEditor;
        private System.Windows.Forms.ToolStripButton btAutoGenerate;
        private System.Windows.Forms.CheckBox cbShowBinarized;
        private System.Windows.Forms.CheckBox cbAdaptiveNoiseFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

