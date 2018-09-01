using System;
using Xunit;
using Grades;

namespace Grades.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void GradeBookComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(95);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.Equal(92.5,stats.AverageGrade);
        }

        [Fact]
        public void GradeBookComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(95);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.Equal(95, stats.HighestGrade);
        }

        [Fact]
        public void GradeBookComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(95);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.Equal(90, stats.LowestGrade);
        }
    }
}
