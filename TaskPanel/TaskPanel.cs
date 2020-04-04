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
    public partial class TaskPanel: Panel
    {
        private Label TitleLabel;
        public string Title { get { return TitleLabel.Text; } set { TitleLabel.Text = value; } }
        public Panel BottomPanel = new Panel();
        public int BottomPanelHeight
        {
            get
            {
                return BottomPanel.Height;
            }
            set
            {
                BottomPanel.Height = value;
            }
        }
        public bool HasBottomPanel { 
            set { 
                if (value)
                {
                    this.Controls.Add(BottomPanel);
                }
                else
                {
                    this.Controls.Remove(BottomPanel);
                }
            } 
            get
            {
                return this.Controls.Contains(BottomPanel);
            }
        }
        public TaskPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Panel TopPanel = new Panel();
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Height = 80;
            this.Controls.Add(TopPanel);
            TitleLabel = new Label();
            TitleLabel.Font = new Font(new FontFamily("Segoe UI Semilight"), 24);
            TitleLabel.Text = "";
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.AutoSize = false;
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            TitleLabel.Padding = new Padding(16, 0, 0, 0);
            TopPanel.Controls.Add(TitleLabel);
            BottomPanel = new Panel();
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Height = 80;
            HasBottomPanel = false;
        }

        public TaskPanel(string Title)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Panel TopPanel = new Panel();
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Height = 80;
            this.Controls.Add(TopPanel);
            TitleLabel = new Label();
            TitleLabel.Font = new Font(new FontFamily("Segoe UI"), 22);
            TitleLabel.Text = "";
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.AutoSize = false;
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            TitleLabel.Padding = new Padding(16, 0, 0, 0);
            TopPanel.Controls.Add(TitleLabel);
            BottomPanel = new Panel();
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Height = 80;
            HasBottomPanel = false;
            TitleLabel.Text = Title;
        }

        public TaskPanel(bool WithBottomPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Panel TopPanel = new Panel();
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Height = 80;
            this.Controls.Add(TopPanel);
            TitleLabel = new Label();
            TitleLabel.Font = new Font(new FontFamily("Segoe UI"), 22);
            TitleLabel.Text = "";
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.AutoSize = false;
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            TitleLabel.Padding = new Padding(16, 0, 0, 0);
            TopPanel.Controls.Add(TitleLabel);
            BottomPanel = new Panel();
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Height = 80;
            HasBottomPanel = WithBottomPanel;
        }

        public TaskPanel(string Title, bool WithBottomPanel)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Panel TopPanel = new Panel();
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Height = 80;
            this.Controls.Add(TopPanel);
            TitleLabel = new Label();
            TitleLabel.Font = new Font(new FontFamily("Segoe UI"), 22);
            TitleLabel.Text = "";
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.AutoSize = false;
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            TitleLabel.Padding = new Padding(16, 0, 0, 0);
            TopPanel.Controls.Add(TitleLabel);
            BottomPanel = new Panel();
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Height = 80;
            HasBottomPanel = WithBottomPanel;
            TitleLabel.Text = Title;
        }
        

    }
}
