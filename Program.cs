using System;
using System.Collections;
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
            FreeConsole();
        }
    }

    public class Student
    {
        public List<String> subjects = new List<String>();
        public List<String> wishes = new List<String>();
        public int score;
        public int rank;

        public void setStudentRank()
        {
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Users\MaFar\AppData\Local\Programs\Python\Python311\python.exe";
            process.StartInfo.Arguments = "G:/Documents/GitHub/Gaokao/py/src/main.py";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            string input = "get_rank\n" + this.score.ToString();
            process.StandardInput.WriteLine(input);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            string output = process.StandardOutput.ReadToEnd();
            this.rank = int.Parse(output);
        }
    }
    
}