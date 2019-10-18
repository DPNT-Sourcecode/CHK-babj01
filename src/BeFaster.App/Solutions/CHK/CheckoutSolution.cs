using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Extensions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            if (skus == null || !skus.Matches("[A-E]*"))
            {
                Console.WriteLine($"Illegal input [{nameof(skus)}={skus ?? "null"}]");
                return -1;
            }

            var skuToCountMapping =
                skus.GroupBy(c => c).
                    ToDictionary(
                        grouping => grouping.Key,
                        grouping => grouping.Count());


            if (skuToCountMapping.Keys.Any(sku => ))
            var sum = 0;

            foreach (var skuAndCount in )
                {
                    var (sku, count) = skuAndCount;

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