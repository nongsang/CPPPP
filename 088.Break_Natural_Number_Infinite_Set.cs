using System;
using System.Collections;
using System.Collections.Generic;   // IEnumerable<int>을 사용하고 있으므로 추가
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class YieldNaturalNumber
{
    public static IEnumerable<int> Next(int Max)   // Next()를 호출하면 IEnumerable<int>형으로 반환한다.
    {
        int start = 0;

        while(true)
        {
            ++start;            // 그냥 호출할 때마다 값을 +1한다.

            if(Max < start)     // Max값까지만 출력하고 싶으면
                yield break;    // yield break;를 하면 된다.

            yield return start; // 그리고 반환하는데, Next()를 탈출하지 않고 while문을 다시 돈다.
                                // 그냥 값만 반환하는 것.
        }
    }
}

namespace CPPPP
{
    class Break_Natural_Number_Infinite_Set
    {
        public static void Main()
        {
            foreach (int n in YieldNaturalNumber.Next(100000))  // IEnumerable<int>를 반환하고 n으로 100000까지만 start값을 받아와서
                Console.WriteLine(n);                           // 출력한다.
        }
    }
}