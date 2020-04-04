using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Diagnostics;

namespace ModernUI
{
    public partial class ToggleButton: UserControl
    {
        
        public void Activate()
        {
            this.State = ToggleButtonStates.Active;
        }

        public void Deactivate()
        {
            this.State = ToggleButtonStates.Inactive;
        }

        public bool IsActive()
        {
            return State == ToggleButtonStates.Active;
        }

        public bool IsInactive()
        {
            return State == ToggleButtonStates.Inactive;
        }

        
        static Color InactiveColor = Color.FromArgb(215, 215, 215);
        static Color ActiveColor = Color.FromArgb(255, 52, 152, 219);

        Rectangle LRect = new Rectangle(new Point(6, 5), new Size(10, 10));
        Rectangle RRect = new Rectangle(new Point(27, 5), new Size(10, 10));
        Rectangle RealRect = new Rectangle(new Point(27, 5), new Size(10, 10));
        RectangleF Rect = new RectangleF(0, 0, 44, 22);
        Pen pen = new Pen(InactiveColor, 4);
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pen.Alignment = PenAlignment.Center;
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), cRect);
            pen.Color = InactiveColor;

            if (IsActive())
            {
                e.Graphics.FillEllipse(new SolidBrush(ActiveColor), RealRect);
            }
            else
            {
                e.Graphics.FillEllipse(new SolidBrush(InactiveColor), RealRect);
            }
            e.Graphics.DrawLine(pen, 0, 0, 43, 0);
            e.Graphics.DrawLine(pen, 0, 0, 0, 21);
            e.Graphics.DrawLine(pen, 43, 0, 43, 21);
            e.Graphics.DrawLine(pen, 0, 21, 43, 21);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Space)
            {
                if (IsActive())
                {
                    Deactivate();
                }
                else
                {
                    Activate();
                }
            }
        }

        static Rectangle cRect = new Rectangle(4, 4, 36, 14);
        private void AnimateToLeft()
        {
            Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush brush = new SolidBrush(InactiveColor);
            g.FillRectangle(black, Rect);
            g.DrawLine(pen, 0, 0, 43, 0);
            g.DrawLine(pen, 0, 0, 0, 21);
            g.DrawLine(pen, 43, 0, 43, 21);
            g.DrawLine(pen, 0, 21, 43, 21);
            Task.Run(() =>
            {
                while (RealRect.X > LRect.X)
                {
                    RealRect.X -= 1;
                    g.FillRectangle(black, cRect);
                    g.FillEllipse(brush, RealRect);
                    Thread.Sleep(7);
                }
            }).Wait();
        }
    private void AnimateToRight()
    {
            Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush brush = new SolidBrush(ActiveColor);
            g.FillRectangle(black, Rect);
            g.DrawLine(pen, 0, 0, 43, 0);
            g.DrawLine(pen, 0, 0, 0, 21);
            g.DrawLine(pen, 43, 0, 43, 21);
            g.DrawLine(pen, 0, 21, 43, 21);
            Task.Run(() =>
            {
                while (RealRect.X < RRect.X)
                {
                    RealRect.X += 1;
                    g.FillRectangle(black, cRect);
                    g.FillEllipse(brush, RealRect);
                    Thread.Sleep(7);
                }
            }).Wait();
        }

        public enum ToggleButtonStates
        {
            Active, Inactive
        }

        ToggleButtonStates state;
        public ToggleButtonStates State { 
            get {
                return state;
            } 
            set {
                state = value;
                if (value == ToggleButtonStates.Active)
                {
                    AnimateToRight();
                }
                else
                {
                    AnimateToLeft();
                }
            }
        }


        public ToggleButton()
        {
            InitializeComponent();
            this.Click += ToggleButton_Click;
            this.Size = new Size(44, 22);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(44, 22);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                Deactivate();
            }
            else
            {
                Activate();
            }
        }
    }
}
