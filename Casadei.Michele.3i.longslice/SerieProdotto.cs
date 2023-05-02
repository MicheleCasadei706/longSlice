using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct

{
    public static long GetLargestProduct(string digits, int span)
{
    if (span == 0)
     {
        return 1;
    }
    if (span > digits.Length || span < 0)
    {
            throw new ArgumentException();
        }
        
        long maxProduct = 0;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            long product = 1;
            for (int j = i; j < i + span; j++)
            {
                product *= digits[j] - '0';
            }
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }
        return maxProduct;
    }
}