using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSeptember
{
    class Sep1
    {
        //Input: [1,2,3,4]
        //Output: "23:41"
        //Input: [5,5,5,5]
        //Output: ""
        public string LargestTimeFromDigits(int[] A)
        {
            var result = "";
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    for (int k = 0; k < 4; ++k)
                    {
                        if (i == j || j == k || k == i) continue;
                        var hh = A[i] + "" + A[j];
                        var mm = A[k] + "" + A[6 - i - j - k];
                        var _time = hh + ":" + mm;

                        if (string.Compare(hh, "24", StringComparison.Ordinal) < 0
                            && string.Compare(mm, "60", StringComparison.Ordinal) < 0
                            && string.Compare(_time, result, StringComparison.Ordinal) > 0)
                        {
                            result = _time;
                        }

                    }
                }
            }
            return result;
        }

    }
}
