using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class String_Format
    {
        public static void Main()
        {
            Console.WriteLine("{0} * {1} = {2}", 2, 3, 2 * 3);              // C언어처럼 출력 가능

            string txt1 = "Hello {0} : {1}";                                // string 자체에 format을 설정할 수 있다.
            Console.WriteLine(nameof(txt1) + " : " + txt1, "World", "C#");  // 자동으로 string 변수에 문자열이 저장된다.

            string txt2 = string.Format(txt1, "World", "C#");               // Format 메소드로 문자열을 결합하여 저장할 수 있다.
            Console.WriteLine(nameof(txt2) + " : " + txt2);

            string txt3 = "{0, -10} * {1, 20} = {0} * {1} = {2}";           // -10, 20을 써 넣어서 문자열의 거리를 떨어뜨려서 출력 가능
            Console.WriteLine(txt3, 4, 5, 4 * 5);                           // 일일히 값을 전달하지 않아도 알아서 문자열을 채워넣는다.

            string txt4 = "{0, 20:D}, {1:F}";                               // 포맷을 D, F등으로 정해줄 수 있다.
            Console.WriteLine(txt4, 123, 43.2534);                          // F 포맷은 고정 소숫점으로 소숫점 밑으로 2자리까지만 출력

            string txt5 = "날짜 : {0, -20:D}, 판매수량 : {1, 15:N}";
            Console.WriteLine(txt5, DateTime.Now, 267);                     // 정수형의 D는 10진수지만 날짜형의 D 는 상세날짜를 나타내준다.
        }
    }
}