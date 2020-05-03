using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using ModernUI;

namespace ModernUI
{
    public partial class ModernMessageBox : Form
    {
        #region FormFeatures
        private const int
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17;

        const int _ = 10;

        Rectangle TopRect { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle LeftRect { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle BottomRect { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle RightRect { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        public void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        public ModernMessageBox()
        {
            MaximumSize = Screen.FromControl(this).WorkingArea.Size;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            TitleBar.MouseDown += new MouseEventHandler(TitlebarPressed);
            TitleBar.MouseMove += new MouseEventHandler(TitlebarMoving);
            TitleBar.MouseUp += new MouseEventHandler(TitlebarReleased);
            lblTitle.MouseDown += new MouseEventHandler(TitlebarPressed);
            lblTitle.MouseMove += new MouseEventHandler(TitlebarMoving);
            lblTitle.MouseUp += new MouseEventHandler(TitlebarReleased);
            Load += ModernMessageBox_Load;
        }
        int movX;
        int movY;
        bool isMoving;
        private void TitlebarPressed(object sender, MouseEventArgs e)
        {
            // Assign this method to mouse_Down event of Form or Panel,whatever you want
            isMoving = true;
            if (sender is Panel)
            {
                movX = e.X + ((Panel)(sender)).Left;
            }
            else if (sender is Label)
            {
                movX = e.X + ((Label)(sender)).Left;
            }
            movY = e.Y;
        }

        private void TitlebarReleased(object sender, MouseEventArgs e)
        {
            // Assign this method to Mouse_Up event of Form or Panel.
            isMoving = false;
        }
        private void TitlebarMoving(object sender, MouseEventArgs e)
        {
            // Assign this method to Mouse_Move event of that Form or Panel
            if (isMoving)
            {
                this.Location = new Point(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 52, 152, 219));
            e.Graphics.DrawLine(pen, 0, 0, 0, Height);
            e.Graphics.DrawLine(pen, Width - 1, 0, Width - 1, this.Height);
            e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);
            e.Graphics.DrawLine(pen, 0, 0, Width, 0);
            base.OnPaint(e);
        }
        #endregion

        string Title = "Message", Message = "", Button1Text = "", Button2Text = "", Button3Text = "", Button4Text = "";
        new Bitmap Icon = new Bitmap(1, 1);
        
        
        DialogResults _dialogResult
        {
            set
            {
                dialogResult = value;
                this.Hide();
            }
            get
            {
                return dialogResult;
            }
        }
        DialogResults dialogResult;
        public enum DialogResults
        {
            Button1,
            Button2,
            Button3,
            Button4
        }

        public new DialogResults DialogResult
        {
            get
            {
                return dialogResult;
            }
        }

        public DialogResults Show(string message)
        {
            Message = message;
            Button1Text = "&OK";
            ShowButtons(ButtonCount.One);
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, Bitmap icon)
        {
            Message = message;
            Button1Text = "&OK";
            ShowButtons(ButtonCount.One);
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title)
        {
            Message = message;
            Title = title;
            Button1Text = "&OK";
            ShowButtons(ButtonCount.One);
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, Bitmap icon)
        {
            Message = message;
            Title = title;
            Button1Text = "&OK";
            ShowButtons(ButtonCount.One);
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            ShowButtons(ButtonCount.One);
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text, Bitmap icon)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            ShowButtons(ButtonCount.One);
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            _dialogResult = DialogResults.Button1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _dialogResult = DialogResults.Button2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _dialogResult = DialogResults.Button3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            _dialogResult = DialogResults.Button4;
        }

        public DialogResults Show(string message, string title, string button1Text, string button2Text)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            Button2Text = button2Text;
            ShowButtons(ButtonCount.Two);
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text, string button2Text, Bitmap icon)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            Button2Text = button2Text;
            ShowButtons(ButtonCount.Two);
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text, string button2Text, string button3Text)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            Button2Text = button2Text;
            Button3Text = button3Text;
            ShowButtons(ButtonCount.Three);
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text, string button2Text, string button3Text, Bitmap icon)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            Button2Text = button2Text;
            Button3Text = button3Text;
            ShowButtons(ButtonCount.Three);
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text, string button2Text, string button3Text, string button4Text)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            Button2Text = button2Text;
            Button3Text = button3Text;
            Button4Text = button4Text;
            ShowButtons(ButtonCount.Four);
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, string title, string button1Text, string button2Text, string button3Text, string button4Text, Bitmap icon)
        {
            Message = message;
            Title = title;
            Button1Text = button1Text;
            Button2Text = button2Text;
            Button3Text = button3Text;
            Button4Text = button4Text;
            ShowButtons(ButtonCount.Four);
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        private void SetStyleFromButtons(MessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    Button1Text = "&OK";
                    ShowButtons(ButtonCount.One);
                    break;
                case MessageBoxButtons.OKCancel:
                    Button1Text = "&Cancel";
                    Button2Text = "&OK";
                    ShowButtons(ButtonCount.Two);
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    Button1Text = "&Ignore";
                    Button2Text = "&Retry";
                    Button3Text = "&Abort";
                    ShowButtons(ButtonCount.Three);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    Button1Text = "&Cancel";
                    Button2Text = "&No";
                    Button3Text = "&Yes";
                    ShowButtons(ButtonCount.Three);
                    break;
                case MessageBoxButtons.YesNo:
                    Button1Text = "&No";
                    Button2Text = "&Yes";
                    ShowButtons(ButtonCount.Two);
                    break;
                case MessageBoxButtons.RetryCancel:
                    Button1Text = "&Cancel";
                    Button2Text = "&Retry";
                    ShowButtons(ButtonCount.Two);
                    break;
                default:
                    break;
            }

        }

        public DialogResults Show(string message, MessageBoxButtons buttons)
        {
            SetStyleFromButtons(buttons);
            Message = message;
            ShowDialog();
            return dialogResult;
        }

        public DialogResults Show(string message, MessageBoxButtons buttons, Bitmap icon)
        {
            SetStyleFromButtons(buttons);
            Message = message;
            Icon = icon;
            ShowDialog();
            return dialogResult;
        }

        private enum ButtonCount
        {
            One = 1, Two = 2, Three = 3, Four = 4
        }

        private void ShowButtons(ButtonCount count)
        {
            switch (count)
            {
                case ButtonCount.One:
                    btn2.Visible = false;
                    btn3.Visible = false;
                    btn4.Visible = false;
                    AcceptButton = btn1;
                    break;
                case ButtonCount.Two:
                    btn3.Visible = false;
                    btn4.Visible = false;
                    AcceptButton = btn2;
                    break;
                case ButtonCount.Three:
                    btn4.Visible = false;
                    AcceptButton = btn2;
                    break;
                case ButtonCount.Four:
                    btn4.Visible = false;
                    AcceptButton = btn2;
                    break;
                default:
                    break;
            }
        }

        

        private void ModernMessageBox_Load(object sender, EventArgs e)
        {
            btn1.Text = Button1Text;
            btn2.Text = Button2Text;
            btn3.Text = Button3Text;
            btn4.Text = Button4Text;
            lblMessage.Text = Message;
            lblTitle.Text = Title;
            pctIcon.Image = Icon;
        }

    }
}
