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
        public static ApplicationForm mainForm = new ApplicationForm();
        public static SubjectForm subjectSelectForm = new SubjectForm();
        public static WishForm wishForm = new WishForm();
        public static ResultForm resultForm = new ResultForm();
        public static SchoolForm schoolForm_high = new SchoolForm();
        public static SchoolForm schoolForm_middle = new SchoolForm();
        public static SchoolForm schoolForm_low = new SchoolForm();
        public static Student student = new Student();
        public static List<School> schools = new List<School>();
        public static List<School> high_risk = new List<School> ();
        public static List<School> middle_risk = new List<School> ();
        public static List<School> low_risk = new List<School> ();

        /*[DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();*/
        [STAThread]
        static void Main()
        {
            Application.Run(mainForm);
        }
        public static void ReadResult()
        {
            schools.Clear();
            high_risk.Clear();
            middle_risk.Clear();
            low_risk.Clear();
            string path = "G:/Documents/GitHub/Gaokao/Data/result.csv";
            using (StreamReader sr = new StreamReader(path))
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(",");
                    if(values.Length > 15)
                    {
                        if(values.Length == 16)
                        {
                            values[11] = values[11].Substring(1);
                            values[12] = values[12].Substring(0, values[12].Length - 1);
                            string level = values[11] + "," + values[12];
                            string[] v = values.Skip(0).Take(11).ToArray();
                            v = v.Append(level).ToArray();
                            v = v.Concat(values.Skip(13)).ToArray();
                            values = v;
                        } else if(values.Length == 17)
                        {
                            values[11] = values[11].Substring(1);
                            values[13] = values[13].Substring(0, values[13].Length - 1);
                            string level = values[11] + "," + values[12] + "," + values[13];
                            string[] v = values.Skip(0).Take(11).ToArray();
                            v = v.Append(level).ToArray();
                            v = v.Concat(values.Skip(14)).ToArray();
                            values = v;
                        }
                    }
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
            high_risk.Clear();
            middle_risk.Clear();
            low_risk.Clear();
            foreach (var school in schools)
            {
                school.getRisk(student.rank);
                if(school.risk == "high")
                {
                    high_risk.Add(school);
                } else if(school.risk == "middle")
                {
                    middle_risk.Add(school);
                } else
                {
                    low_risk.Add(school);
                }
            }
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
            process.StartInfo.CreateNoWindow = true;
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