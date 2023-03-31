using System;
using Xunit;
using PalindromeExercise;
namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("peep", true)]
        [InlineData("rotator", true)]
        [InlineData("noon", true)]
        [InlineData("table", false)]

        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            WordSmith challenger = new WordSmith();

            //Act
            bool actual = challenger.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
