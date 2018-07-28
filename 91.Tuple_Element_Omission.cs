using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Tuple_Element_Omission
    {
        static (bool, int) ParseInteger(string txt) // 값을 2개 던지나 튜플의 원소의 이름이 없다.
        {                                           // 다른 위치에서 사용할 때 이름을 부여할 수 있다.
            int number = 0;                         // 사실 원소 이름이 있어도 없어도 상관없다.
            bool result = false;

            try
            {
                number = int.Parse(txt);
                result = true;
            }
            catch { }

            return (result, number);        // 반환할 때 Tuple을 만들어서 반환하지 않고 그냥 던진다.
        }

        public static void Main()
        {
            (var _, var _) = ParseInteger("10");        // 필요없는 튜플 원소는 _를 사용해서

            (var _, var number) = ParseInteger("10");   // 사용하지 않게 만들 수 있다.

            //WriteLine(success);         // success에 해당하는 튜플 값은 _로 생략됬기 때문에 접근할 수 없고
            WriteLine(number);          // number는 존재하므로 접근할 수 있다.
        }
    }
}