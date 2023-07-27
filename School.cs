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
        public int getLowestRank(int year)
        {
            int minRank = 0;
            switch(year)
            {
                case 2020:
                    foreach (Major major in majors)
                    {
                        if (major.MajorInfo_2020.HasValue && major.MajorInfo_2020.Value.rank > minRank)
                        {
                            minRank = major.MajorInfo_2020.Value.rank;
                        }
                    }
                    break;
                case 2021:
                    foreach (Major major in majors)
                    {
                        if (major.MajorInfo_2021.HasValue && major.MajorInfo_2021.Value.rank > minRank)
                        {
                            minRank = major.MajorInfo_2021.Value.rank;
                        }
                    }
                    break;
                case 2022:
                    foreach (Major major in majors)
                    {
                        if (major.MajorInfo_2022.HasValue && major.MajorInfo_2022.Value.rank > minRank)
                        {
                            minRank = major.MajorInfo_2022.Value.rank;
                        }
                    }
                    break;
            }
            return minRank;
        }

        public int getLowestGradeLine(int year)
        {
            int minGradeLine = int.MaxValue;
            switch (year)
            {
                case 2020:
                    foreach (Major major in majors)
                    {
                        if (major.MajorInfo_2020.HasValue && major.MajorInfo_2020.Value.gradeLine < minGradeLine)
                        {
                            minGradeLine = major.MajorInfo_2020.Value.gradeLine;
                        }
                    }
                    break;
                case 2021:
                    foreach (Major major in majors)
                    {
                        if (major.MajorInfo_2021.HasValue && major.MajorInfo_2021.Value.rank < minGradeLine)
                        {
                            minGradeLine = major.MajorInfo_2021.Value.gradeLine;
                        }
                    }
                    break;
                case 2022:
                    foreach (Major major in majors)
                    {
                        if (major.MajorInfo_2022.HasValue && major.MajorInfo_2022.Value.rank < minGradeLine)
                        {
                            minGradeLine = major.MajorInfo_2022.Value.gradeLine;
                        }
                    }
                    break;
            }
            if(minGradeLine!= int.MaxValue)
            {
                return minGradeLine;
            }
            return 0;
        }
        public int getAverageLowestRank()
        {
            int minRank = 0;
            int total = 0;
            int count = 0;
            foreach (Major major in majors)
            {
                if(getLowestRank(2020) != 0)
                {
                    total += getLowestRank(2020);
                    count++;
                }
                if(getLowestRank(2021) != 0)
                {
                    total += getLowestRank(2021);
                    count++;
                }
                if(getLowestRank(2022) != 0)
                {
                    total += getLowestRank(2022);
                    count++;
                }
                if(count > 0)
                {
                    total /= count;
                }
                if(minRank < total)
                {
                    minRank = total;
                }
                total = 0;
                count = 0;
            }
            return minRank;
        }
        public void getRisk(int studentRank)
        {
            if(studentRank < 6000)
            {
                if (this.getAverageLowestRank() < studentRank && studentRank - this.getAverageLowestRank() >= 800)
                {
                    risk = "high";
                }
                else if (this.getAverageLowestRank() > studentRank && this.getAverageLowestRank() - studentRank >= 1500)
                {
                    risk = "low";
                }
                else
                {
                    risk = "middle";
                }
            } else if(studentRank <= 200000)
            {
                if (this.getAverageLowestRank() < studentRank && studentRank - this.getAverageLowestRank() >= 1000)
                {
                    risk = "high";
                }
                else if (this.getAverageLowestRank() > studentRank && this.getAverageLowestRank() - studentRank >= 1650)
                {
                    risk = "low";
                }
                else
                {
                    risk = "middle";
                }
            } else
            {
                if (this.getAverageLowestRank() < studentRank && studentRank - this.getAverageLowestRank() >= 2000)
                {
                    risk = "high";
                }
                else if (this.getAverageLowestRank() > studentRank && this.getAverageLowestRank() - studentRank >= 3000)
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
