﻿namespace _86boxManager
{
    partial class dlgSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgSettings));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxShowConsole = new System.Windows.Forms.CheckBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gbxBehaviour = new System.Windows.Forms.GroupBox();
            this.cbxMinimizeTray = new System.Windows.Forms.CheckBox();
            this.cbxCloseTray = new System.Windows.Forms.CheckBox();
            this.cbxMinimize = new System.Windows.Forms.CheckBox();
            this.gbxPaths = new System.Windows.Forms.GroupBox();
            this.lbl86BoxVer1 = new System.Windows.Forms.Label();
            this.lbl86BoxVer = new System.Windows.Forms.Label();
            this.lblCFGdir = new System.Windows.Forms.Label();
            this.txtCFGdir = new System.Windows.Forms.TextBox();
            this.txtEXEdir = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblEXEdir = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.gbxLogging = new System.Windows.Forms.GroupBox();
            this.cbxLogging = new System.Windows.Forms.CheckBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.gbxMisc = new System.Windows.Forms.GroupBox();
            this.cbxGrid = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblVersion1 = new System.Windows.Forms.Label();
            this.lnkGithub2 = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gbxBehaviour.SuspendLayout();
            this.gbxPaths.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.gbxLogging.SuspendLayout();
            this.gbxMisc.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Location = new System.Drawing.Point(633, 11);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(65, 30);
            this.btnApply.TabIndex = 17;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(564, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(495, 11);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 30);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "完成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxShowConsole
            // 
            this.cbxShowConsole.AutoSize = true;
            this.cbxShowConsole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxShowConsole.Location = new System.Drawing.Point(319, 25);
            this.cbxShowConsole.Margin = new System.Windows.Forms.Padding(2);
            this.cbxShowConsole.Name = "cbxShowConsole";
            this.cbxShowConsole.Size = new System.Drawing.Size(178, 24);
            this.cbxShowConsole.TabIndex = 13;
            this.cbxShowConsole.Text = "启用 86Box 控制台窗口";
            this.cbxShowConsole.UseVisualStyleBackColor = true;
            this.cbxShowConsole.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDefaults.Location = new System.Drawing.Point(11, 11);
            this.btnDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(65, 30);
            this.btnDefaults.TabIndex = 14;
            this.btnDefaults.Text = "默认";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Controls.Add(this.btnDefaults);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 284);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(709, 52);
            this.pnlBottom.TabIndex = 14;
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabGeneral);
            this.tbcSettings.Controls.Add(this.tabAdvanced);
            this.tbcSettings.Controls.Add(this.tabAbout);
            this.tbcSettings.Location = new System.Drawing.Point(12, 12);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(689, 263);
            this.tbcSettings.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.gbxBehaviour);
            this.tabGeneral.Controls.Add(this.gbxPaths);
            this.tabGeneral.Location = new System.Drawing.Point(4, 26);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(681, 233);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "通用";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gbxBehaviour
            // 
            this.gbxBehaviour.Controls.Add(this.cbxMinimizeTray);
            this.gbxBehaviour.Controls.Add(this.cbxCloseTray);
            this.gbxBehaviour.Controls.Add(this.cbxMinimize);
            this.gbxBehaviour.Location = new System.Drawing.Point(6, 141);
            this.gbxBehaviour.Name = "gbxBehaviour";
            this.gbxBehaviour.Size = new System.Drawing.Size(669, 86);
            this.gbxBehaviour.TabIndex = 6;
            this.gbxBehaviour.TabStop = false;
            this.gbxBehaviour.Text = "Behaviour";
            // 
            // cbxMinimizeTray
            // 
            this.cbxMinimizeTray.AutoSize = true;
            this.cbxMinimizeTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMinimizeTray.Location = new System.Drawing.Point(9, 23);
            this.cbxMinimizeTray.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMinimizeTray.Name = "cbxMinimizeTray";
            this.cbxMinimizeTray.Size = new System.Drawing.Size(265, 24);
            this.cbxMinimizeTray.TabIndex = 5;
            this.cbxMinimizeTray.Text = "将 86Box Manager 最小化到托盘图标";
            this.cbxMinimizeTray.UseVisualStyleBackColor = true;
            this.cbxMinimizeTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxCloseTray
            // 
            this.cbxCloseTray.AutoSize = true;
            this.cbxCloseTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCloseTray.Location = new System.Drawing.Point(337, 23);
            this.cbxCloseTray.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCloseTray.Name = "cbxCloseTray";
            this.cbxCloseTray.Size = new System.Drawing.Size(251, 24);
            this.cbxCloseTray.TabIndex = 6;
            this.cbxCloseTray.Text = "将 86Box Manager 关闭到托盘图标";
            this.cbxCloseTray.UseVisualStyleBackColor = true;
            this.cbxCloseTray.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxMinimize
            // 
            this.cbxMinimize.AutoSize = true;
            this.cbxMinimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMinimize.Location = new System.Drawing.Point(9, 51);
            this.cbxMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMinimize.Name = "cbxMinimize";
            this.cbxMinimize.Size = new System.Drawing.Size(275, 24);
            this.cbxMinimize.TabIndex = 7;
            this.cbxMinimize.Text = "在虚拟机启动时最小化 86Box Manager";
            this.cbxMinimize.UseVisualStyleBackColor = true;
            this.cbxMinimize.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // gbxPaths
            // 
            this.gbxPaths.Controls.Add(this.lbl86BoxVer1);
            this.gbxPaths.Controls.Add(this.lbl86BoxVer);
            this.gbxPaths.Controls.Add(this.lblCFGdir);
            this.gbxPaths.Controls.Add(this.txtCFGdir);
            this.gbxPaths.Controls.Add(this.txtEXEdir);
            this.gbxPaths.Controls.Add(this.btnBrowse2);
            this.gbxPaths.Controls.Add(this.lblEXEdir);
            this.gbxPaths.Controls.Add(this.btnBrowse1);
            this.gbxPaths.Location = new System.Drawing.Point(6, 6);
            this.gbxPaths.Name = "gbxPaths";
            this.gbxPaths.Size = new System.Drawing.Size(669, 129);
            this.gbxPaths.TabIndex = 5;
            this.gbxPaths.TabStop = false;
            this.gbxPaths.Text = "Paths";
            // 
            // lbl86BoxVer1
            // 
            this.lbl86BoxVer1.AutoSize = true;
            this.lbl86BoxVer1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl86BoxVer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl86BoxVer1.Location = new System.Drawing.Point(100, 59);
            this.lbl86BoxVer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl86BoxVer1.Name = "lbl86BoxVer1";
            this.lbl86BoxVer1.Size = new System.Drawing.Size(170, 19);
            this.lbl86BoxVer1.TabIndex = 6;
            this.lbl86BoxVer1.Text = "<status string goes here>";
            // 
            // lbl86BoxVer
            // 
            this.lbl86BoxVer.AutoSize = true;
            this.lbl86BoxVer.Location = new System.Drawing.Point(5, 59);
            this.lbl86BoxVer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl86BoxVer.Name = "lbl86BoxVer";
            this.lbl86BoxVer.Size = new System.Drawing.Size(82, 19);
            this.lbl86BoxVer.TabIndex = 5;
            this.lbl86BoxVer.Text = "86Box 版本:";
            // 
            // lblCFGdir
            // 
            this.lblCFGdir.AutoSize = true;
            this.lblCFGdir.Location = new System.Drawing.Point(5, 93);
            this.lblCFGdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCFGdir.Name = "lblCFGdir";
            this.lblCFGdir.Size = new System.Drawing.Size(96, 19);
            this.lblCFGdir.TabIndex = 4;
            this.lblCFGdir.Text = "虚拟机的路径:";
            // 
            // txtCFGdir
            // 
            this.txtCFGdir.Location = new System.Drawing.Point(104, 90);
            this.txtCFGdir.Margin = new System.Windows.Forms.Padding(2);
            this.txtCFGdir.Name = "txtCFGdir";
            this.txtCFGdir.Size = new System.Drawing.Size(497, 25);
            this.txtCFGdir.TabIndex = 3;
            this.txtCFGdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtEXEdir
            // 
            this.txtEXEdir.Location = new System.Drawing.Point(93, 23);
            this.txtEXEdir.Margin = new System.Windows.Forms.Padding(2);
            this.txtEXEdir.Name = "txtEXEdir";
            this.txtEXEdir.Size = new System.Drawing.Size(497, 25);
            this.txtEXEdir.TabIndex = 1;
            this.txtEXEdir.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse2.Location = new System.Drawing.Point(605, 90);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(59, 27);
            this.btnBrowse2.TabIndex = 4;
            this.btnBrowse2.Text = "Browse...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lblEXEdir
            // 
            this.lblEXEdir.AutoSize = true;
            this.lblEXEdir.Location = new System.Drawing.Point(5, 26);
            this.lblEXEdir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEXEdir.Name = "lblEXEdir";
            this.lblEXEdir.Size = new System.Drawing.Size(82, 19);
            this.lblEXEdir.TabIndex = 3;
            this.lblEXEdir.Text = "86Box 路径:";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBrowse1.Location = new System.Drawing.Point(594, 20);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(70, 30);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "Browse...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.gbxLogging);
            this.tabAdvanced.Controls.Add(this.gbxMisc);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 26);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(681, 233);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "高级";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbxLogging
            // 
            this.gbxLogging.Controls.Add(this.cbxLogging);
            this.gbxLogging.Controls.Add(this.txtLogPath);
            this.gbxLogging.Controls.Add(this.btnBrowse3);
            this.gbxLogging.Location = new System.Drawing.Point(6, 6);
            this.gbxLogging.Name = "gbxLogging";
            this.gbxLogging.Size = new System.Drawing.Size(669, 93);
            this.gbxLogging.TabIndex = 18;
            this.gbxLogging.TabStop = false;
            this.gbxLogging.Text = "记录";
            // 
            // cbxLogging
            // 
            this.cbxLogging.AutoSize = true;
            this.cbxLogging.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxLogging.Location = new System.Drawing.Point(9, 23);
            this.cbxLogging.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLogging.Name = "cbxLogging";
            this.cbxLogging.Size = new System.Drawing.Size(192, 24);
            this.cbxLogging.TabIndex = 9;
            this.cbxLogging.Text = "启用 86Box 记录到文件：";
            this.cbxLogging.UseVisualStyleBackColor = true;
            this.cbxLogging.CheckedChanged += new System.EventHandler(this.cbxLogging_CheckedChanged);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(9, 52);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(580, 25);
            this.txtLogPath.TabIndex = 10;
            this.txtLogPath.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse3.Location = new System.Drawing.Point(594, 49);
            this.btnBrowse3.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(70, 30);
            this.btnBrowse3.TabIndex = 11;
            this.btnBrowse3.Text = "Browse...";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // gbxMisc
            // 
            this.gbxMisc.Controls.Add(this.cbxGrid);
            this.gbxMisc.Controls.Add(this.cbxShowConsole);
            this.gbxMisc.Location = new System.Drawing.Point(6, 105);
            this.gbxMisc.Name = "gbxMisc";
            this.gbxMisc.Size = new System.Drawing.Size(669, 58);
            this.gbxMisc.TabIndex = 17;
            this.gbxMisc.TabStop = false;
            this.gbxMisc.Text = "Miscellaneous";
            // 
            // cbxGrid
            // 
            this.cbxGrid.AutoSize = true;
            this.cbxGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxGrid.Location = new System.Drawing.Point(9, 23);
            this.cbxGrid.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGrid.Name = "cbxGrid";
            this.cbxGrid.Size = new System.Drawing.Size(239, 26);
            this.cbxGrid.TabIndex = 12;
            this.cbxGrid.Text = "在虚拟机列表中启用网格线";
            this.cbxGrid.UseVisualStyleBackColor = true;
            this.cbxGrid.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lnkGithub);
            this.tabAbout.Controls.Add(this.imgLogo);
            this.tabAbout.Controls.Add(this.lblVersion1);
            this.tabAbout.Controls.Add(this.lnkGithub2);
            this.tabAbout.Controls.Add(this.lblCopyright);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblDesc);
            this.tabAbout.Controls.Add(this.lblTitle);
            this.tabAbout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabAbout.Location = new System.Drawing.Point(4, 26);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(681, 233);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "关于";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lnkGithub
            // 
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkGithub.Location = new System.Drawing.Point(15, 200);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(264, 19);
            this.lnkGithub.TabIndex = 12;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "https://github.com/86Box/86BoxManager";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(18, 15);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(38, 38);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 17;
            this.imgLogo.TabStop = false;
            // 
            // lblVersion1
            // 
            this.lblVersion1.AutoSize = true;
            this.lblVersion1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion1.Location = new System.Drawing.Point(55, 83);
            this.lblVersion1.Name = "lblVersion1";
            this.lblVersion1.Size = new System.Drawing.Size(137, 19);
            this.lblVersion1.TabIndex = 16;
            this.lblVersion1.Text = "<version goes here>";
            this.lblVersion1.Click += new System.EventHandler(this.lblVersion1_Click);
            // 
            // lnkGithub2
            // 
            this.lnkGithub2.AutoSize = true;
            this.lnkGithub2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkGithub2.Location = new System.Drawing.Point(15, 177);
            this.lnkGithub2.Name = "lnkGithub2";
            this.lnkGithub2.Size = new System.Drawing.Size(338, 19);
            this.lnkGithub2.TabIndex = 10;
            this.lnkGithub2.TabStop = true;
            this.lnkGithub2.Text = "https://github.com/King-zzk/86Box-Manager-Chinese";
            this.lnkGithub2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub2_LinkClicked);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCopyright.Location = new System.Drawing.Point(15, 111);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(522, 57);
            this.lblCopyright.TabIndex = 15;
            this.lblCopyright.Text = "版权所有 © 2018-2024 David Simunič根据 MIT 许可获得许可。\r\n有关许可信息，请参阅 LICENSE 文件，关于贡献者的列表请查看86" +
    "Box AUTHORS。\r\n汉化:King of Zzk\r\n";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion.Location = new System.Drawing.Point(15, 83);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 19);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "版本:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesc.Location = new System.Drawing.Point(15, 55);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(177, 19);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "86Box 仿真器的配置管理器";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(63, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 28);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "86Box Manager 中文版";
            // 
            // dlgSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.tbcSettings);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgSettings_FormClosing);
            this.Load += new System.EventHandler(this.dlgSettings_Load);
            this.pnlBottom.ResumeLayout(false);
            this.tbcSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.gbxBehaviour.ResumeLayout(false);
            this.gbxBehaviour.PerformLayout();
            this.gbxPaths.ResumeLayout(false);
            this.gbxPaths.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.gbxLogging.ResumeLayout(false);
            this.gbxLogging.PerformLayout();
            this.gbxMisc.ResumeLayout(false);
            this.gbxMisc.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbxShowConsole;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gbxBehaviour;
        private System.Windows.Forms.CheckBox cbxMinimizeTray;
        private System.Windows.Forms.CheckBox cbxCloseTray;
        private System.Windows.Forms.CheckBox cbxMinimize;
        private System.Windows.Forms.GroupBox gbxPaths;
        private System.Windows.Forms.Label lblCFGdir;
        private System.Windows.Forms.TextBox txtCFGdir;
        private System.Windows.Forms.TextBox txtEXEdir;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lblEXEdir;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Label lbl86BoxVer1;
        private System.Windows.Forms.Label lbl86BoxVer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbxMisc;
        private System.Windows.Forms.CheckBox cbxLogging;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.CheckBox cbxGrid;
        private System.Windows.Forms.GroupBox gbxLogging;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblVersion1;
        private System.Windows.Forms.LinkLabel lnkGithub2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
    }
}