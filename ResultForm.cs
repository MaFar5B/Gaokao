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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();

        }

        private void high_risk_click(object sender, EventArgs e)
        {
            Program.schoolForm_high.risk = "high";
            Program.schoolForm_high.setDeafault();
            if (Program.high_risk.Count == 0)
            {
                MessageBox.Show("暂无信息！");
            }
            else
            {
                Program.schoolForm_high.ShowDialog();
            }
        }

        private void middle_risk_click(object sender, EventArgs e)
        {
            Program.schoolForm_middle.risk = "middle";
            Program.schoolForm_middle.setDeafault();
            if (Program.middle_risk.Count == 0)
            {
                MessageBox.Show("暂无信息！");
            }
            else
            {
                Program.schoolForm_middle.ShowDialog();
            }
        }

        private void low_risk_click(object sender, EventArgs e)
        {
            Program.schoolForm_low.risk = "low";
            Program.schoolForm_low.setDeafault();
            if (Program.low_risk.Count == 0)
            {
                MessageBox.Show("暂无信息！");
            }
            else
            {
                Program.schoolForm_low.ShowDialog();
            }
        }

        private void ReGenerate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
