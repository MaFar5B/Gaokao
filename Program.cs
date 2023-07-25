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
        public static List<School> schools = new List<School>();

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
        public static void ReadResult()
        {
            schools.Clear();
            string path = "G:/Documents/GitHub/Gaokao/Data/result.csv";
            using (StreamReader sr = new StreamReader(path))
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(",");
                    if (count != 0)
                    {
                        Major major = new Major();
                        major.majorName = values[1];
                        if (values[2] != "none")
                        {
                            major.MajorInfo_2020 = new MajorInfo()
                            {
                                plannedEnrollment = int.Parse(values[2]),
                                gradeLine = int.Parse(values[3]),
                                rank = int.Parse(values[4]),
                            };
                        } else
                        {
                            major.MajorInfo_2020 = null;
                        }
                        if (values[5] != "none")
                        {
                            major.MajorInfo_2021 = new MajorInfo()
                            {
                                plannedEnrollment = int.Parse(values[5]),
                                gradeLine = int.Parse(values[6]),
                                rank = int.Parse(values[7]),
                            };
                        } else
                        {
                            major.MajorInfo_2021 = null;
                        }
                        if (values[8] != "none")
                        {
                            major.MajorInfo_2022 = new MajorInfo()
                            {
                                plannedEnrollment = int.Parse(values[8]),
                                gradeLine = int.Parse(values[9]),
                                rank = int.Parse(values[10]),
                            };
                        } else
                        {
                            major.MajorInfo_2022 = null;
                        }
                        if (schools.FirstOrDefault(school => school.name == values[0]) != null)
                        {
                            schools.FirstOrDefault(school => school.name == values[0]).majors.Add(major);
                        } else
                        {
                            School school = new School();
                            school.name = values[0];
                            school.Level = values[11];
                            school.First_Class_Condition = values[12];
                            school.Property = values[13];
                            school.majors.Add(major);
                            schools.Add(school);
                        }
                    }
                    count++;
                }
            }
        }
        public static void Process()
        {
            int high = 0;
            int middle = 0;
            int low = 0;
            foreach (var school in schools)
            {
                school.getRisk(student.rank);
                if(school.risk == "high")
                {
                    high++;
                } else if(school.risk == "middle")
                {
                    middle++;
                } else
                {
                    low++;
                }
                Console.WriteLine(school.name + " lowestRank:" + school.getLowestRank().ToString() + " risk:" + school.risk);
            }
            Console.WriteLine("high:" + high.ToString() + " middle:" + middle.ToString() + " low:" + low.ToString());
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
            foreach (string wish in this.wishes)
            {
                if (count < this.wishes.Count - 1)
                {
                    input += wish + " ";
                    count++;
                }
                else
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
    }
}