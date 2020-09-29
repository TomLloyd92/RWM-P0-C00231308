using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class XOR21test
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = XOR21.XORcalculation(input);
            int[] expected = { 17, 23, 29, 22, 28, 17, 31 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
