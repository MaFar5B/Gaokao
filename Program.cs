namespace Gaokao

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static ApplicationForm mainform = new ApplicationForm();
        public static Student student = new Student();

        [STAThread]
        static void Main()
        {
            Application.Run(mainform);
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