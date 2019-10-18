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
                skus.GroupBy(sku => sku).
                    ToDictionary(
                        grouping => grouping.Key,
                        grouping => grouping.Count());

            skuToCountMapping
        }

    }
}
