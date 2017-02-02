using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grade.Test
{
    [TestClass]
    public class AddGrade
    {
        [TestMethod]
        public void ComputeHiehstGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(68.3f);
            book.AddGrade(95);
            var expected = 95;
            GradeStatistics stat = book.ComputeStatistics();
            var actual = stat.HighstGrade;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncremenTest()
        {
            int x = 8;
            int y = IncrementNumber(x);
            Console.WriteLine(y);
            Assert.AreEqual(9, IncrementNumber(x));
        }

        private int IncrementNumber(int x)
        {
            return x += 1;
        }
        [TestMethod]
        public void AddDaystoDate()
        {
            DateTime date = new DateTime(2017, 02, 01);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }
    }
}
