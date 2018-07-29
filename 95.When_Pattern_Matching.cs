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
                case var item when (ContainsAt(item, "http://www.naver.com")):  // 'http://'까지 풀네임으로 써야 제대로 출력된다.
                    WriteLine("In Naver");
                    break;

                case var item when (ContainsAt(item, "http://www.daum.net")):   // 그냥 www.*만 써주면 예외를 날린다.
                    WriteLine("In Daum");
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
        }
    }
}