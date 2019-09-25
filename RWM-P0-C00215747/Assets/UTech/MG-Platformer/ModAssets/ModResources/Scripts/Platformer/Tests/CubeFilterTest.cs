using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilterTest
{
    public void FilterTest()
    {
        int[] input = { 4, 3, 6, 30, 10, 12 };
        int[] output = CubeFilter.cubes(input);
        int[] result = { 4, 3, 3, 0, 5, 3 };

        CubeFilterTest.Equals(output, result);
    }
}
