using Xunit;
using StringCutter;

namespace TestStringCutter
{
    public class TestStringCutter
    {
        [Theory]
        [InlineData("ab", "aaabbbcccdde", "cccdde")]
        [InlineData("ab", "aaaabbbcccdde", "acccdde")]
        [InlineData("ab", "aaabbbbcccdde", "bcccdde")]
        [InlineData("bc", "aaabbbcccdde", "aaadde")]
        [InlineData("bc", "aaabbbbcccdde", "aaabdde")]
        [InlineData("bc", "aaabbbccccdde", "aaacdde")]
        [InlineData("cd", "aaabbbcccdde", "aaabbbce")]
        [InlineData("cd", "aaabbbccddde", "aaabbbde")]
        [InlineData("de", "aaabbbcccdde", "aaabbbcccd")]
        [InlineData("ba", "aaabbbcccdde", "aaabbbcccdde")]
        public void testCutOUtString(string stringToCut, string inputString, string expected)
        {
            string actual = Program.cutOutString(inputString, stringToCut);
            Assert.Equal(expected, actual);
        }
    }
}