using System;

namespace ModernUI
{
    partial class ModernForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernForm));
            this.LayoutHelper = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.NavInner = new System.Windows.Forms.Panel();
            this.TextLabel = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new ModernUI.ModernButton();
            this.Tasks = new ModernUI.Tasks();
            this.button4 = new ModernUI.ModernButton();
            this.btnLihatTransaksi = new ModernUI.ModernButton();
            this.tskLihatTransaksi = new ModernUI.TaskPanel();
            this.btnInputTransaksi = new ModernUI.ModernButton();
            this.tskInputTransaksi = new ModernUI.TaskPanel();
            this.modernButton1 = new ModernUI.ModernButton();
            this.LayoutHelper.SuspendLayout();
            this.NavInner.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.tskInputTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutHelper
            // 
            this.LayoutHelper.ColumnCount = 6;
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.LayoutHelper.Controls.Add(this.btnMaximize, 4, 0);
            this.LayoutHelper.Controls.Add(this.btnBack, 5, 0);
            this.LayoutHelper.Controls.Add(this.Back, 0, 0);
            this.LayoutHelper.Controls.Add(this.NavInner, 1, 0);
            this.LayoutHelper.Controls.Add(this.MinBtn, 3, 0);
            this.LayoutHelper.Controls.Add(this.TitleBar, 2, 0);
            this.LayoutHelper.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutHelper.Location = new System.Drawing.Point(1, 1);
            this.LayoutHelper.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutHelper.Name = "LayoutHelper";
            this.LayoutHelper.RowCount = 2;
            this.LayoutHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.LayoutHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutHelper.Size = new System.Drawing.Size(694, 30);
            this.LayoutHelper.TabIndex = 3;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.BackgroundImage = global::ModernUI.Properties.Resources.Maximize;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(600, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(46, 31);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.BackgroundImage = global::ModernUI.Properties.Resources.Close;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(12)))), ((int)(((byte)(35)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(646, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 31);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Close_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Back.BackgroundImage = global::ModernUI.Properties.Resources.Back;
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Margin = new System.Windows.Forms.Padding(0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(48, 31);
            this.Back.TabIndex = 1;
            this.Back.TabStop = false;
            this.Back.UseVisualStyleBackColor = false;
            // 
            // NavInner
            // 
            this.NavInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.NavInner.Controls.Add(this.TextLabel);
            this.NavInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavInner.Location = new System.Drawing.Point(48, 0);
            this.NavInner.Margin = new System.Windows.Forms.Padding(0);
            this.NavInner.Name = "NavInner";
            this.NavInner.Size = new System.Drawing.Size(222, 31);
            this.NavInner.TabIndex = 0;
            // 
            // TextLabel
            // 
            this.TextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextLabel.Location = new System.Drawing.Point(0, 0);
            this.TextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.TextLabel.Size = new System.Drawing.Size(222, 31);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Manager";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinBtn.BackgroundImage = global::ModernUI.Properties.Resources.Minimize;
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(554, 0);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(46, 31);
            this.MinBtn.TabIndex = 4;
            this.MinBtn.TabStop = false;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBar.Location = new System.Drawing.Point(270, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(284, 31);
            this.TitleBar.TabIndex = 5;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.NavPanel.ColumnCount = 1;
            this.NavPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.NavPanel.Controls.Add(this.button1, 0, 4);
            this.NavPanel.Controls.Add(this.button4, 0, 3);
            this.NavPanel.Controls.Add(this.btnLihatTransaksi, 0, 2);
            this.NavPanel.Controls.Add(this.btnInputTransaksi, 0, 1);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(1, 31);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.RowCount = 9;
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.NavPanel.Size = new System.Drawing.Size(270, 380);
            this.NavPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ActivateTaskOnClick = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.button1.CheckedState = false;
            this.button1.Description = null;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ExtraDescription = null;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HasStates = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.button1.Location = new System.Drawing.Point(0, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(270, 51);
            this.button1.Style = ModernUI.ModernButton.Styles.Default;
            this.button1.TabIndex = 4;
            this.button1.Task = null;
            this.button1.Tasks = this.Tasks;
            this.button1.Text = "     Produk";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.Title = null;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tasks
            // 
            this.Tasks.ParentForm = this;
            // 
            // button4
            // 
            this.button4.ActivateTaskOnClick = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button4.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.button4.CheckedState = false;
            this.button4.Description = null;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.ExtraDescription = null;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.HasStates = true;
            this.button4.Image = global::ModernUI.Properties.Resources.Edit_User1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.button4.Location = new System.Drawing.Point(0, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(270, 51);
            this.button4.Style = ModernUI.ModernButton.Styles.Default;
            this.button4.TabIndex = 3;
            this.button4.Task = null;
            this.button4.Tasks = this.Tasks;
            this.button4.Text = "     Edit Data Karyawan";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.Title = null;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLihatTransaksi
            // 
            this.btnLihatTransaksi.ActivateTaskOnClick = true;
            this.btnLihatTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnLihatTransaksi.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.btnLihatTransaksi.CheckedState = false;
            this.btnLihatTransaksi.Description = null;
            this.btnLihatTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLihatTransaksi.ExtraDescription = null;
            this.btnLihatTransaksi.FlatAppearance.BorderSize = 0;
            this.btnLihatTransaksi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnLihatTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnLihatTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLihatTransaksi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLihatTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnLihatTransaksi.HasStates = true;
            this.btnLihatTransaksi.Image = global::ModernUI.Properties.Resources.List;
            this.btnLihatTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatTransaksi.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.btnLihatTransaksi.Location = new System.Drawing.Point(0, 71);
            this.btnLihatTransaksi.Margin = new System.Windows.Forms.Padding(0);
            this.btnLihatTransaksi.Name = "btnLihatTransaksi";
            this.btnLihatTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLihatTransaksi.Size = new System.Drawing.Size(270, 51);
            this.btnLihatTransaksi.Style = ModernUI.ModernButton.Styles.Default;
            this.btnLihatTransaksi.TabIndex = 2;
            this.btnLihatTransaksi.Task = this.tskLihatTransaksi;
            this.btnLihatTransaksi.Tasks = this.Tasks;
            this.btnLihatTransaksi.Text = "     Lihat transaksi";
            this.btnLihatTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihatTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLihatTransaksi.Title = null;
            this.btnLihatTransaksi.UseVisualStyleBackColor = false;
            this.btnLihatTransaksi.Click += new System.EventHandler(this.button3_Click);
            // 
            // tskLihatTransaksi
            // 
            this.tskLihatTransaksi.BottomPanelHeight = 80;
            this.tskLihatTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tskLihatTransaksi.HasBottomPanel = false;
            this.tskLihatTransaksi.Location = new System.Drawing.Point(271, 31);
            this.tskLihatTransaksi.Name = "tskLihatTransaksi";
            this.tskLihatTransaksi.Size = new System.Drawing.Size(424, 380);
            this.tskLihatTransaksi.TabIndex = 2;
            this.tskLihatTransaksi.Title = "Lihat Transaksi";
            // 
            // btnInputTransaksi
            // 
            this.btnInputTransaksi.ActivateTaskOnClick = true;
            this.btnInputTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInputTransaksi.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.btnInputTransaksi.CheckedState = true;
            this.btnInputTransaksi.Description = null;
            this.btnInputTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInputTransaksi.ExtraDescription = null;
            this.btnInputTransaksi.FlatAppearance.BorderSize = 0;
            this.btnInputTransaksi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnInputTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnInputTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputTransaksi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInputTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnInputTransaksi.HasStates = true;
            this.btnInputTransaksi.Image = global::ModernUI.Properties.Resources.Add_Transaction1;
            this.btnInputTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInputTransaksi.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.btnInputTransaksi.Location = new System.Drawing.Point(0, 20);
            this.btnInputTransaksi.Margin = new System.Windows.Forms.Padding(0);
            this.btnInputTransaksi.Name = "btnInputTransaksi";
            this.btnInputTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInputTransaksi.Size = new System.Drawing.Size(270, 51);
            this.btnInputTransaksi.Style = ModernUI.ModernButton.Styles.Default;
            this.btnInputTransaksi.TabIndex = 1;
            this.btnInputTransaksi.Task = this.tskInputTransaksi;
            this.btnInputTransaksi.Tasks = this.Tasks;
            this.btnInputTransaksi.Text = "     Input Transaksi";
            this.btnInputTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInputTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInputTransaksi.Title = null;
            this.btnInputTransaksi.UseVisualStyleBackColor = false;
            this.btnInputTransaksi.Click += new System.EventHandler(this.button2_Click);
            // 
            // tskInputTransaksi
            // 
            this.tskInputTransaksi.BottomPanelHeight = 80;
            this.tskInputTransaksi.Controls.Add(this.modernButton1);
            this.tskInputTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tskInputTransaksi.HasBottomPanel = true;
            this.tskInputTransaksi.Location = new System.Drawing.Point(271, 31);
            this.tskInputTransaksi.Name = "tskInputTransaksi";
            this.tskInputTransaksi.Size = new System.Drawing.Size(424, 380);
            this.tskInputTransaksi.TabIndex = 5;
            this.tskInputTransaksi.Title = "Input Transaksi";
            // 
            // modernButton1
            // 
            this.modernButton1.ActivateTaskOnClick = true;
            this.modernButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modernButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.modernButton1.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.modernButton1.CheckedState = false;
            this.modernButton1.Description = null;
            this.modernButton1.ExtraDescription = null;
            this.modernButton1.FlatAppearance.BorderSize = 0;
            this.modernButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.modernButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.modernButton1.ForeColor = System.Drawing.Color.White;
            this.modernButton1.HasStates = false;
            this.modernButton1.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.modernButton1.Location = new System.Drawing.Point(284, 345);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(150, 32);
            this.modernButton1.Style = ModernUI.ModernButton.Styles.Button;
            this.modernButton1.TabIndex = 6;
            this.modernButton1.Task = null;
            this.modernButton1.Tasks = null;
            this.modernButton1.Text = "modernButton1";
            this.modernButton1.Title = null;
            this.modernButton1.UseVisualStyleBackColor = false;
            // 
            // ModernForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(696, 412);
            this.Controls.Add(this.tskInputTransaksi);
            this.Controls.Add(this.tskLihatTransaksi);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.LayoutHelper);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(696, 412);
            this.Name = "ModernForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Manager";
            this.LayoutHelper.ResumeLayout(false);
            this.NavInner.ResumeLayout(false);
            this.NavPanel.ResumeLayout(false);
            this.tskInputTransaksi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ChangeText(object sender, EventArgs e)
        {
            TextLabel.Text = this.Text;
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel LayoutHelper;
        private System.Windows.Forms.TableLayoutPanel NavPanel;
        private ModernUI.ModernButton btnInputTransaksi;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel NavInner;
        private System.Windows.Forms.Label TextLabel;
        private ModernUI.ModernButton btnLihatTransaksi;
        private ModernUI.ModernButton button4;
        private ModernUI.ModernButton button1;
        private ModernUI.Tasks Tasks;
        private ModernUI.TaskPanel tskInputTransaksi;
        private ModernUI.TaskPanel tskLihatTransaksi;
        private ModernUI.ModernButton modernButton1;
    }
}

