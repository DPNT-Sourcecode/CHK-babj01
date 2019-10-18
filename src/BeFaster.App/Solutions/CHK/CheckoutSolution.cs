using System.Collections.Generic;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private readonly Dictionary<char, List<(int Amount, int Price)>> _skuToAmountsAndPrices =
            new Dictionary<char, List<(int Amount, int Price)>>
            {

            };
        public static int ComputePrice(string skus)
        {
        }
    }
}
