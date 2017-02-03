using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
            _name = "old book";

        }
        public GradeStatistics ComputeStatistics()
        {
            var stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighstGrade = Math.Max(grade, stats.HighstGrade);
                stats.LowesGrade = Math.Min(grade, stats.LowesGrade);

                sum += grade;
            }
            stats.AvarageGrade = sum / grades.Count;
            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name !=value)
                    {
                        NameChange(_name, value);
                    }
                    _name = value;
                }
            }

        }
        private List<float> grades;
        public NameChangedDelegate NameChange;
    }
}