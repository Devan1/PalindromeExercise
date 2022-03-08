using System.Linq;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("palindrome", false)]
        [InlineData("hello", false)]
        [InlineData("racecar", true)]
        [InlineData("lol", true)]

        public void MyTest(string word, bool expected)
        {
            //arrange
            var test = new PalindromeExercise.WordSmith();
            //act
            bool actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}