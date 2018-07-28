using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Tuple_Variable_name
    {
        static (bool, int) ParseInteger(string txt) // 값을 2개 던지나 튜플의 원소의 이름이 없다.
        {                                           // 다른 위치에서 사용할 때 이름을 부여할 수 있다.
            int number = 0;
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
            (bool success, int number) result = ParseInteger("10"); // 메소드에서 반환형의 이름을 써주지 않았어도 사용할 때 이름 부여가 가능

            WriteLine(result.Item1);   // 여전히 Item1, Item2...로 접근이 가능하다.
            WriteLine(result.Item2);   // 그냥 Tuple에 정의한 변수 이름으로 접근하면 안돼?

            WriteLine(result.success);  // 메소드의 반환형에서 정의한 변수 이름으로 접근이 가능하다.
            WriteLine(result.number);   // 변수 이름으로 접근하는 것이 더 정확하다.
        }
    }
}