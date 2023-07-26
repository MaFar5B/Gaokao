using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaokao
{
    public class School
    {
        public String name;
        public String Level;//985,211,C9,重点，没有则为none
        public String First_Class_Condition;//一流大学、一流学科，没有则为none
        public String Property;//公办、民办、中外合作
        public List<Major> majors = new List<Major>();
        public string risk;
        
        public int getLowestGradeLine()
        {
            int minGrade = int.MaxValue;
            foreach (Major major in majors)
            {
                if (major.MajorInfo_2020.HasValue && major.MajorInfo_2020.Value.gradeLine < minGrade)
                {
                    minGrade = major.MajorInfo_2020.Value.gradeLine;
                }
                if (major.MajorInfo_2021.HasValue && major.MajorInfo_2021.Value.gradeLine < minGrade)
                {
                    minGrade = major.MajorInfo_2021.Value.gradeLine;
                }
                if (major.MajorInfo_2022.HasValue && major.MajorInfo_2022.Value.gradeLine < minGrade)
                {
                    minGrade = major.MajorInfo_2022.Value.gradeLine;
                }
            }
            return minGrade;
        }

        public int getLowestRank()
        {
            int minRank = 0;
            foreach (Major major in majors)
            {
                if (major.MajorInfo_2020.HasValue && major.MajorInfo_2020.Value.rank > minRank)
                {
                    minRank = major.MajorInfo_2020.Value.rank;
                }
                if (major.MajorInfo_2021.HasValue && major.MajorInfo_2021.Value.rank > minRank)
                {
                    minRank = major.MajorInfo_2021.Value.rank;
                }
                if (major.MajorInfo_2022.HasValue && major.MajorInfo_2022.Value.rank > minRank)
                {
                    minRank = major.MajorInfo_2022.Value.rank;
                }
            }
            return minRank;
        }
        public void getRisk(int studentRank)
        {
            if(studentRank < 6000)
            {
                if (this.getLowestRank() < studentRank && studentRank - this.getLowestRank() >= 800)
                {
                    risk = "high";
                }
                else if (this.getLowestRank() > studentRank && this.getLowestRank() - studentRank >= 1500)
                {
                    risk = "low";
                }
                else
                {
                    risk = "middle";
                }
            } else if(studentRank <= 200000)
            {
                if (this.getLowestRank() < studentRank && studentRank - this.getLowestRank() >= 1000)
                {
                    risk = "high";
                }
                else if (this.getLowestRank() > studentRank && this.getLowestRank() - studentRank >= 1650)
                {
                    risk = "low";
                }
                else
                {
                    risk = "middle";
                }
            } else
            {
                if (this.getLowestRank() < studentRank && studentRank - this.getLowestRank() >= 2000)
                {
                    risk = "high";
                }
                else if (this.getLowestRank() > studentRank && this.getLowestRank() - studentRank >= 3000)
                {
                    risk = "low";
                }
                else
                {
                    risk = "middle";
                }
            }
        }
    }

    public class Major
    {
        public String majorName;
        public MajorInfo? MajorInfo_2020;
        public MajorInfo? MajorInfo_2021;
        public MajorInfo? MajorInfo_2022;
    }
    public struct MajorInfo
    {
        public int plannedEnrollment;//计划招生数
        public int gradeLine;//最低分数线
        public int rank;//最低投档位次
    }

}
