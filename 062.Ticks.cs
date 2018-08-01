using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Ticks
    {
        private static long Sum()   // 그냥 측정용 메소드
        {
            long sum = 0;

            for (int i = 0; i < 1000000; ++i)
                sum += i;

            return sum;
        }

        public static void Main()
        {
            DateTime before = DateTime.Now;     // 알고리즘을 시작하기 전 날짜를 기록하고
            Sum();                              // 알고리즘을 돌린 후
            DateTime after = DateTime.Now;      // 알고리즘을 돌린 후 날짜를 기록한다.

            long gap = after.Ticks - before.Ticks;      // 그리고 Ticks라는 100ns 정밀도를 가진 속성으로 시간차를 측정한다.
                                                        // Stopwatch에서 알려주는 Ticks와는 다르다.
                                                        // Stopwatch의 Ticks는 타이머 틱 수를 반환하기 때문에 컴퓨터마다 값이 다를 수 있다.

            Console.WriteLine("Total Ticks : " + gap);  // 몇 틱이 흘렀는가 계산
            Console.WriteLine("Millisecond : " + (gap / 10000));    // 100ns가 기준이므로 10000으로 나누면 ms를 반환
            Console.WriteLine("second : " + (gap / 10000 / 1000));  // ms를 1000으로 나눠야 초로 계산된다.
        }
    }
}