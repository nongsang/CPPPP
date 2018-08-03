using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Tuple_Basic
    {
        static Tuple<bool, int> ParseInteger(string txt)    // Tuple 자료구조를 사용하여 2개 이상의 값을 반환할 수 있다.
        {                                                   // 반환값이 7개까지만 정의가 되어 있고 8개 이상은 다른 Tuple로 처리하도록 구현
            int number = 0;                                 // 반드시 닷넷 버전이 4.7 이상이여야 튜플을 사용할 수 있다.
            bool result = false;

            try
            {
                number = int.Parse(txt);
                result = true;
            }
            catch { }

            return Tuple.Create(result, number);        // 반환할 때 Tuple을 만들어서 반환한다.
        }

        public static void Main()
        {
            Tuple<bool, int> result1 = ParseInteger("10");  // ParseInteger의 반환값이 Tuple로 2개다.

            WriteLine(result1.Item1);   // 각 원소는 Item1,
            WriteLine(result1.Item2);   // Item2, Item3... 로 접근이 가능하다.
        }
    }
}