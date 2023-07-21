using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaokao
{
    public partial class WishForm : Form
    {
        public static List<String> WishList = new List<String>();
        public WishForm()
        {
            InitializeComponent();
        }

        public void full_wished()
        {
            foreach (var item in checkedListBox1.Items)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox2.Items)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox3.Items)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox4.Items)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox5.Items)
            {
                WishList.Add(item.ToString());
            }
        }
        private void Confirm_Wish(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox2.CheckedItems)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox3.CheckedItems)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox4.CheckedItems)
            {
                WishList.Add(item.ToString());
            }
            foreach (var item in checkedListBox5.CheckedItems)
            {
                WishList.Add(item.ToString());
            }
            if (WishList.Count == 0)
            {
                this.full_wished();
            }
            ApplicationForm.wishform.Hide();
        }

        private void ItemCheck1(object sender, ItemCheckEventArgs e)
        {
            ((CheckedListBox)sender).SelectedItem = null;
        }

        private void ItemCheck2(object sender, ItemCheckEventArgs e)
        {
            ((CheckedListBox)sender).SelectedItem = null;
        }

        private void ItemCheck3(object sender, ItemCheckEventArgs e)
        {
            ((CheckedListBox)sender).SelectedItem = null;
        }

        private void ItemCheck4(object sender, ItemCheckEventArgs e)
        {
            ((CheckedListBox)sender).SelectedItem = null;
        }

        private void ItemCheck5(object sender, ItemCheckEventArgs e)
        {
            ((CheckedListBox)sender).SelectedItem = null;
        }
    }
}
