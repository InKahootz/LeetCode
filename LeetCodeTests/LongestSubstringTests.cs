using Xunit;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class LongestSubstringTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("c", 1)]
        [InlineData("au", 2)]
        [InlineData("dvdf", 3)]
        public void LengthOfLongestSubstringTest(string s, int expected)
        {
            var sut = new LongestSubstring();
            Assert.Equal(expected, sut.LengthOfLongestSubstring(s));
        }
    }
}