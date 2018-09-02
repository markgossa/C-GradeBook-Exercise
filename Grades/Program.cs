using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new object called book from class GradeBook
            GradeBook book = new GradeBook();

            // Set the book NameChanged field to a new NameChangedDelegate 
            // which runs the OnNameChange method
            book.NameChanged = new NameChangedDelegate(OnNameChange);

            // Give the gradebook a name
            book.Name = "Mark's Grade Book";
            book.Name = "Grade Book";

            // Write the name of the grade book to the console
            Console.WriteLine(book.Name);

            // Add grades to the GradeBook by calling the AddGrade method
            book.AddGrade(91);
            book.AddGrade(89.5f);

            // Create a new object called stats from class GradeStatistics and 
            // set this equal to the output of method book.ComputeStatistics
            GradeStatistics stats = book.ComputeStatistics();

            // Write output to console
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Lowest grade", stats.LowestGrade);
            WriteResult("Highest grade", stats.HighestGrade);
        }

        static void WriteResult(string resultType, float grade)
        {
            Console.WriteLine($"{resultType}: {grade}");
        }

        static void OnNameChange(string existingName, string newName)
        {
            Console.WriteLine($"Gradebook changing name from {existingName} to {newName}");
        }
    }
}
