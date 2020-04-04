using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModernUI;

namespace ModernUI
{
    public partial class ModernButton: Button
    {
        public enum IndicatorLocations { Left, Right, Both }
        public IndicatorLocations IndicatorLocation { get; set; }
        public CheckChangeTypes CheckChangeType { get; set; }
        private bool checkedState;
        public Styles Style { get { return style; } set { style = value; SetStyle(); } }
        private Styles style;
        public TaskPanel Task { get; set; }
        public enum Styles
        {
            Default, Button, NavButton
        }

        public Tasks Tasks { get; set; }
    
        public enum Themes
        {
            Dark, Light, Custom
        }
        public bool HasStates { get; set; }
        public bool CheckedState { get { return checkedState; } set { checkedState = value; this.Invalidate(); } }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExtraDescription { get; set; }
        public bool ActivateTaskOnClick { get; set; }
        Rectangle LeftCheckedIndicator = new Rectangle();
        Rectangle RightCheckedIndicator = new Rectangle();
        public ModernButton()
        {
            InitializeComponent();
            this.Height = 32;
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.White;
            BackColor = Color.Black;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 53, 53);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 76, 76);
            HasStates = false;
            CheckedState = false;
            CheckChangeType = CheckChangeTypes.AlwaysSwitchToTrue;
            IndicatorLocation = IndicatorLocations.Left;
            Style = Styles.Button;
            SetStyle();
            Task = null;
            ActivateTaskOnClick = true;
            this.Font = new Font(new FontFamily("Segoe UI"), 11.25f, FontStyle.Regular);
        }

        private void SetStyle()
        {
            if (Style == Styles.Button)
            {
                this.BackColor = Color.FromArgb(70, 70, 70);
                this.FlatAppearance.MouseDownBackColor = Color.FromArgb(125, 125, 125);
                this.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            }
            else if (Style == Styles.NavButton)
            {
                this.BackColor = Color.FromArgb(31, 31, 31);
                this.FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 76, 76);
                this.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 53, 53);
            }
        }

        private void CreateBorder(PaintEventArgs e)
        {
            Pen pen = new Pen(new SolidBrush(Color.FromArgb(154, 154, 154)), 2f);
            e.Graphics.DrawLine(pen, 0, 1, this.Width, 1);
            e.Graphics.DrawLine(pen, 1, 1, 1, this.Height);
            e.Graphics.DrawLine(pen, this.Width - 1, 1, this.Width - 1, this.Height);
            e.Graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
        }
        private bool IsHovered;
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (Style == Styles.Button)
            {
                IsHovered = true;
            }
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            IsHovered = false;
            this.Invalidate();
        }
        public enum CheckChangeTypes
        {
            SwitchesState,
            AlwaysSwitchToTrue
        }
        
        private void ActivateButton()
        {
            if (HasStates)
            {
                if (CheckChangeType == CheckChangeTypes.AlwaysSwitchToTrue)
                {
                    CheckedState = true;
                }
                else
                {
                    CheckedState = !CheckedState;
                }
            }
            this.Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ActivateButton();
            ActivateTask();
        }

        private void ActivateTask()
        {
            Tasks.Hide();
            if (!(Task is null))
            {
                Task.Show();
            }
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            ActivateButton();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (CheckedState)
            {
                LeftCheckedIndicator.X = 0;
                LeftCheckedIndicator.Width = 3;
                LeftCheckedIndicator.Y = 10;
                LeftCheckedIndicator.Height = this.Height - 20;
                RightCheckedIndicator.X = this.Width - 4;
                RightCheckedIndicator.Width = 4;
                RightCheckedIndicator.Y = 10;
                RightCheckedIndicator.Height = this.Height - 20;
                if (IndicatorLocation == IndicatorLocations.Left)
                    pevent.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 52, 152, 219)), LeftCheckedIndicator);
                else if (IndicatorLocation == IndicatorLocations.Right)
                    pevent.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 52, 152, 219)), RightCheckedIndicator);
                else
                {
                    pevent.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 52, 152, 219)), LeftCheckedIndicator);
                    pevent.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 52, 152, 219)), RightCheckedIndicator);
                }
            }
            if (IsHovered)
            {
                CreateBorder(pevent);
            }
            pevent.Graphics.DrawString(Description, new Font(Parent.Font.FontFamily, 11.25f, FontStyle.Regular), new SolidBrush(ForeColor), 4, 4);
        }
    }
}
