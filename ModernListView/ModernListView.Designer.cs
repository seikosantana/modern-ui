namespace ModernUI
{
    partial class ModernListView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LayoutHelper = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // LayoutHelper
            // 
            this.LayoutHelper.AutoScroll = true;
            this.LayoutHelper.AutoSize = true;
            this.LayoutHelper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutHelper.ColumnCount = 1;
            this.LayoutHelper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutHelper.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LayoutHelper.Location = new System.Drawing.Point(0, 0);
            this.LayoutHelper.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutHelper.Name = "LayoutHelper";
            this.LayoutHelper.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LayoutHelper.RowCount = 2;
            this.LayoutHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.LayoutHelper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.LayoutHelper.Size = new System.Drawing.Size(421, 284);
            this.LayoutHelper.TabIndex = 0;
            // 
            // ModernListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.LayoutHelper);
            this.Name = "ModernListView";
            this.Size = new System.Drawing.Size(421, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutHelper;
    }
}
