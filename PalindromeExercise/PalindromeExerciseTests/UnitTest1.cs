using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("poop", true)]
        [InlineData("boom", false)]
        [InlineData("rush", false)]
        [InlineData("iffi", true)]
        [InlineData("racecar", true)]

        public void PalTest(string word, bool expected)
        {
            //Arrange
            var flip = new WordSmith();
            //Act
            var actual = flip.IsAPalindrome(word);
            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
