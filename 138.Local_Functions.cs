using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;        // WriteLine()으로 줄여서 쓰고 싶어서 추가

namespace CPPPP
{
    class Local_Functions
    {
        public static void Main()
        {
            void print()            // 메소드 내부에서 메소드를 정의할 수 있다.
            {
                WriteLine("바보");  // 이를 지역 함수라고 한다.
            }

            print();                // 호출할 수도 있다.

            (bool, int) func(int a, int b)          // 메소드이므로 튜플을 적용할 수 있다.
            {
                if(b == 0) { return (false, 0); }
                return (true, a / b);
            }

            WriteLine(func(10, 5));

            (bool, int) Func(int a, int b) => (b == 0) ? (false, 0) : (true, a / b);    // 람다도 적용 가능

            WriteLine(Func(10, 5));
        }
    }
}