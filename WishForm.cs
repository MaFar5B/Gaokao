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

        private void Confirm_Wish(object sender, EventArgs e)
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
            ApplicationForm.wishform.Hide();
        }
    }
}
