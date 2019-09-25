using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilter
{
    
    public int cube(int i)
    {
        if(i % 3 == 0 && i % 5 == 0)
        {
            return i = 0;
        }
        else if (i % 3 == 0 && i % 5 != 0)
        {
            return i = 3;
        }
        else if (i % 3 != 0 && i % 5 == 0)
        {
            return i = 5;
        }
    }

    public int[] cubes(int[] i)
    {

        int[] result;
        for(int x = 0; x < i.Length; x++)
        {
            result.
        }
    }
}
