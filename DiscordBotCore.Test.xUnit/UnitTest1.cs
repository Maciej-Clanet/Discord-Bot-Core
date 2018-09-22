using System;
using Xunit;

namespace DiscordBotCore.Test.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const int expected = 5;

            testUtility bleh = new testUtility();

            var actual = bleh.testUtilityFunction(5);


            Assert.Equal(expected, actual);
        }
    }
}
