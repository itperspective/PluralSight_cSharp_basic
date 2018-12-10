using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public float AvarageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AvarageGrade >=90)
                {
                    result = "A";
                }
                else if (AvarageGrade>=80)
                {
                    result = "B";
                }
                else if (AvarageGrade>=70)
                {
                    result = "C";
                }
                else if (AvarageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }
    }
}
