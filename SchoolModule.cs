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
    public partial class SchoolModule : UserControl
    {
        public School school = new School();
        public SchoolModule()
        {
            InitializeComponent();
        }
        public void setSchool(School s)
        {
            school = s;
            SchoolName.Text = school.name;
            Property.Text = school.Property;
            string level = school.Level;
            string school_Class = school.First_Class_Condition;
            int grade_2022 = school.getLowestGradeLine(2022);
            int rank_2022 = school.getLowestRank(2022);
            int grade_2021 = school.getLowestGradeLine(2021);
            int rank_2021 = school.getLowestRank(2021);
            int grade_2020 = school.getLowestGradeLine(2020);
            int rank_2020 = school.getLowestRank(2020);
            AvailableMajor.Text = "可报专业  " + school.majors.Count.ToString() + "个 -->";
            if (school_Class != "none")
            {
                FirstClass.Text = school_Class;
            }
            else
            {
                FirstClass.Text = "";
            }
            if (level != "none")
            {
                Level.Text = level;
            }
            else
            {
                Level.Text = "";
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i <= 2; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                switch (i)
                {
                    case 0:
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "2022" });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = grade_2022.ToString() });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = rank_2022.ToString() });
                        break;
                    case 1:
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "2021" });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = grade_2021.ToString() });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = rank_2021.ToString() });
                        break;
                    case 2:
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "2020" });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = grade_2020.ToString() });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = rank_2020.ToString() });
                        break;
                }
                dataGridView1.Rows.Add(row);
            }
        }
        private void Available_Major_Click(object sender, EventArgs e)
        {
            MajorForm majorForm = new MajorForm();
            majorForm.majorList = school.majors;
            majorForm.setDefault();
            majorForm.ShowDialog();
        }
    }
}
