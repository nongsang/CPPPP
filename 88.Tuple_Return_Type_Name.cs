using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Tuple_Return_Type_Name
    {
        static (bool success, int number) ParseInteger(string txt)   // 값을 2개 전달함과 동시에 다른 위치에서 설정한 이름으로 접근 가능
        {
            int number = 0;         // 반환하는 변수의 이름과 같지만 서로 다르다.
            bool result = false;    // 반환을 할때 서로 연결이 된다.

            try
            {
                number = int.Parse(txt);
                result = true;
            }
            catch { }

            return (result, number);        // 반환할 때 Tuple을 만들어서 반환하지 않고 그냥 던진다.
        }                                   // 이때 success = result, number = number가 된다.

        public static void Main()
        {
            var result = ParseInteger("10");    // var로 타입 추론을 할 수 있다.

            WriteLine(result.Item1);   // 여전히 Item1, Item2...로 접근이 가능하다.
            WriteLine(result.Item2);   // 그냥 Tuple에 정의한 변수 이름으로 접근하면 안돼?

            WriteLine(result.success);  // 메소드의 반환형에서 정의한 변수 이름으로 접근이 가능하다.
            WriteLine(result.number);   // 변수 이름으로 접근하는 것이 더 정확하다.
        }
    }
}