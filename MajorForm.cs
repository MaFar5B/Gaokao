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
    public partial class MajorForm : Form
    {
        public List<Major> majorList = new List<Major>();
        public MajorForm()
        {
            InitializeComponent();

            flowLayoutPanel_Major.AutoScroll = true;
            flowLayoutPanel_Major.Dock = DockStyle.Fill;
            flowLayoutPanel_Major.FlowDirection = FlowDirection.LeftToRight;
        }
        public void setDefault()
        {
            int moduleCount = majorList.Count;
            for (int i = 0; i < moduleCount; i++)
            {
                MajorModule module = new MajorModule();
                Major major = majorList[i];
                module.setMajor(major);
                flowLayoutPanel_Major.Controls.Add(module);
            }
        }
    }
}
