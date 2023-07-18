namespace Gaokao

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationForm form = new ApplicationForm();
            Application.Run(form);
            Student student = new Student();
        }
    }

    public class Student
    {
        public String subject1;
        public String subject2;
        public String subject3;
        public String wish;
        public int score;
        public int rank;
    }
    
}