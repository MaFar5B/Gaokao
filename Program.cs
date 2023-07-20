using System.Diagnostics;
using System.Runtime.InteropServices;

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

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        [STAThread]
        static void Main()
        {
            AllocConsole();
            Application.Run(mainform);
            Process process = new Process();
            process.StartInfo.FileName = "python";
            process.StartInfo.Arguments = "G:/Documents/GitHub/Gaokao/py/src/main.py";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
            string input = process.ReadLine();
            string output = process.StandardOutput.ReadToEnd();
            student.rank = int.Parse(output);
            FreeConsole();
        }
    }

    public class Student
    {
        public List<String> subjects = new List<String>();
        public List<String> wishes = new List<String>();
        public int score;
        public int rank;
    }
    
}