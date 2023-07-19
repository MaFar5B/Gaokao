namespace Gaokao
{
    public partial class ApplicationForm : Form
    {
        public static SubjectForm subjectselectform = new SubjectForm();
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

        private void Botton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.textBox5.Text) > 750)
            {
                MessageBox.Show("请输入正确的高考分数！");
            }
            else
            {

            }
        }

        private void Botton3_Click(object sender, EventArgs e)
        {
        }
    }
}