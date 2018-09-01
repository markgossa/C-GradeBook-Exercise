using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    class GradeBook
    {
        // Create a new method that adds a grade to the grades list
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // Hold a list for the class, available at the class level
        List<float> grades = new List<float>();

        // Create a new method call ComputeStatistics which outputs a 
        // GradeStatistics object (i.e. it doesn't use void)
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            // Get the sum of all grades and calculate the highest grade by 
            // comparing it to the value of stats.HighestGrade or stats.LowestGrade
            float sum = 0;
            foreach(float grade in grades)
            {
                sum += grade;

                // Work out highest grade
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);

                // Work out lowest grade
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }

            // Calculate the average grade
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
