using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   // 정규표현식을 사용하려면 추가해야 한다.

namespace CPPPP
{
    class Regular_Expression
    {
        static bool IsEmail(string email)
        {
            // 정규표현식
            // @는 축자 식별자(Verbatim Identifier)로 C# 6.0부터 사용할 수 있는 기능이다.
            // 자세한 내용은 071.Verbatim_Identifier에서 다룬다.
            // ^ : 정규표현식 시작
            // () : 그룹을 나타낸다.
            // 0-9a-zA-Z : 숫자 0 ~ 9, 소문자 a ~ z, 대문자 A ~ Z 모두를 포함한다.
            // [] : 문자클래스, 배열같은 것
            // + : 앞의 문자가 1개 이상
            // @ : 반드시 포함되는 리터럴 문자열
            // \. : 정규표현식에서 .은 일종의 문자를 의미한다.
            //      \가 문자열에서 이스케이프시퀀스를 의미하므로 \문자를 사용하려면 \\를 사용해야 한다.
            //      .을 문자열로 출력하려면 C처럼 \.로 넣어야 한다.
            //      $를 빼면 .는 순수하게 정규표현식으로 인식하므로 \를 넣지 않아도 된다.
            // {n,} : 앞 문자가 n번 이상 반복
            // & : 정규표현식의 끝을 알림
            //Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");      // 정규표현식 정의
            Regex regex = new Regex("^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(.[0-9a-zA-Z]+){1,}$");          // @를 빼면 \.에서 .로 바꿔도 된다.  
            return regex.IsMatch(email);
        }

        public static void Main()
        {
            string email = "Tester@test.com";

            Console.WriteLine(IsEmail(email));  // 정규표현식으로 해당하는 문자열이 들어왔는지 판별할 수 있다.
                                                // 정규표현식을 사용하지 않는다면 반복문등 구현할 것이 많아진다.
                                                // 정규표현식은 문자열 판별에 많이 쓰이니까 공부해놓자.

            string txt = "Hello World! Welcome to my world";         // World는 앞글자가 대문자다.

            Regex regex = new Regex("world", RegexOptions.IgnoreCase);  // world라는 단어와 같으면 체크하는 기능이다.
                                                                        // World와 world는 대소문자가 다르기 때문에 다른 단어로 인식한다.
                                                                        // 하지만 패턴이 일치하므로 World와 world를 체크한다.
            string result = regex.Replace(txt, "Universe!");    // Replace는 체크된 문자를 새로운 문자열로 대체하는 메소드다.
                                                                // regex에 저장된 단어와 txt 문자열을 비교하여 Universe!라는 단어로 대체한다
                                                                // 따라서 World와 world를 Universe로 대체하게 된다.
            Console.WriteLine(result);
        }
    }
}