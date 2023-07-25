using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaokao
{
    public class School
    {
        public String Level;//985,211,C9,重点，没有则为none
        public String First_Class_Condition;//一流大学、一流学科，没有则为none
        public String Property;//公办、民办、中外合作
        public List<Major> majors;
    }

    public class Major
    {
        public String name;
        public MajorInfo MajorInfo_2020;
        public MajorInfo MajorInfo_2021;
        public MajorInfo MajorInfo_2022;
    }
    public struct MajorInfo
    {
        public int plannedEnrollment;//计划招生数
        public int rank;//最低投档位次
    }

}
