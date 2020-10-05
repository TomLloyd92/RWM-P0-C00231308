using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XOR21
{
  public static int XOR(int x)
  {
        if(x > int.MaxValue)
        {
            return x;
        }

        return x ^ 21;
  }

  public static int[] XORcalculation(int[] xs)
  {
    int[] result = new int[xs.Length];
    for (int i = 0; i < xs.Length; i++)
    {
      result[i] = XOR(xs[i]);
    }
    return result;
  }
    public static long XORLong(long x)
    {
        if (x > int.MaxValue)
        {
            return x;
        }

        return x ^ 21;
    }
    public static long[] XORcalculationLong(long[] xs)
    {
        long[] result = new long[xs.Length];
        for (long i = 0; i < xs.Length; i++)
        {
            result[i] = XORLong(xs[i]);
        }
        return result;
    }
}

