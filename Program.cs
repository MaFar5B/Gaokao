namespace Gaokao

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            ApplicationForm mainform = new ApplicationForm();
            Application.Run(mainform);
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