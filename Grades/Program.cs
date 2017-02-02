using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(81.5f);
            book.AddGrade(77);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine($"Average : {stats.AvarageGrade}" +
                $" \r\nHighst : {stats.HighstGrade}" +
                $"\r\nLowst: {stats.LowesGrade}");
        }
    }
}