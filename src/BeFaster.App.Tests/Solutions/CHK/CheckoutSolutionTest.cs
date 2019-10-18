using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTest
    {
        [TestCase("A,B,B,A,C", ExpectedResult = 165)]
        public int ComputePrice(string skus) =>
            CheckoutSolution.ComputePrice(skus);
    }
}

