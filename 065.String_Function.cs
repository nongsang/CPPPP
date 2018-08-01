using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class String_Function
    {
        public static void Main()
        {
            string txt = "Hello World";

            Console.WriteLine(txt + " Contains(\"Hello\"): " + txt.Contains("Hello"));  // txt에 해당 문자열이 포함되어 있는가?
            Console.WriteLine(txt + " Contains(\"Halo\"): " + txt.Contains("Halo"));
            Console.WriteLine();

            Console.WriteLine(txt + " EndsWith(\"World\"): " + txt.EndsWith("World"));  // txt가 해당 문자열로 끝나는가?
            Console.WriteLine(txt + " EndsWith(\"ello\"): " + txt.EndsWith("ello"));
            Console.WriteLine();

            Console.WriteLine(txt + " GetHashCode(): " + txt.GetHashCode());        // txt의 해시코드 반환
            Console.WriteLine("Hello GetHashCode(): " + "Hello".GetHashCode());     // 문자열의 해시코드 반환
            Console.WriteLine();

            Console.WriteLine(txt + " IndexOf(\"World\"): " + txt.IndexOf("World"));    // 해당 문자열이 있는 위치를 반환
            Console.WriteLine(txt + " IndexOf(\"Halo\"): " + txt.IndexOf("Halo"));      // 없으면 -1
            Console.WriteLine();

            Console.WriteLine(txt + " Replace(\"World\", \"\"): " + txt.Replace("World", ""));  // txt의 해당 문자열을 다른 문자열로 교체
            Console.WriteLine(txt + " Replace('o', 't'): " + txt.Replace('o', 't'));            // 문자도 가능
            Console.WriteLine();

            Console.Write(txt + " Split('o') : ");
            string[] s = txt.Split('o');        // txt에서 o를 뺀 문자열의 배열을 반환
            foreach (string item in s)
                Console.Write(item + ", ");     // Hell, W, rld

            Console.WriteLine();

            Console.WriteLine(txt + " StartsWith(\"Hello\"): " + txt.StartsWith("Hello"));  // 해당 문자열로 시작하는가?
            Console.WriteLine(txt + " StartsWith(\"ello\"): " + txt.StartsWith("ello"));
            Console.WriteLine();

            Console.WriteLine(txt + " Substring(1) : " + txt.Substring(1));         // 1번째 문자부터 마지막까지 출력
            Console.WriteLine(txt + " Substring(2, 3) : " + txt.Substring(2, 3));   // 2번째 문자부터 3개 문자 출력
            Console.WriteLine();

            Console.WriteLine(txt + " ToLower(): " + txt.ToLower());    // 문자열을 대문자로
            Console.WriteLine(txt + " ToUpper(): " + txt.ToUpper());    // 문자열을 소문자로
            Console.WriteLine();

            Console.WriteLine("\" Hello World \" Trim(): " + " Hello World ".Trim());   // 문자열의 앞, 뒤에 공백을 삭제한 문자열을 반환
            Console.WriteLine(txt + " Trim('H') : " + txt.Trim('H'));           // 단어의 앞 문자를 뺀 문자열을 반환
            Console.WriteLine(txt + " Trim('W') : " + txt.Trim('W'));           // 뒷 단어도 상관없음
            Console.WriteLine(txt + " Trim('H', 'W') : " + txt.Trim('H', 'W')); // 모든 단어 동시에 가능
            Console.WriteLine(txt + " Trim('l') : " + txt.Trim('l'));           // 단어 중간 문자는 안된다.

            Console.WriteLine(txt + " Length: " + txt.Length);      // 문자열의 길이 반환
            Console.WriteLine("Hello Length: " + "Hello".Length);
            Console.WriteLine();
        }
    }
}