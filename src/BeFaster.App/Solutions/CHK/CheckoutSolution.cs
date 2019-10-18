using System;
using System.Collections.Generic;
using System.Linq;

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
                        (3, 130),
                        (1, 50)
                    }
                },
                {
                    'B',
                    new List<(int Amount, int Price)>
                    {
                        (2, 45),
                        (1, 30)
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
            try
            {
                var skusList = skus.Split(',').ToList();
                var skusAndCounts = skusList.GroupBy(_ => _).Select(_ => (char.Parse(_.Key), _.Count()));
                var sum = 0;
                foreach (var skuToCount in skusAndCounts)
                {
                    var (sku, count) = skuToCount;

                    foreach (var (amount, price) in SkuToAmountsAndPricesMapping[sku])
                    {
                        sum += count / amount * price;
                        count %= amount;

                        if (count == 0) break;
                    }
                }

                return sum;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
    }
}






