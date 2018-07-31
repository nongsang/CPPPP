using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Boxing_Unboxing
    {
        static void Main(string[] args)
        {
            int a = 5;

            object obj = a;     // 박싱 : 값형식을 참조형식으로 변환

            int b = (int)obj;   // 언박싱 : 참조형식을 값형식으로 변환

            int c = 5;
            int d = 6;

            int e = GetMaxValue(c, d);  // GetMaxValue의 매개변수가 int형이었다면 값을 복사하고 끝이었을 텐데
                                        // object형이므로 관리 힙을 사용하여 GC에게 일을 시키며 성능저하가 일어난다.
        }

        static int GetMaxValue(object v1, object v2)    // 매개변수가 object형이므로 값형식이 들어올 때 언박싱이 일어나며 성능저하가 발생한다.
        {                                               // object형 대신에 ValueType이라면 괜찮을 것이다.
            int a = (int)v1;    // 이때는 박싱
            int b = (int)v2;    // 이때도 박싱

            if (a >= b)
            {
                return a;
            }
            return b;
        }
    }
}