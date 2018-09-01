using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new object called book from class GradeBook
            GradeBook book = new GradeBook();

            // Add grades to the GradeBook by calling the AddGrade method
            book.AddGrade(91);
            book.AddGrade(89.5f);

            // Create a new object called stats from class GradeStatistics and 
            // set this equal to the output of method book.ComputeStatistics
            GradeStatistics stats = book.ComputeStatistics();

            // Write output to console
            Console.WriteLine($"Average grade: {stats.AverageGrade}");
            Console.WriteLine($"Lowest grade: {stats.LowestGrade}");
            Console.WriteLine($"Highest grade: {stats.HighestGrade}");
        }
    }
}
