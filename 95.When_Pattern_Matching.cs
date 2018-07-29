using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.Net;       // 인터넷 관련 기능을 쓰려면 추가

namespace CPPPP
{
    class When_Pattern_Matching
    {
        static bool ContainsAt(string item, string url)
        {
            WebClient wc = new WebClient();         // url 식별 등의 기능을 제공
            wc.Encoding = Encoding.UTF8;            // 유니코드는 UTF8로
            string text = wc.DownloadString(url);   // url로 전달된 도메인 네임으로 접속하여 도메인 네임을 문자열에 저장한다.

            return text.IndexOf(item) != -1;    // 도메인 네임 문자열에 전달된 item단어가 있으면 true, 없으면 false 반환
        }

        public static void Main()
        {
            string txt = "네이버";     // 한글이여도 상관없다.

            switch (txt)
            {
                case var item when (ContainsAt(item, "http://www.naver.com")):  // when을 사용하여 var 패턴 매칭의 활용도를 높여주었다.
                    WriteLine("In Naver");
                    break;

                case var item when (ContainsAt(item, "http://www.daum.net")):   // 주의할 점은'http://'까지 풀네임으로 써야 제대로 출력된다.
                    WriteLine("In Daum");                                       // 그냥 www.*만 써주면 예외를 날린다.
                    break;

                default:
                    WriteLine("Non");
                    break;
            }

            int i = 345;

            switch (i)
            {
                //case (i > 300):               // switch문에서는 그냥 비교를 사용할 수 없다.
                case int j when j > 300:        // int j = i;           // 이렇게 새롭게 생성한 j에 i값을 저장하고
                    WriteLine(j);               // if(j > 300)          // j가 300이 초과되는지 비교한 뒤
                    break;                      //    WriteLine(j);     // 출력하는 것임에 주의해야 한다.
                default:
                    WriteLine("바보");
                    break;
            }

            Action<(int, int)> detectZeroOR = (arg) =>      // 주의해야할 점은 Action<int, int>이 아니라 Action<(int, int)>이다.
            {                                               // 람다 전용 델리게이트 Action<>과 튜플을 섞어서 람다로 실행한다.
                switch (arg)                                // 튜플을 전달하고 있음에 주의해야 한다.
                {
                    case var r when r.Equals((0, 0)):       // r이 (0, 0)값을 가진 튜플과 같거나
                    case var r1 when r1.Item1 == 0:         // 새롭게 만든 튜플 r1의 첫번째 원소가 0이거나
                    case var r2 when r2.Item2 == 0:         // 새롭게 만든 튜플 r2의 두번째 원소가 0이면
                        Console.WriteLine("Zero found.");   // 0을 찾았다는 말과 함께
                        return;                             // 람다 종료
                }

                Console.WriteLine("Both nonzero.");     // 모두 아니면 0을 못찾았다는 말 출력.
            };

            detectZeroOR((0, 0));           // 이것도 0, 0이 아니라 (0, 0)을 전달한다.
            detectZeroOR((1, 0));           // ()로 묶어줘야
            detectZeroOR((0, 10));          // 튜플로 전달한다.
            detectZeroOR((10, 15));         // 반드시 주의해서 보자
        }
    }
}