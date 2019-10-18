using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Extensions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, (int Amount, int Price)[]> SkuToAmountsAndPricesMapping =
            new Dictionary<char, (int Amount, int Price)[]>
            {
                {'A', new[] {(5, 200), (3, 130), (1, 50)}},
                {'B', new[] {(2, 45), (1, 30)}},
                {'C', new[] {(1, 20)}},
                {'D', new[] {(1, 15)}},
                {'E', new[] {(1, 40)}},
                {'F', new[] {(3, 20), (1, 10)}},
                {'G', new[] {(1, 20)}},
                {'H', new[] {(10, 80), (5, 45), (1, 10)}},
                {'I', new[] {(1, 35)}},
                {'J', new[] {(1, 60)}},
                {'K', new[] {(2, 150), (1, 80)}},
                {'L', new[] {(1, 90)}},
                {'M', new[] {(1, 15)}},
                {'N', new[] {(1, 40)}},
                {'O', new[] {(1, 10)}},
                {'P', new[] {(5, 200), (1, 50)}},
                {'Q', new[] {(3, 80), (1, 30)}},
                {'R', new[] {(1, 50)}},
                {'S', new[] {(1, 30)}},
                {'T', new[] {(1, 20)}},
                {'U', new[] {(4, 120), (1, 40)}},
                {'V', new[] {(3, 130), (2, 90), (1, 50)}},
                {'W', new[] {(1, 20)}},
                {'X', new[] {(1, 90)}},
                {'Y', new[] {(1, 10)}},
                {'Z', new[] {(1, 50)}}
            };

        private static readonly (char FreeSku, char QualifyingSku, int Amount)[] FreeSkuToQualifyingSkuAndAmount =
            new []
            {
                ('B', 'E', 2),
                ('Q', 'U', 3),
                ('M', 'N', 3),
                ('Q', 'R', 3)
            };

        public static int ComputePrice(string skus)
        {
            if (skus == null || skus.Matches("^[A-Z]*$"))
            {
                Console.WriteLine($"Invalid input [{nameof(skus)}={skus ?? "null"}]");
                return -1;
            }

            foreach

            var sum = 0;
            foreach (var skuAndCount in skus.GroupBy(_ => _).Select(_ => (_.Key, _.Count())))
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
    }
}
