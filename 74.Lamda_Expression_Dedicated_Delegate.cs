using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Lamda_Expression_Dedicated_Delegate
    {
        delegate int? Divide(int a, int b);     // 만약 많은 람다를 쓴다면 이렇게 각각의 델리게이트를 만들어야 하잖아.
        delegate int Devide(int a, int b);      // 어차피 람다를 한번만 쓸건데 델리게이트를 굳이 람다 수에 맞게 많이 만들어야 하나?

        public static void Main()               // 람다 전용 델리게이트가 존재한다.
        {
            Action<string> Log = (txt) =>       // Action<T>는 반환값이 없는 델리게이트다.
            {
                Console.WriteLine(txt);         // 따라서 어떤 기능을 출력만 하는 등의 기능을 만들 때 좋다.
            };

            Log("Hello World");                 // 델리게이트에 값을 전달하여 기능 사용

            Func<double> pi = () =>             // Func<T>는 반환값이 있는 델리게이트다.
            {
                return 3.14159265;              // 어떤 연산의 결과를 반환해야 하는 경우 사용하면 좋다.
            };

            Func<double> root = () => 1.41421356;   // return이 아니라 그냥 상수만 써도 똑같다.

            Console.WriteLine(pi);      // 반환값이 있기 때문에
            Console.WriteLine(root);    // WriteLine()으로 출력해줘야 한다.
        }
    }
}