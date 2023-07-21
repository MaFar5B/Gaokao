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

        private void Changed1(object sender, EventArgs e)
        {
            if (this.All1.Checked)
            {
                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                {
                    this.checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                {
                    this.checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void Changed2(object sender, EventArgs e)
        {
            if (this.All2.Checked)
            {
                for (int i = 0; i < this.checkedListBox2.Items.Count; i++)
                {
                    this.checkedListBox2.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < this.checkedListBox2.Items.Count; i++)
                {
                    this.checkedListBox2.SetItemChecked(i, false);
                }
            }
        }

        private void Changed3(object sender, EventArgs e)
        {
            if (this.All3.Checked)
            {
                for (int i = 0; i < this.checkedListBox3.Items.Count; i++)
                {
                    this.checkedListBox3.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < this.checkedListBox3.Items.Count; i++)
                {
                    this.checkedListBox3.SetItemChecked(i, false);
                }
            }
        }

        private void Changed4(object sender, EventArgs e)
        {
            if (this.All4.Checked)
            {
                for (int i = 0; i < this.checkedListBox4.Items.Count; i++)
                {
                    this.checkedListBox4.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < this.checkedListBox4.Items.Count; i++)
                {
                    this.checkedListBox4.SetItemChecked(i, false);
                }
            }
        }

        private void Changed5(object sender, EventArgs e)
        {
            if (this.All5.Checked)
            {
                for (int i = 0; i < this.checkedListBox5.Items.Count; i++)
                {
                    this.checkedListBox5.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < this.checkedListBox5.Items.Count; i++)
                {
                    this.checkedListBox5.SetItemChecked(i, false);
                }
            }
        }
    }
}
