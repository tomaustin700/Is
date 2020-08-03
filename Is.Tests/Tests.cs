using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Is.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void EvenNumberReturnsTrue_IsEven_BeTrue()
        {
            Is.Even(2).Should().BeTrue();
        }

        [TestMethod]
        public void OddNumberReturnFalse_IsEven_BeFalse()
        {
            Is.Even(3).Should().BeFalse();
        }

        [TestMethod]
        public void OddNumberReturnsTrue_IsOdd_BeTrue()
        {
            Is.Odd(3).Should().BeTrue();
        }

        [TestMethod]
        public void EvenNumberReturnFalse_IsOdd_BeFalse()
        {
            Is.Odd(2).Should().BeFalse();
        }
    }
}
