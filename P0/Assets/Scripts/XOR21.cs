using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XOR21
{
  public static int XOR(int x)
  {
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
}

