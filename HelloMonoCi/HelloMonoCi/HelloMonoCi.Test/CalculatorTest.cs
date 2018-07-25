using NUnit.Framework;
using NUnit.Framework.Internal;

namespace HelloMonoCi.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(2,1,1)]
        public void AddTest(int expected, int x, int y)
        {
            var calc  = new Calculator();
            Assert.AreEqual(expected, calc.Add(x, y));
        }
    }
}