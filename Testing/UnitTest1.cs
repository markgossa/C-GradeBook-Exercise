using System;
using Xunit;

namespace Testing
{
    public class AdditionalTests
    {
        [Fact]
        public void StringComparisons()
        {
            string name1 = "Mark";
            string name2 = "mark";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.True(result);
        }

        [Fact]
        public void TestingArrays()
        {
            // This is a constant, i.e. numberOfStudents will always be 4
            const int numberOfStudents = 4;

            // scores is a new array of ints and holds 4 values
            int[] scores = new int[numberOfStudents];

            // Add numbers to the array
            AddScores(scores);

            // Work out the total score
            int totalScore = 0;
            foreach(int score in scores)
            {
                totalScore += score;
            }

            // Work out the average score
            int averageScore = totalScore / scores.Length;

            // Check average score is 85
            Assert.Equal(85, averageScore);

            // Check that the 2nd value in the array is 80
            Assert.Equal(80, scores[1]);
        }

        private void AddScores(int[] scores)
        {
            // Add values to the array
            scores[0] = 70;
            scores[1] = 80;
            scores[2] = 90;
            scores[3] = 100;
        }
    }
}
