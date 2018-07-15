using System;
using System.Collections.Generic;

class SolutionL2P2
{
    public int solution(int[] A)
    {
        int returnValue = 0;

        Dictionary<int, int> uniqueNumbers = new Dictionary<int, int>();

        foreach (var item in A)
        {
            if (uniqueNumbers.ContainsKey(item))
            {
                uniqueNumbers[item] += 1;
            }
            else
            {
                uniqueNumbers.Add(item, 1);
            }
        }

        foreach (var item in uniqueNumbers)
        {
            if (item.Value % 2 == 0)
            {
                continue;
            }
            else
                returnValue = item.Key;
                
        }

        return returnValue;
    }
}
