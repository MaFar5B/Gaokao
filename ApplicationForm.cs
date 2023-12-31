﻿using System.Diagnostics;
using System.Windows.Forms;

namespace Gaokao
{
    public partial class ApplicationForm : Form
    {
        public static bool Wish_Clicked = false;
        public ApplicationForm()
        {
            InitializeComponent();
            this.Text = "高考志愿推荐程序";
        }

        private void SelectSubject(object sender, EventArgs e)
        {
            Program.subjectSelectForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (this.textBox5.Text == "")
            {
                MessageBox.Show("请输入高考分数！");
            }
            else if (int.Parse(this.textBox5.Text) > 697 || int.Parse(this.textBox5.Text) < 150)
            {
                MessageBox.Show("请输入正确的高考分数！");
            }
            else
            {
                Program.student.subjects.Clear();
                Program.student.subjects.Add(this.label1.Text);
                Program.student.subjects.Add(this.label2.Text);
                Program.student.subjects.Add(this.label3.Text);
                Program.student.score = int.Parse(this.textBox5.Text);
                if (!Wish_Clicked)
                {
                    Program.wishForm.full_wished();
                }
                Program.student.wishes = WishForm.WishList;
                Program.student.setStudentRank();
                Program.student.generate();
                Program.ReadResult();
                Program.Process();
                Program.resultForm.changeText();
                Program.resultForm.ShowDialog();
            }
        }

        private void WIshSelect_Click(object sender, EventArgs e)
        {
            Wish_Clicked = true;
            WishForm.WishList.Clear();
            Program.wishForm.ShowDialog();
        }
    }
}