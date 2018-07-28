using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Tuple_Simplification
    {
        static (bool, int) ParseInteger(string txt)     // Tuple임을 명시하지 않고 간략하게 사용이 가능하다.
        {
            int number = 0;
            bool result = false;

            try
            {
                number = int.Parse(txt);
                result = true;
            }
            catch { }

            return (result, number);        // 반환할 때 Tuple을 만들어서 반환하지 않고 그냥 던지도록 확장했다.
        }

        public static void Main()
        {
            (bool, int) result = ParseInteger("10");    // 메소드와 같이 Tuple을 써주지 않아도 된다.

            WriteLine(result.Item1);   // 여전히 Item1, Item2...로 접근이 가능하다.
            WriteLine(result.Item2);   // 그냥 Tuple에 정의한 변수 이름으로 접근하면 안돼?
        }
    }
}