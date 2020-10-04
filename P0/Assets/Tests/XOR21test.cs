using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.UI;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class XOR21test
    {
        [Test]
        public void XOR()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 21 };
            int[] output = XOR21.XORcalculation(input);
            int[] expected = { 17, 23, 29, 22, 28, 17, 31, 0};

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void XORLongNumber()
        {
            long [] input = { 2000000000 , 1000000000 };
            long [] output = XOR21.XORcalculationLong(input);
            long [] expected = { 2000000021 , 1000000021 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);

        }
    }
}
