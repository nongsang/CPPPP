using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Ref_Extention_Locals
    {
        static void Main(string[] args)
        {
            int a = 5;      // a와
            int b = 6;      // b는 서로 별개의 메모리에 저장되어 있다.

            a = 7;          // a에 7을 저장해도

            Console.WriteLine(a);   // a의 값과
            Console.WriteLine(b);   // b의 값이 서로 다른 것이 그 증거다.

            ref int c = ref a;      // ref를 이용한 변수로 다른 변수를 가리키게 할 수 있다.

            c = 10;                 // 서로 연결되기 때문에 c의 값이 바뀌어도 a의 값이 바뀌게 된다.

            Console.WriteLine(a);   // C++에서
            Console.WriteLine(c);   // &와 같은 역할을 한다.
        }
    }
}