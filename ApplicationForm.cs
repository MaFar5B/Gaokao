using System.Windows.Forms;

namespace Gaokao
{
    public partial class ApplicationForm : Form
    {
        public static SubjectForm subjectselectform = new SubjectForm();
        public static WishForm wishform = new WishForm();
        public static bool Wish_Clicked = false;
        public ApplicationForm()
        {
            InitializeComponent();
            this.Text = "高考志愿推荐程序";
        }

        private void SelectSubject(object sender, EventArgs e)
        {
            subjectselectform.ShowDialog();
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
            else if (int.Parse(this.textBox5.Text) > 750)
            {
                MessageBox.Show("请输入正确的高考分数！");
            }
            else
            {
                Program.student.subjects.Add(this.label1.Text);
                Program.student.subjects.Add(this.label2.Text);
                Program.student.subjects.Add(this.label3.Text);
                Program.student.score = int.Parse(this.textBox5.Text);
                Program.student.subjects.Sort();
                if (!Wish_Clicked)
                {
                    wishform.full_wished();
                }
                Program.student.wishes = WishForm.WishList;
                foreach (String wish in Program.student.wishes)
                {
                    Console.WriteLine(wish);
                }
                Console.WriteLine(Program.student.score);
            }
        }

        private void WIshSelect_Click(object sender, EventArgs e)
        {
            Wish_Clicked = true;
            WishForm.WishList.Clear();
            wishform.ShowDialog();
        }
    }
}