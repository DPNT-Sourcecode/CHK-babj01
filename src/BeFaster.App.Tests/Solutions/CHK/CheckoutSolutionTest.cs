using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTest
    {
        [TestCase("ABBAC", ExpectedResult = 165)]
        [TestCase("", ExpectedResult = -1)]
        [TestCase("EBBAC", ExpectedResult = -1)]
        public int ComputePrice(string skus) =>
            CheckoutSolution.ComputePrice(skus);
    }
}

