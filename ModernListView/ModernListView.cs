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

        public delegate void SelectedItemChangedHandler(object sender, ModernListViewItemChangedArgs e);
        public event SelectedItemChangedHandler SelectedItemChanged;


        public List<Item> Items = new List<Item>();
        
        public Item SelectedItem { get; set; }
        public void AddItem(Item item)
        {

            Items.Add(item);
            ModernButton Lb = ListButton(item);
            this.Controls.Add(Lb);
            Lb.Description = item.Description;
            Lb.TextAlign = ContentAlignment.BottomLeft;
            Lb.Parent = LayoutHelper;
            LayoutHelper.SetRow(Lb, Items.Count - 1);
            LayoutHelper.BringToFront();
            Lb.BringToFront();
            AddRows();
        }

        public void RemoveRow()
        {
            LayoutHelper.RowStyles[Items.Count].Height = 50; 
        }
        private ModernButton ListButton(Item item)
        {
            ModernButton button = new ModernButton
            {
                Text = item.Text,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent
            };
            button.FlatAppearance.BorderSize = 0;
            button.Padding = new Padding(0);
            button.Margin = new Padding(0);
            button.Tag = item;
            item.RelatedButton = button;
            button.Click += SetSelectedItem;
            return button;
        }

        private void SetSelectedItem(object sender, EventArgs e)
        {
            var btn = (ModernButton)sender;
            btn.BackColor = Color.FromArgb(70, 70, 70);
            ModernListViewItemChangedArgs args = new ModernListViewItemChangedArgs();
            args.CurrentItem = (Item)btn.Tag;
            if (!(SelectedItem is null) && SelectedItem != btn.Tag)
            {
                args.PreviousItem = SelectedItem;
                SelectedItem.RelatedButton.BackColor = Color.Transparent;
            }
            SelectedItem = (Item)btn.Tag;
            SelectedItemChanged?.Invoke(this, args);
        }

        public void RemoveItem(Item item)
        {
            int n = LayoutHelper.GetRow(item.RelatedButton);
            item.RelatedButton.Dispose();
            Items.Remove(item);
            //FillEmptyRowAt(n);

            SelectedItem = null;
            ModernListViewItemChangedArgs args = new ModernListViewItemChangedArgs();
            args.CurrentItem = null;
            args.PreviousItem = null;
            SelectedItemChanged?.Invoke(this, args);
        }

        private void FillEmptyRowAt(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                LayoutHelper.SetRow(Items[i].RelatedButton, i - 1);
            }
            LayoutHelper.RowCount = Items.Count + 1;
        }

        private void AddRows()
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

        public ModernButton RelatedButton { get; set; }
    }
    public class ModernListViewItemChangedArgs : EventArgs
    {
        public Item PreviousItem { get; set; }
        public Item CurrentItem { get; set; }

    }
}