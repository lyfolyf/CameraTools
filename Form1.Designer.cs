namespace CameraTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbDeviceList = new System.Windows.Forms.ComboBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.cmsRtbLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbImageHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImageWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.btnSetParams = new System.Windows.Forms.Button();
            this.btnGetParams = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbExposure = new System.Windows.Forms.TextBox();
            this.gbGrabbing = new System.Windows.Forms.GroupBox();
            this.btnTriggerExec = new System.Windows.Forms.Button();
            this.btnContinuous = new System.Windows.Forms.Button();
            this.rdoExternTrigger = new System.Windows.Forms.RadioButton();
            this.rdoSoftTrigger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbDH = new System.Windows.Forms.CheckBox();
            this.ckbFLIR = new System.Windows.Forms.CheckBox();
            this.btnSelectCti = new System.Windows.Forms.Button();
            this.tbCtiPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbHIK_GenTL = new System.Windows.Forms.CheckBox();
            this.ckbBasler = new System.Windows.Forms.CheckBox();
            this.ckbHIK_GigE = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsRtbLog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbParams.SuspendLayout();
            this.gbGrabbing.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(13);
            this.splitContainer1.Size = new System.Drawing.Size(898, 853);
            this.splitContainer1.SplitterDistance = 538;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbbDeviceList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(896, 536);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(20, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cbbDeviceList
            // 
            this.cbbDeviceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbDeviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeviceList.FormattingEnabled = true;
            this.cbbDeviceList.Location = new System.Drawing.Point(20, 20);
            this.cbbDeviceList.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDeviceList.Name = "cbbDeviceList";
            this.cbbDeviceList.Size = new System.Drawing.Size(856, 23);
            this.cbbDeviceList.TabIndex = 2;
            this.cbbDeviceList.SelectedIndexChanged += new System.EventHandler(this.cbbDeviceList_SelectedIndexChanged);
            // 
            // rtbLog
            // 
            this.rtbLog.ContextMenuStrip = this.cmsRtbLog;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbLog.Location = new System.Drawing.Point(13, 13);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(870, 283);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // cmsRtbLog
            // 
            this.cmsRtbLog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRtbLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearLog});
            this.cmsRtbLog.Name = "cmsRtbLog";
            this.cmsRtbLog.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(108, 24);
            this.tsmiClearLog.Text = "清空";
            this.tsmiClearLog.Click += new System.EventHandler(this.tsmiClearLog_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbParams);
            this.panel2.Controls.Add(this.gbGrabbing);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(898, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(456, 853);
            this.panel2.TabIndex = 24;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.label7);
            this.gbParams.Controls.Add(this.label6);
            this.gbParams.Controls.Add(this.tbImageHeight);
            this.gbParams.Controls.Add(this.label5);
            this.gbParams.Controls.Add(this.tbImageWidth);
            this.gbParams.Controls.Add(this.label4);
            this.gbParams.Controls.Add(this.tbDelay);
            this.gbParams.Controls.Add(this.btnSetParams);
            this.gbParams.Controls.Add(this.btnGetParams);
            this.gbParams.Controls.Add(this.label2);
            this.gbParams.Controls.Add(this.label1);
            this.gbParams.Controls.Add(this.tbGain);
            this.gbParams.Controls.Add(this.tbExposure);
            this.gbParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbParams.Enabled = false;
            this.gbParams.Location = new System.Drawing.Point(20, 481);
            this.gbParams.Margin = new System.Windows.Forms.Padding(4);
            this.gbParams.Name = "gbParams";
            this.gbParams.Padding = new System.Windows.Forms.Padding(4);
            this.gbParams.Size = new System.Drawing.Size(416, 240);
            this.gbParams.TabIndex = 23;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "参数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "(us)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "图像高：";
            // 
            // tbImageHeight
            // 
            this.tbImageHeight.Location = new System.Drawing.Point(283, 75);
            this.tbImageHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbImageHeight.Name = "tbImageHeight";
            this.tbImageHeight.Size = new System.Drawing.Size(97, 25);
            this.tbImageHeight.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "图像宽：";
            // 
            // tbImageWidth
            // 
            this.tbImageWidth.Location = new System.Drawing.Point(83, 75);
            this.tbImageWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbImageWidth.Name = "tbImageWidth";
            this.tbImageWidth.Size = new System.Drawing.Size(97, 25);
            this.tbImageWidth.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "延时：";
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(83, 120);
            this.tbDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(97, 25);
            this.tbDelay.TabIndex = 34;
            // 
            // btnSetParams
            // 
            this.btnSetParams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetParams.Location = new System.Drawing.Point(230, 180);
            this.btnSetParams.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetParams.Name = "btnSetParams";
            this.btnSetParams.Size = new System.Drawing.Size(150, 35);
            this.btnSetParams.TabIndex = 36;
            this.btnSetParams.Text = "设置参数";
            this.btnSetParams.UseVisualStyleBackColor = true;
            this.btnSetParams.Click += new System.EventHandler(this.btnSetParams_Click);
            // 
            // btnGetParams
            // 
            this.btnGetParams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetParams.Location = new System.Drawing.Point(30, 180);
            this.btnGetParams.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetParams.Name = "btnGetParams";
            this.btnGetParams.Size = new System.Drawing.Size(150, 35);
            this.btnGetParams.TabIndex = 35;
            this.btnGetParams.Text = "获取参数";
            this.btnGetParams.UseVisualStyleBackColor = true;
            this.btnGetParams.Click += new System.EventHandler(this.btnGetParams_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(227, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "增益：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "曝光：";
            // 
            // tbGain
            // 
            this.tbGain.Location = new System.Drawing.Point(283, 25);
            this.tbGain.Margin = new System.Windows.Forms.Padding(4);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(97, 25);
            this.tbGain.TabIndex = 31;
            // 
            // tbExposure
            // 
            this.tbExposure.Location = new System.Drawing.Point(83, 25);
            this.tbExposure.Margin = new System.Windows.Forms.Padding(4);
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(97, 25);
            this.tbExposure.TabIndex = 30;
            // 
            // gbGrabbing
            // 
            this.gbGrabbing.Controls.Add(this.btnTriggerExec);
            this.gbGrabbing.Controls.Add(this.btnContinuous);
            this.gbGrabbing.Controls.Add(this.rdoExternTrigger);
            this.gbGrabbing.Controls.Add(this.rdoSoftTrigger);
            this.gbGrabbing.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGrabbing.Enabled = false;
            this.gbGrabbing.Location = new System.Drawing.Point(20, 341);
            this.gbGrabbing.Margin = new System.Windows.Forms.Padding(4);
            this.gbGrabbing.Name = "gbGrabbing";
            this.gbGrabbing.Padding = new System.Windows.Forms.Padding(4);
            this.gbGrabbing.Size = new System.Drawing.Size(416, 140);
            this.gbGrabbing.TabIndex = 21;
            this.gbGrabbing.TabStop = false;
            this.gbGrabbing.Text = "采集图像";
            // 
            // btnTriggerExec
            // 
            this.btnTriggerExec.Enabled = false;
            this.btnTriggerExec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTriggerExec.Location = new System.Drawing.Point(230, 80);
            this.btnTriggerExec.Margin = new System.Windows.Forms.Padding(4);
            this.btnTriggerExec.Name = "btnTriggerExec";
            this.btnTriggerExec.Size = new System.Drawing.Size(150, 35);
            this.btnTriggerExec.TabIndex = 24;
            this.btnTriggerExec.Text = "软触发一次";
            this.btnTriggerExec.UseVisualStyleBackColor = true;
            this.btnTriggerExec.Click += new System.EventHandler(this.btnTriggerExec_Click);
            // 
            // btnContinuous
            // 
            this.btnContinuous.Enabled = false;
            this.btnContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnContinuous.Location = new System.Drawing.Point(30, 80);
            this.btnContinuous.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuous.Name = "btnContinuous";
            this.btnContinuous.Size = new System.Drawing.Size(150, 35);
            this.btnContinuous.TabIndex = 23;
            this.btnContinuous.Text = "实时";
            this.btnContinuous.UseVisualStyleBackColor = true;
            this.btnContinuous.Click += new System.EventHandler(this.btnStartGrab_Click);
            // 
            // rdoExternTrigger
            // 
            this.rdoExternTrigger.AutoSize = true;
            this.rdoExternTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoExternTrigger.Location = new System.Drawing.Point(230, 35);
            this.rdoExternTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.rdoExternTrigger.Name = "rdoExternTrigger";
            this.rdoExternTrigger.Size = new System.Drawing.Size(73, 19);
            this.rdoExternTrigger.TabIndex = 22;
            this.rdoExternTrigger.Text = "硬触发";
            this.rdoExternTrigger.UseMnemonic = false;
            this.rdoExternTrigger.UseVisualStyleBackColor = true;
            this.rdoExternTrigger.CheckedChanged += new System.EventHandler(this.rdoExternTrigger_CheckedChanged);
            // 
            // rdoSoftTrigger
            // 
            this.rdoSoftTrigger.AutoSize = true;
            this.rdoSoftTrigger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoSoftTrigger.Location = new System.Drawing.Point(30, 35);
            this.rdoSoftTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSoftTrigger.Name = "rdoSoftTrigger";
            this.rdoSoftTrigger.Size = new System.Drawing.Size(73, 19);
            this.rdoSoftTrigger.TabIndex = 21;
            this.rdoSoftTrigger.Text = "软触发";
            this.rdoSoftTrigger.UseVisualStyleBackColor = true;
            this.rdoSoftTrigger.CheckedChanged += new System.EventHandler(this.rdoSoftTrigger_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(416, 145);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始化";
            // 
            // btnRename
            // 
            this.btnRename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRename.Location = new System.Drawing.Point(230, 30);
            this.btnRename.Margin = new System.Windows.Forms.Padding(4);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(150, 35);
            this.btnRename.TabIndex = 11;
            this.btnRename.Text = "重命名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(230, 90);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭相机";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpen.Location = new System.Drawing.Point(30, 90);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 35);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "打开相机";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(30, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 35);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "搜索相机";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbDH);
            this.groupBox2.Controls.Add(this.ckbFLIR);
            this.groupBox2.Controls.Add(this.btnSelectCti);
            this.groupBox2.Controls.Add(this.tbCtiPath);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ckbHIK_GenTL);
            this.groupBox2.Controls.Add(this.ckbBasler);
            this.groupBox2.Controls.Add(this.ckbHIK_GigE);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(416, 176);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相机品牌";
            // 
            // ckbDH
            // 
            this.ckbDH.AutoSize = true;
            this.ckbDH.Location = new System.Drawing.Point(16, 78);
            this.ckbDH.Name = "ckbDH";
            this.ckbDH.Size = new System.Drawing.Size(69, 19);
            this.ckbDH.TabIndex = 2;
            this.ckbDH.Text = "LD017";
            this.ckbDH.UseVisualStyleBackColor = true;
            // 
            // ckbFLIR
            // 
            this.ckbFLIR.AutoSize = true;
            this.ckbFLIR.Location = new System.Drawing.Point(163, 78);
            this.ckbFLIR.Name = "ckbFLIR";
            this.ckbFLIR.Size = new System.Drawing.Size(69, 19);
            this.ckbFLIR.TabIndex = 3;
            this.ckbFLIR.Text = "LD024";
            this.ckbFLIR.UseVisualStyleBackColor = true;
            // 
            // btnSelectCti
            // 
            this.btnSelectCti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectCti.Enabled = false;
            this.btnSelectCti.Location = new System.Drawing.Point(372, 115);
            this.btnSelectCti.Name = "btnSelectCti";
            this.btnSelectCti.Size = new System.Drawing.Size(35, 25);
            this.btnSelectCti.TabIndex = 5;
            this.btnSelectCti.UseVisualStyleBackColor = true;
            this.btnSelectCti.Click += new System.EventHandler(this.btnSelectCti_Click);
            // 
            // tbCtiPath
            // 
            this.tbCtiPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCtiPath.Enabled = false;
            this.tbCtiPath.Location = new System.Drawing.Point(104, 115);
            this.tbCtiPath.Name = "tbCtiPath";
            this.tbCtiPath.Size = new System.Drawing.Size(268, 25);
            this.tbCtiPath.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = ".cti 文件：";
            // 
            // ckbHIK_GenTL
            // 
            this.ckbHIK_GenTL.AutoSize = true;
            this.ckbHIK_GenTL.Location = new System.Drawing.Point(163, 40);
            this.ckbHIK_GenTL.Name = "ckbHIK_GenTL";
            this.ckbHIK_GenTL.Size = new System.Drawing.Size(109, 19);
            this.ckbHIK_GenTL.TabIndex = 1;
            this.ckbHIK_GenTL.Text = "LD016(CXP)";
            this.ckbHIK_GenTL.UseVisualStyleBackColor = true;
            this.ckbHIK_GenTL.CheckedChanged += new System.EventHandler(this.ckbHIK_GenTL_CheckedChanged);
            // 
            // ckbBasler
            // 
            this.ckbBasler.AutoSize = true;
            this.ckbBasler.Location = new System.Drawing.Point(295, 78);
            this.ckbBasler.Name = "ckbBasler";
            this.ckbBasler.Size = new System.Drawing.Size(77, 19);
            this.ckbBasler.TabIndex = 4;
            this.ckbBasler.Text = "Basler";
            this.ckbBasler.UseVisualStyleBackColor = true;
            // 
            // ckbHIK_GigE
            // 
            this.ckbHIK_GigE.AutoSize = true;
            this.ckbHIK_GigE.Location = new System.Drawing.Point(16, 40);
            this.ckbHIK_GigE.Name = "ckbHIK_GigE";
            this.ckbHIK_GigE.Size = new System.Drawing.Size(141, 19);
            this.ckbHIK_GigE.TabIndex = 0;
            this.ckbHIK_GigE.Text = "LD016(GigE/U3)";
            this.ckbHIK_GigE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 853);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsRtbLog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.gbGrabbing.ResumeLayout(false);
            this.gbGrabbing.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Button btnSetParams;
        private System.Windows.Forms.Button btnGetParams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGain;
        private System.Windows.Forms.TextBox tbExposure;
        private System.Windows.Forms.GroupBox gbGrabbing;
        private System.Windows.Forms.Button btnTriggerExec;
        private System.Windows.Forms.Button btnContinuous;
        private System.Windows.Forms.RadioButton rdoExternTrigger;
        private System.Windows.Forms.RadioButton rdoSoftTrigger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbDeviceList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsRtbLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbImageHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImageWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectCti;
        private System.Windows.Forms.TextBox tbCtiPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbHIK_GenTL;
        private System.Windows.Forms.CheckBox ckbBasler;
        private System.Windows.Forms.CheckBox ckbHIK_GigE;
        private System.Windows.Forms.CheckBox ckbFLIR;
        private System.Windows.Forms.CheckBox ckbDH;
    }
}

