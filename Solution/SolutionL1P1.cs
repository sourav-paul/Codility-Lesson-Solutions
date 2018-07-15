using System;
using System.Collections.Generic;
using System.Linq;

public class SolutionL1P1
{
    public int solution(int N)
    {
        string binaryString = Convert.ToString(N, 2);

        List<int> gapLength = new List<int>();

        bool hasValidGap = false;

        Console.WriteLine(binaryString);

        for (int i = 0; i < binaryString.Length; i++)
        {
            if (binaryString[i] == '1')
            {
                int gap = 0;

                for (int j = i+1; j < binaryString.Length; j++)
                {
                    if(binaryString[j] == '0')
                    {
                        gap++;
                    }
                    else if(binaryString[j] == '1')
                    {
                        hasValidGap = true;

                        gapLength.Add(gap);

                        break;
                    }
                }
            }
        }

        if (hasValidGap)
        {
            return gapLength.Max();
        }
        else
            return 0;
    }
}
