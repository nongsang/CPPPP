using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;           // Stopwatch를 사용하기 위해 추가

namespace CPPPP
{
    class StopWatch
    {
        private static long Sum()   // 그냥 측정용 메소드
        {
            long sum = 0;

            for (int i = 0; i < 500000000; ++i)
                sum += i;

            return sum;
        }

        public static void Main()
        {
            Stopwatch st = new Stopwatch();
            //Stopwatch st = Stopwatch.StartNew();  // 이건 생성하자마자 시작

            st.Start();     // 알고리즘을 시작하기 전 스탑워치를 킨다.
            Sum();          // 알고리즘을 돌린 후
            st.Stop();      // 알고리즘을 돌린 후 스탑워치를 정지한다.

            Console.WriteLine("Millisecond : " + st.ElapsedMilliseconds);    // ms를 long형으로 반환한다.
            Console.WriteLine("Millisecond : " + st.Elapsed.TotalMilliseconds); // Elapsed라는 시간간격을 나타내는 TimeSpan을 사용한다.
                                                                                // 이번에는 ms를 double형으로 반환다.
            Console.WriteLine("Total Ticks : " + st.ElapsedTicks);           // 몇 틱이 흘렀는가 계산
            Console.WriteLine("second : " + Stopwatch.Frequency);            // 내 컴퓨터가 초당 몇 틱을 측정하는지 알려준다.
                                                                             // ElapsedTicks은 측정 후 틱이 얼마나 흘렀는지 측정한다.
                                                                             // 그러므로 정확한 측정은 ElapsedTicks으로 하는 것이 맞다.
                                                                             // 하지만 몇 초가 흘렀는지는 알 수 없다.
                                                                             // ElapsedMilliseconds로 시간을 측정하자.
        }
    }
}