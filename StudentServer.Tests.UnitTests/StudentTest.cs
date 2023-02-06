using StudentServer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StudentServer.Tests.UnitTests
{
    public class StudentTest
    {

        [Fact]
        public void AddGrade_ValidGrade_RecalculateAverage()
        {
            var student = new Student("Alex", "Jones", Guid.NewGuid());

            var random = new Random();

            List<double> initialGrades = Enumerable.Range(0, 10).Select(s => random.NextDouble() * 100).ToList();

            foreach (var grade in initialGrades)
            {
                student.AddGrade(grade);
            }

            double expectedAverage = initialGrades.Average();

            Assert.Equal(expectedAverage, student.Average);

        }
    }
}
