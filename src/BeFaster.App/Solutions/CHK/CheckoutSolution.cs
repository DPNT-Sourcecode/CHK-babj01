using System.Collections.Generic;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, List<(int Amount, int Price)>> SkuToAmountsAndPricesMapping =
            new Dictionary<char, List<(int Amount, int Price)>>
            {
                { 
                    'A',
                    new List<(int Amount, int Price)>
                    {
                        (1, 50),
                        (3, 130)
                    }
                },
                {
                    'B',
                    new List<(int Amount, int Price)>
                    {
                        (1, 30),
                        (2, 45)
                    }
                },
                {
                    'C',
                    new List<(int Amount, int Price)>
                    {
                        (1, 20)
                    }
                },
                {
                    'D',
                    new List<(int Amount, int Price)>
                    {
                        (1, 15)
                    }
                }
            };
        public static int ComputePrice(string skus)
        {
        }
    }
}

