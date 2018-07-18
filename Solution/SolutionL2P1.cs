using System;
using System.Collections.Generic;
using System.Linq;

class SolutionL2P1
{
    public int[] solution(int[] A, int K)
    {
        if (A.Length == 0 ||
            A.Length == K ||
            K == 0 ||
            A.Skip(1).All(s => Equals(A[0], s)))
        {
            return A;
        }
        else
        {
            var resultArray = new int[A.Length];

            for (int j = 0; j < K; j++)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (i + 1 < A.Length)
                    {
                        resultArray[i + 1] = A[i];
                    }
                    else if (i + 1 == A.Length)
                    {
                        resultArray[0] = A[A.Length - 1];
                    }
                }

                for (int k = 0; k < A.Length; k++)
                {
                    A[k] = resultArray[k];
                }

            }

            return resultArray;
        }
    }
}
