using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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
            if (count < 3)
            {
                MessageBox.Show("必须选择三个科目！");
            }
            else if (count > 3)
            {
                MessageBox.Show("最多选择三个科目！");
            }
            else
            {
                List<String> subjects = new List<String>();
                if (phy.Checked)
                    subjects.Add("物理");
                if (ch.Checked)
                    subjects.Add("化学");
                if (bio.Checked)
                    subjects.Add("生物");
                if (pol.Checked)
                    subjects.Add("政治");
                if (his.Checked)
                    subjects.Add("历史");
                if (geo.Checked)
                    subjects.Add("地理");
                ApplicationForm.subjectselectform.Hide();
                Program.mainform.setLable(subjects[0], subjects[1], subjects[2]);
            }
        }
    }
}
