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
    public partial class SchoolForm : Form
    {
        public string risk;
        public List<School> schoolList = new List<School>();
        public SchoolForm()
        {
            InitializeComponent();

            flowLayoutPanel_School.AutoScroll = true;
            flowLayoutPanel_School.Dock = DockStyle.Fill;
            flowLayoutPanel_School.FlowDirection = FlowDirection.LeftToRight;
        }
        public void setDeafault()
        {
            switch (risk)
            {
                case "high":
                    this.Text = "冲刺院校";
                    schoolList = Program.high_risk;
                    break;
                case "middle":
                    this.Text = "稳妥院校";
                    schoolList = Program.middle_risk;
                    break;
                case "low":
                    this.Text = "保底院校";
                    schoolList = Program.low_risk;
                    break;
            }
            int moduleCount = schoolList.Count;
            for (int i = 0; i < moduleCount; i++)
            {
                SchoolModule module = new SchoolModule();
                School school = schoolList[i];
                module.setSchool(school);
                flowLayoutPanel_School.Controls.Add(module);
            }
        }
    }
}
