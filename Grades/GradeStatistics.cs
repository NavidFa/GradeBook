using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
     public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighstGrade = 0;
            LowesGrade = float.MaxValue;
        }
        public float AvarageGrade;
        public float HighstGrade;
        public float LowesGrade;
    }
}
