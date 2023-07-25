using CsvHelper;
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

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
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            process.StandardInput.WriteLine("get_rank");
            process.StandardInput.WriteLine(this.score.ToString());
            process.StandardInput.Flush();
            process.StandardInput.Close();
            string output = process.StandardOutput.ReadToEnd();
            this.rank = int.Parse(output);
        }

        public void generate()
        {
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Users\MaFar\AppData\Local\Programs\Python\Python311\python.exe";
            process.StartInfo.Arguments = "G:/Documents/GitHub/Gaokao/py/src/main.py";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            string input = "generate\n";
            input += this.rank.ToString() + "\n";
            int count = 0;
            foreach(string wish in this.wishes)
            {
                if(count < this.wishes.Count - 1)
                {
                    input += wish + " ";
                    count++;
                } else
                {
                    input += wish;
                }
            }
            process.StandardInput.WriteLine(input);
            process.StandardInput.WriteLine(this.score.ToString());
            process.StandardInput.Flush();
            process.StandardInput.Close();
            string output = process.StandardOutput.ReadToEnd();
        }
        public void ReadFile()
        {
            string path = "G:/Documents/GitHub/Gaokao/Data/result.csv";
            using (var reader = new StreamReader("path\\to\\file.csv", Encoding.UTF8))
            {
            }

        }
    
}