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

            TimeSpan gap = endOfYear - now;     // TimeSpan으로 DateTime 사이의 시간 간격에 대한 정보를 구할 수 있다.
            Console.WriteLine("올해의 남은 날짜 : " + gap.TotalDays);  // TotalDays는 double값으로 남은 일 수를 구할 수 있다.
                                                                      // Days는 int형으로 남은 일 수를 구할 수 있다.
                                                                      // 그 밖에 TotalHours, TotalMilliseconds 등등이 있다.
        }
    }
}