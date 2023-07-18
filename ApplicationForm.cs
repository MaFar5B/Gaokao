namespace Gaokao
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
            this.Text = "高考志愿推荐程序";
        }

        private void SelectSubject(object sender, EventArgs e)
        {
            SubjectForm subjectselectform = new SubjectForm();
            subjectselectform.Show();
        }
    }
}