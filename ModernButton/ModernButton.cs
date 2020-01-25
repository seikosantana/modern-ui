using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class ModernButton: Button
    {
        private string title, description, extraDescription;
        public ModernButton()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.White;
            BackColor = Color.Black;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 53, 53);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 76, 76);
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string ExtraDescription
        {
            get { return extraDescription; }
            set { extraDescription = value; }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.DrawString(description, new Font(Parent.Font.FontFamily, 11.25f, FontStyle.Regular), new SolidBrush(ForeColor), 4, 4);
            
        }
    }
}
