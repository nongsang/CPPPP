using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // using static을 사용하면 C++의 using namespace처럼 타입명 생략을 할 수 있다.
using static Day;               // enum이나
using static BitMode;           // class도 타입명 생략을 할 수 있다.

public enum Day                 // 하지만 제약 조건은
{
    Sunday, Monday              // namespace에 소속되어 있으면 안된다.
}

public class BitMode            // CPPPP 안에만 정의되어 있다면
{
    public const int ON = 1;    // using static은 먹히지 않는다.
    public const int OFF = 0;   // 즉, 전역으로 선언된 데이터만 using static으로 사용 가능
}

                                // 또한 099.Extention_Method에서 배웠던 확장 메소드 또한 using static을 사용할 수 없다.

namespace CPPPP
{
    //public enum Day                   // namespace에 소속되어 있으므로
    //{
    //    Sunday, Monday                // using static이 먹히지 않는다.
    //}

    //public class BitMode
    //{
    //    public const int ON = 1;
    //    public const int OFF = 0;
    //}

    class Using_Static
    {
        public static void Main()
        {
            WriteLine("바보");    // 물론 컴파일 하면 Console.WriteLine()으로 변환하여 해석한다.
                                // C++의 using namespace처럼 남발하면
                                // 모호성이 증가하므로 Console정도 까지만 쓰자.
                                // 확장메소드의 경우 모호성때문에 using static을 사용할 수 없다.
        }
    }
}