using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Hannah",true)]
        [InlineData("Bob",true)]
        [InlineData("Alice", false)]
        public void NameTester(string word,bool expected )
        { 

            //Arrange 
            WordSmith tester = new WordSmith();

            //Act 
           var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

               

        }
    }
}
