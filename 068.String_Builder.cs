using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;              // StringBuilder를 사용하려면 추가
using System.Threading.Tasks;
using System.Diagnostics;       // 성능측정을 위해 추가

namespace CPPPP
{
    class String_Builder
    {
        public static void Main()
        {
            Stopwatch sw = new Stopwatch();     // 성능측정을 위해 생성
            string txt = "Hello World";

            sw.Start();                         // 스탑워치를 켜고

            for (int i = 0; i < 300000; ++i)    // 30만번
            {
                txt += "1";                     // 문자열에 문자 1을 추가
            }

            sw.Stop();                          // 스탑워치를 끈다.

            Console.WriteLine("string Add : " + sw.ElapsedMilliseconds + "ms"); // 성능 약 12초

            sw.Reset();                         // 스탑워치는 처음부터 다시

            StringBuilder sb = new StringBuilder();     // StringBuilder 사용
            sb.Append(txt);                     // StringBuilder에 문자열 추가

            sw.Start();                         // 스탑워치 키고

            for (int i = 0; i < 300000; ++i)    // 30만번
            {
                sb.Append(1);                   // 문자열에 문자 1을 추가
                                                // string은 +로 추가하지만 StringBuider는 Append로 추가한다.
            }

            sw.Stop();                          // 스탑워치를 끈다.

            Console.WriteLine("StringBuilder Append : " + sw.ElapsedMilliseconds + "ms");   // 성능 약 21ms

            Console.WriteLine(sb);              // ToStirng으로도 문자열을 출력할 수 있다.
        }
    }
}

// string이냐 StringBuilder냐에 따라 성능차가 생긴다.
// string은 불변 객체(Immutable Object)기 때문에 string에 대한 모든 변환은 새로운 메모리 할당을 발생시킨다.
// 따라서 txt + 1를 하면 1을 더한 문자열을 새롭게 할당하고 반환하게 된다.
// 이 작업을 반복하면 그만큼 성능저하가 일어난다.

// StringBuilder는 불변객체가 아니기 때문에 내부의 값이 바뀔 수 있다.
// 아무리 그래도 메모리 크기는 정해져 있지는 않은가?
// StringBuilder는 생성부터 미리 일정한 양의 메모리를 미리 할당한다.
// Append로 값을 계속해서 추가한다.
// Append로 추가된 문자열이 미리 할당된 메모리보다 많아지면 또 일정한 양의 메모리를 할당해 놓는다.
// 메모리 할당이 많이 발생하지 않으므로 성능저하가 별로 없다.