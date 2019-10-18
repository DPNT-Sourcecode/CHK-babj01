using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTest
    {
        [TestCase("", ExpectedResult = 0)]
        [TestCase("AAA", ExpectedResult = 130)]
        [TestCase("AAAAA", ExpectedResult = 200)]
        [TestCase("AAAAAAA", ExpectedResult = 300)]
        [TestCase("AAAAAAAA", ExpectedResult = 330)]
        [TestCase("AAAAAAAAAA", ExpectedResult = 400)]
        [TestCase("B", ExpectedResult = 30)]
        [TestCase("BB", ExpectedResult = 45)]
        [TestCase("ABBAC", ExpectedResult = 165)]
        [TestCase("C", ExpectedResult = 20)]
        [TestCase("D", ExpectedResult = 15)]
        [TestCase("EE", ExpectedResult = 80)]
        [TestCase("E", ExpectedResult = 40)]
        [TestCase("EEB", ExpectedResult = 80)]
        [TestCase("EEBB", ExpectedResult = 110)]
        public int ComputePrice(string skus) =>
            CheckoutSolution.ComputePrice(skus);
    }
}

