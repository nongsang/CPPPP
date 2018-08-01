using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Time_Span
    {
        public static void Main()
        {
            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);   // 말일
            DateTime now = DateTime.Now;                                    // 오늘

            Console.WriteLine("오늘 날짜 : " + now);

            TimeSpan gap = endOfYear - now; // DataTime 타입의 사칙연산은 빼기밖에 없다.
                                            // 연산 결과는 DateTime 사이의 시간 간격을 나타내는 TimeSpan으로 나온다.

            Console.WriteLine("올해의 남은 날짜 : " + gap.TotalDays);  // TotalDays는 double값으로 남은 일 수를 구할 수 있다.
                                                                      // Days는 int형으로 남은 일 수를 구할 수 있다.
                                                                      // 그 밖에 TotalHours, TotalMilliseconds 등등이 있다.
        }
    }
}