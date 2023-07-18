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
    public partial class SubjectForm : Form
    {
        public static int count = 0;

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void confirmsubject(object sender, EventArgs e)
        {
            count = Convert.ToInt32(phy.Checked) + Convert.ToInt32(ch.Checked) + Convert.ToInt32(bio.Checked) + Convert.ToInt32(pol.Checked) + Convert.ToInt32(his.Checked) + Convert.ToInt32(geo.Checked);
            if(count < 3)
            {
                MessageBox.Show("必须选择三个科目！");
            } else if(count > 3)
            {
                MessageBox.Show("最多选择三个科目！");
            } else
            {
                ApplicationForm.subjectselectform.Hide();
            }
        }
    }
}
