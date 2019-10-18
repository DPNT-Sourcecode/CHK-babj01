﻿using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Extensions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            if (skus == null || !skus.Matches("^[A-E]*$"))
            {
                Console.WriteLine($"Illegal input [{nameof(skus)}={skus ?? "null"}]");
                return -1;
            }

            var skuToCountMapping =
                skus.GroupBy(sku => sku).
                    ToDictionary(
                        grouping => grouping.Key,
                        grouping => grouping.Count());

            var aCount = skuToCountMapping.GetValueOrDefault('A');
            var bCount = skuToCountMapping.GetValueOrDefault('B');
            var eCount = skuToCountMapping.GetValueOrDefault('E');

            var aAfter5Count = aCount % 5;
            var aAfter3Count = aAfter5Count % 3;
            var aPrice = aCount / 5 * 200 + aAfter5Count / 3 * 130 + aAfter3Count * 50;

            var freeBCount = eCount / 2;
            var pricedBCount = Math.Max(bCount - freeBCount, 0);
            var pricedBAfter2Count = pricedBCount % 2;
            var bPrice = pricedBCount / 2 * 45 + pricedBAfter2Count * 30;

            return
                aPrice +
                bPrice +
                skuToCountMapping.GetValueOrDefault('C') * 20 +
                skuToCountMapping.GetValueOrDefault('D') * 15 +
                eCount * 40;
        }

    }
}