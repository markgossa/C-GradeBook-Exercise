using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class GradeBook
    {
        // Constructor for the grade book
        public GradeBook()
        {
            // Set a default name
            name = "Grade book";
        }

        // Create a new method that adds a grade to the grades list
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // Hold a list for the class, available at the class level
        List<float> grades = new List<float>();

        // Give the grade book a name field
        private string name;

        // Create a new public field using the delegate type NameChangedDelegate
        public NameChangedDelegate NameChanged;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    // Check if the name has changed (i.e. not equal to value)
                    if(name != value)
                    {
                        // This gives code to the NameChanged field which is a delegate
                        NameChanged(name, value);
                    }

                    name = value;
                }
            }
        }

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
