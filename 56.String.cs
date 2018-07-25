using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;          // 문자열 관련 기능을 사용하려면 추가해야 한다.
using System.Threading.Tasks;

namespace CPPPP
{
    class String
    {
        public static void Main()
        {
            Console.WriteLine("{0} * {1} = {2}", 2, 3, 2 * 3);    // C언어처럼 출력 가능

            string txt1 = "Hello {0} : {1}";         // string 자체에 format을 설정할 수 있다.
            Console.WriteLine(nameof(txt1) + " : " + txt1, "World", "C#");  // 자동으로 string 변수에 문자열이 저장된다.

            string txt2 = string.Format(txt1, "World", "C#");   // format 메소드로 문자열을 결합하여 저장할 수 있다.
            Console.WriteLine(nameof(txt2) + " : " + txt2);

            string txt3 = "{0, -10} * {1, 20} = {0} * {1} = {2}";   // -10, 20을 써 넣어서 문자열의 거리를 떨어뜨려서 출력 가능
            Console.WriteLine(txt3, 4, 5, 4 * 5);           // C언어처럼 일일히 값을 전달하지 않아도 알아서 문자열을 채워넣는다.

            string txt4 = "{0, 20:D}, {1:F}";        // 포멧을 D, F등으로 정해줄 수 있다.
            Console.WriteLine(txt4, 123, 43.2534);  // 소수는 수소점 밑으로 2자리까지만 출력

            string txt5 = "날짜 : {0, -20:D}, 판매수량 : {1, 15:N}";
            Console.WriteLine(txt5, DateTime.Now, 267);             // 날짜의 D포맷은 상세날짜를 나타내준다.

            string txt = "Hello World";
            StringBuilder sb = new StringBuilder();     // 문자열끼리 덧셈연산으로 붙여쓰기를 많이 한다면 StringBuiler를 사용해라.
            sb.Append(txt);     // Append로 StringBuilder에 값을 저장한다.

            for (int i = 0; i < 300000; ++i)    // 30만번
                sb.Append(1);                   // 정수 1을 문자열로 변환하여 StringBuilder에 추가로 저장한다.

            Console.WriteLine(sb);              // 일반 string은 +로 문자열을 더하여 새로운 문자열을 만든 메모리를 생성한다.
                                                // 30만번을 +하면 그 횟수만큼 문자열 메모리를 생성하기 때문에 속도가 많이 저하된다.
                                                // StringBulider는 크기를 미리 많이 잡아놓고 Append로 값을 계속 추가한다.
                                                // 메모리가 모자라면 크기를 한꺼번에 추가로 더 많이 잡는다.
                                                // 그렇기 때문에 문자열을 많이 추가해도 속도저하가 별로 일어나지 않는다.
                                                // 일반 string과 속도가 약 1만배정도 차이난다.
                                                // 문자열을 많이 사용하는 미연시등의 게임을 만들 때 StringBuilder를 사용하자.
        }
    }
}