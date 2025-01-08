using System;
using System.Linq;

public class ArrayFilter
{
    public int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        if (originalArray == null || filterArray == null)
            throw new ArgumentNullException("Arrays cannot be null.");
        
        return originalArray.Where(item => !filterArray.Contains(item)).ToArray();
    }
}