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
    public partial class ModernForm : Form
    {
        bool isDoubleClicked = false;
        int movX;
        int movY;
        bool isMoving;
        static DockerView Dck = new DockerView();
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
                movX = e.X + ((Label)(sender)).Left + Back.Width;
            }
            movY = e.Y;
        }

        private void TitlebarMoving(object sender, MouseEventArgs e)
        {
            // Assign this method to Mouse_Move event of that Form or Panel
            if (isMoving)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    btnMaximize.PerformClick();
                    movX = Width / 2;
                }
                else
                {
                    this.Location = new Point(MousePosition.X - movX, MousePosition.Y - movY);
                }
                if (WindowState != FormWindowState.Maximized)
                {

                    if (Cursor.Position.Y == Screen.FromHandle(this.Handle).WorkingArea.Top && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Left)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                        Dck.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                    }
                    else if (Cursor.Position.Y > Screen.FromHandle(this.Handle).WorkingArea.Top + Screen.FromHandle(this.Handle).WorkingArea.Height - 1 && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Left)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top + Screen.FromHandle(this.Handle).WorkingArea.Height / 2);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                        Dck.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                    }
                    else if (Cursor.Position.Y > Screen.FromHandle(this.Handle).WorkingArea.Top + Screen.FromHandle(this.Handle).WorkingArea.Height - 1 && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Width - 1)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Top + Screen.FromHandle(this.Handle).WorkingArea.Height / 2);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                        Dck.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                    }
                    else if (Cursor.Position.Y == Screen.FromHandle(this.Handle).WorkingArea.Top && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Width - 1)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Top);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                        Dck.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                    }
                    else if (Cursor.Position.Y == Screen.FromHandle(this.Handle).WorkingArea.Top)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width;
                        Dck.Height= Screen.FromHandle(this.Handle).WorkingArea.Height;
                    }
                    else if (Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Left)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                        Dck.Height = Screen.FromHandle(this.Handle).WorkingArea.Height;
                    }
                    else if (Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Width - 1)
                    {
                        Dck.Show();
                        Dck.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2, 0);
                        Dck.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                        Dck.Height = Screen.FromHandle(this.Handle).WorkingArea.Height;
                    }
                    else
                    {
                        Dck.Visible = false;
                    }
                }
            }
        }

        private void TitlebarReleased(object sender, MouseEventArgs e)
        {
            // Assign this method to Mouse_Up event of Form or Panel.
            isMoving = false;
            if (WindowState != FormWindowState.Maximized)
            {
                if (Cursor.Position.Y == Screen.FromHandle(this.Handle).WorkingArea.Top && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Left)
                {
                    this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top);
                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                }
                else if (Cursor.Position.Y > Screen.FromHandle(this.Handle).WorkingArea.Height - 1 && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Left)
                {
                    this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top + Screen.FromHandle(this.Handle).WorkingArea.Height / 2);
                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                }
                else if (Cursor.Position.Y > Screen.FromHandle(this.Handle).WorkingArea.Height - 1 && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Width - 1)
                {
                    this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Height / 2);
                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                }
                else if (Cursor.Position.Y == Screen.FromHandle(this.Handle).WorkingArea.Top && Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Width - 1)
                {
                    this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Top);
                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height / 2;
                }
                else if (Cursor.Position.Y == Screen.FromHandle(this.Handle).WorkingArea.Top)
                {
                    if (isDoubleClicked == false)
                    {
                        btnMaximize.PerformClick();
                    }
                    else
                    {
                        isDoubleClicked = false;
                    }
                }
                else if (Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Left)
                {
                    this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Left, Screen.FromHandle(this.Handle).WorkingArea.Top);
                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height;
                }
                else if (Cursor.Position.X == Screen.FromHandle(this.Handle).WorkingArea.Width - 1)
                {
                    this.Location = new Point(Screen.FromHandle(this.Handle).WorkingArea.Width/2, Screen.FromHandle(this.Handle).WorkingArea.Top);
                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width / 2;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height;
                }
            }
            if (Dck.Visible == true)
            {
                Dck.Visible = false;
            }


            if (Top < Screen.FromHandle(this.Handle).WorkingArea.Top)
            {
                Top = Screen.FromHandle(this.Handle).WorkingArea.Top;
            }

        }
        public ModernForm()
        {
            MaximumSize = Screen.FromControl(this).WorkingArea.Size;
            SizeChanged += ChangeMaxImages;            
            InitializeComponent();
            TitleBar.MouseDoubleClick += Maximize_Restore;
            TextLabel.MouseDoubleClick += Maximize_Restore;
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            TitleBar.MouseDown += new MouseEventHandler(TitlebarPressed);
            TitleBar.MouseMove += new MouseEventHandler(TitlebarMoving);
            TitleBar.MouseUp += new MouseEventHandler(TitlebarReleased);
            TextLabel.MouseDown += new MouseEventHandler(TitlebarPressed);
            TextLabel.MouseMove += new MouseEventHandler(TitlebarMoving);
            TextLabel.MouseUp += new MouseEventHandler(TitlebarReleased);
            Tasks.LoadTasks();
            Load += MainForm_Load;
            //Task.Run(Log);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //borderRadius1.TargetControl = toggleButton1;
            //borderRadius1.CornerRadius = 20;
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

        void Log()
        {
            while(true)
            System.Diagnostics.Debug.WriteLine($"{movX}, {movY}");
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            SetNavSelection((ModernButton)sender);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (TopRect.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (LeftRect.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (RightRect.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (BottomRect.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNavSelection((ModernButton)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetNavSelection((ModernButton)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNavSelection((ModernButton)sender);
        }

        private void modernCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }


        private void Maximize_Restore(object sender, MouseEventArgs e)
        {
            isDoubleClicked = true;
            btnMaximize.PerformClick();
        }

        private void TitleBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asd");
        }

        private void ChangeMaxImages(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.BackgroundImage = Properties.Resources.Restore;
            }
            else
            {
                btnMaximize.BackgroundImage = Properties.Resources.Maximize;
            }
        }

        private void SetNavSelection(ModernButton SelectedButton)
        {
            foreach (Control control in NavPanel.Controls)
            {
                if (control is ModernButton)
                {
                    ((ModernButton)control).CheckedState = false;
                }
            }
            SelectedButton.CheckedState = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Padding = new Padding(2);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                Padding = new Padding(0);
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
