using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   // 정규표현식을 그냥 사용하려면 추가해야 한다.

namespace CPPPP
{
    class RegularExpression
    {
        static bool IsEmail(string email)
        {
            // 정규표현식
            // C#에서는 제일 앞에 @를 써야 정규표현식을 사용한다는 의미다.
            // ^ : 정규표현식 시작
            // 0-9 : 0 ~ 9
            // a-zA-Z : 대문자, 소문자
            // [] : 문자클래스, 배열같은것
            // @ : 반드시 들어가야하는 문자
            // + : 앞의 문자가 1개 이상
            // \. : 정규표현식에서 .은 일종의 문자를 의미한다.
            //      \가 문자열에서 이스케이프시퀀스를 의미하므로 \문자를 사용하려면 \\를 사용해야 한다.
            //      정규표현식도 마찬가지로 .을 문자열로 쓰려면 \.를 넣어야 한다.
            // {n,} : 앞 문자가 n번 이상 반복
            // & : 정규표현식의 끝을 알림
            Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");    // 정규표현식 정의
            return regex.IsMatch(email);
        }

        public static void Main()
        {
            string email = "Tester@test.com";

            Console.WriteLine(IsEmail(email));  // 정규표현식으로 해당하는 문자열이 들어왔는지 판별할 수 있다.
                                                // 정규표현식을 사용하지 않는다면 반복문등 구현할 것이 많아진다.
                                                // 정규표현식은 문자열 판별에 많이 쓰이니까 공부해놓자.

            string txt = "Hello World! Welcome to my world";         // World는 앞글자가 대문자다.

            Regex regex = new Regex("world", RegexOptions.IgnoreCase);  // world라는 단어와 들어온 문자열의 단어가 다르면 체크한다.
                                                                        // World와 world는 패턴이 일치하지만 다른 단어로 인식한다.
            string result = regex.Replace(txt, "Universe!");    // Replace는 다른 단어라고 체크된 문자를 새로문 문자열로 대체하는 메소드다.
                                                                // 따라서 World와 world를 Universe로 대체하게 된다.
            Console.WriteLine(result);
        }
    }
}