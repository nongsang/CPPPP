using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Null_Coalescing_Operator
    {
        public static void Main()
        {
            string txt = null;

            if (txt == null)                    // txt 값이 없으면 (Null)출력
                Console.WriteLine("(Null)");    // txt 값이 있으면 txt 값을 출력
            else                                // 보통은 이렇게 한다.
                Console.WriteLine(txt);         // 더 쉬운 방법은?

            Console.WriteLine(txt ?? "(Null)"); // ?? 연산자를 이용하여 값이 있으면 txt값을, null이라면 (Null)을 출력
                                                // 주의해야 할 것은 ?? 연산자는 참조형 변수를 처리할 떄 쓰인다.
                                                // 값형식일 때는 사용할 수 없음을 알아두자.
        }
    }
}