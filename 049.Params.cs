using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Params
    {
        static int Add(params int[] values)     // params를 붙여야 여러개의 값을 한번에 받을 수 있다.
        {                                       // int[] values만 있다면 인수가 int배열 형으로 전달이 되야 한다.
            int result = 0;

            for (int i = 0; i < values.Length; ++i)     // 여러개의 값을 받아서
                result += values[i];                    // 다 더한다.

            return result;
        }

        public static void Main()
        {
            Console.WriteLine(Add(1, 2, 3));        // 만약 params가 없다면
            Console.WriteLine(Add(1, 2, 3, 4, 5));  // 전달해주는 인수의 갯수에 맞게 메소드를 각각 정의해줘야 한다.
        }
    }
}