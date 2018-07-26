using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Lamda_Expression_Delegate
    {
        delegate int? Divide(int a, int b);     // null을 받을 수 있는 int형 델리게이트

        public static void Main()
        {
            Divide div = (a, b) =>      // 람다 식을 델리게이트에 담을 수 있다.
            {
                if (b == 0)
                    return null;
                else
                    return a / b;
            };

            Console.WriteLine("10 / 2 == " + div(10, 2));   // div라는 델리게이트로 람다 식을 대신하여 계산하게 한다.
            Console.WriteLine("10 / 0 == " + div(10, 0));
        }
    }
}