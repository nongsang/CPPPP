using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // using static을 사용하면 C++의 using namespace처럼 타입명 생략을 할 수 있다.

namespace CPPPP
{
    class Using_Static
    { 
        public static void Main()
        {
            WriteLine("바보");    // 물론 컴파일 하면 Console.WriteLine()으로 변환하여 해석한다.
        }
    }
}