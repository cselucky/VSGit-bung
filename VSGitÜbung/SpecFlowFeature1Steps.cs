using System;
using TechTalk.SpecFlow;
using Xunit;

namespace VSGitÜbung
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        int first, second, sum;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            first = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            second = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = first + second;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = sum;
            var actual = p0;
            Assert.Equal(expected, actual);
        }
    }
}
