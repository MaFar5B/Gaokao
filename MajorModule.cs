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
    public partial class MajorModule : UserControl
    {

        public Major major = new Major();
        public MajorModule()
        {
            InitializeComponent();
        }

        public void setMajor(Major m)
        {
            major = m;
            MajorName.Text = major.majorName;
            dataGridView1.Rows.Clear();
            for (int i = 0; i <= 2; i++)
            {
                MajorInfo? info = new MajorInfo();
                DataGridViewRow row = new DataGridViewRow();
                switch (i)
                {
                    case 0:
                        info = major.MajorInfo_2022;
                        break;
                    case 1:
                        info = major.MajorInfo_2021;
                        break;
                    case 2:
                        info = major.MajorInfo_2020;
                        break;
                }
                if (info != null)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "202" + (2 - i).ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = info.Value.plannedEnrollment.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = info.Value.gradeLine.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = info.Value.rank.ToString() });
                }
                else
                {
                    int index = 0;
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "202" + (2 - i).ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = index.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = index.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = index.ToString() });
                }
                dataGridView1.Rows.Add(row);
            }
        }

    }
}
