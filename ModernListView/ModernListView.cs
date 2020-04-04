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
    public partial class ModernListView: UserControl
    {
        public List<Item> Items = new List<Item>();
        public void AddItem(Item item)
        {
            Items.Add(item);
            ModernButton Lb = ListButton(item);
            this.Controls.Add(Lb);
            Lb.Description = item.Description;
            Lb.Parent = LayoutHelper;
            LayoutHelper.SetRow(Lb, Items.Count);
            Lb.BringToFront();
            UpdateLayout();
        }

        private ModernButton ListButton(Item item)
        {
            ModernButton button = new ModernButton
            {
                Text = item.Text,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat
            };
            button.FlatAppearance.BorderSize = 0;
            button.Padding = new Padding(0);
            button.Margin = new Padding(0);
            return button;
        }

        private void UpdateLayout()
        {
            int n = Items.Count;
            LayoutHelper.RowCount = n + 1;
            LayoutHelper.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 50 });
        }

        public Item GetItem(string Name)
        {
            Item result = null;
            foreach (Item item in Items)
            {
                if (item.Name == Name)
                {
                    result = item;
                }
            }
            if (result is null)
            {
                throw new Exception("Item with name {0} not found.");
            }
            return result;
        }
        public ModernListView()
        {
            InitializeComponent();
        }
    }
    public class Item
    {
        public string Name, Text, Description, ExtraDescription;
        public Image Image;

        public Item(string ItemName, string ItemText = "", string ItemDescription = "", string ItemExtraDescription = "")
        {
            Name = ItemName;
            Text = ItemText;
            Description = ItemDescription;
            ExtraDescription = ItemExtraDescription;
        }

        public void SetImage(Image image)
        {
            Image = image;
        }
    }
}