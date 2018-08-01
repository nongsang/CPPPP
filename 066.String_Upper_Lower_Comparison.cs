using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class String_Upper_Lower_Comparison
    {
        public static void Main()
        {
            string txt = "Hello World";

            Console.WriteLine(txt + " EndsWith(\"WORLD\"): " + txt.EndsWith("WORLD"));  // 기본적으로 문자열 비교는 대, 소문자 구분을 한다.
            // StringComparison.OrdinalIgnoreCase로 대, 소문 구분하지 않고 비교하는 옵션을 사용할 수 있다.
            Console.WriteLine(txt + " EndsWith(\"WORLD\"): " + txt.EndsWith("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " IndexOf(\"WORLD\"): " + txt.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " StartsWith(\"HELLO\"): " + txt.StartsWith("HELLO", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(txt + " == HELLO: " + (txt == "HELLO"));  // 기본 비교연산자도 문자열 구분을 한다.
            // 문자열 구분을 하고 싶지 않으면 Equals를 사용하여 StringComparison.OrdinalIgnoreCase 옵션을 사용하면 된다.
            Console.WriteLine(txt + " == HELLO: " + txt.Equals("HELLO", StringComparison.OrdinalIgnoreCase));
        }
    }
}