using System;

namespace ModernUI
{
    partial class ModernMessageBox
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.NavInner = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LayoutHelper = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pctIcon = new System.Windows.Forms.PictureBox();
            this.btn4 = new ModernUI.ModernButton();
            this.btn3 = new ModernUI.ModernButton();
            this.btn2 = new ModernUI.ModernButton();
            this.btn1 = new ModernUI.ModernButton();
            this.NavInner.SuspendLayout();
            this.LayoutHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBar.Location = new System.Drawing.Point(222, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(239, 31);
            this.TitleBar.TabIndex = 5;
            // 
            // NavInner
            // 
            this.NavInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.NavInner.Controls.Add(this.lblTitle);
            this.NavInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavInner.Location = new System.Drawing.Point(0, 0);
            this.NavInner.Margin = new System.Windows.Forms.Padding(0);
            this.NavInner.Name = "NavInner";
            this.NavInner.Size = new System.Drawing.Size(222, 31);
            this.NavInner.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(222, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LayoutHelper
            // 
            this.LayoutHelper.ColumnCount = 2;
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutHelper.Controls.Add(this.NavInner, 0, 0);
            this.LayoutHelper.Controls.Add(this.TitleBar, 1, 0);
            this.LayoutHelper.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutHelper.Location = new System.Drawing.Point(1, 1);
            this.LayoutHelper.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutHelper.Name = "LayoutHelper";
            this.LayoutHelper.RowCount = 2;
            this.LayoutHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.LayoutHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutHelper.Size = new System.Drawing.Size(461, 30);
            this.LayoutHelper.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMessage.Location = new System.Drawing.Point(72, 46);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(5);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(381, 62);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "This is message sample\r\n\r\nasd";
            // 
            // pctIcon
            // 
            this.pctIcon.Location = new System.Drawing.Point(19, 49);
            this.pctIcon.Margin = new System.Windows.Forms.Padding(5);
            this.pctIcon.Name = "pctIcon";
            this.pctIcon.Size = new System.Drawing.Size(32, 32);
            this.pctIcon.TabIndex = 5;
            this.pctIcon.TabStop = false;
            // 
            // btn4
            // 
            this.btn4.ActivateTaskOnClick = false;
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn4.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.btn4.CheckedState = false;
            this.btn4.Description = null;
            this.btn4.ExtraDescription = null;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.HasStates = false;
            this.btn4.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.btn4.Location = new System.Drawing.Point(61, 114);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(92, 32);
            this.btn4.Style = ModernUI.ModernButton.Styles.Button;
            this.btn4.TabIndex = 9;
            this.btn4.Task = null;
            this.btn4.Tasks = null;
            this.btn4.Text = "Ignore";
            this.btn4.Title = null;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.ActivateTaskOnClick = false;
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn3.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.btn3.CheckedState = false;
            this.btn3.Description = null;
            this.btn3.ExtraDescription = null;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.HasStates = false;
            this.btn3.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.btn3.Location = new System.Drawing.Point(161, 115);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(92, 32);
            this.btn3.Style = ModernUI.ModernButton.Styles.Button;
            this.btn3.TabIndex = 8;
            this.btn3.Task = null;
            this.btn3.Tasks = null;
            this.btn3.Text = "Ignore";
            this.btn3.Title = null;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.ActivateTaskOnClick = false;
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn2.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.btn2.CheckedState = false;
            this.btn2.Description = null;
            this.btn2.ExtraDescription = null;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.HasStates = false;
            this.btn2.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.btn2.Location = new System.Drawing.Point(261, 115);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(92, 32);
            this.btn2.Style = ModernUI.ModernButton.Styles.Button;
            this.btn2.TabIndex = 7;
            this.btn2.Task = null;
            this.btn2.Tasks = null;
            this.btn2.Text = "Ignore";
            this.btn2.Title = null;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.ActivateTaskOnClick = false;
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn1.CheckChangeType = ModernUI.ModernButton.CheckChangeTypes.AlwaysSwitchToTrue;
            this.btn1.CheckedState = false;
            this.btn1.Description = null;
            this.btn1.ExtraDescription = null;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.HasStates = false;
            this.btn1.IndicatorLocation = ModernUI.ModernButton.IndicatorLocations.Left;
            this.btn1.Location = new System.Drawing.Point(361, 115);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(92, 32);
            this.btn1.Style = ModernUI.ModernButton.Styles.Button;
            this.btn1.TabIndex = 6;
            this.btn1.Task = null;
            this.btn1.Tasks = null;
            this.btn1.Text = "Ignore";
            this.btn1.Title = null;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ModernMessageBox
            // 
            this.AcceptButton = this.btn2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(463, 157);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pctIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.LayoutHelper);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ModernMessageBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.NavInner.ResumeLayout(false);
            this.LayoutHelper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private void ChangeText(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel NavInner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel LayoutHelper;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pctIcon;
        private ModernButton btn1;
        private ModernButton btn2;
        private ModernButton btn3;
        private ModernButton btn4;
    }
}

