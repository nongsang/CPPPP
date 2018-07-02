using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int CalcDelegate(int a, int b);    // Main()에서 사용할 델리게이트 선언

namespace CPPPP
{
    class Delegate_CallBack
    {
        static void Calc(int a, int b, CalcDelegate calc)   // 콜백
        {
            Console.WriteLine(calc(a, b));
        }

        // 정적 메소드들
        static int Add(int a, int b) { return a + b; }
        static int Sub(int a, int b) { return a - b; }
        static int Mul(int a, int b) { return a * b; }
        static int Div(int a, int b) { return a / b; }

        public static void Main()
        {
            CalcDelegate[] methods = new CalcDelegate[] { Add, Sub, Mul, Div }; // 메소드와 델리게이트 연결

            // 콜백 메소드에 델리게이트와 필요한 값을 던져주면 된다.
            Calc(11, 22, methods[0]);
            Calc(22, 11, methods[1]);
            Calc(10, 20, methods[2]);
            Calc(20, 10, methods[3]);
        }
    }
}

// 7행
// Main()에서 쓰기 위해서 델리게이트를 선언했다.
// CPPPP 네임스페이스 안에 존재하든 Main()안에 존재하든 상관없다.
// 다른 클래스 안에 존재하지만 않으면 어디서든 접근할 수 있다.

// 13 ~ 16행
// 델리게이트에 할당된 메소드를 받아서 처리하는 메소드다.
// 메소드 내부에서 메소드를 호출하는 구조를 만들었다.
// 이를 콜백이라고 한다.
// 프로그래머가 필요에 의해서 메소드를 호출하는 것이 아닌, 시스템이 실행되다가 필요에 의해서 메소드를 호출하는 것.
// 또한 static으로 선언해서 클래스 내부에서는 언제나 호출할 수 있게 한다.

// 19 ~ 22행
// 정적 메소드들을 델리게이트의 매개변수의 갯수와 같이 정의해준다.

// 26행
// 델리게이트를 배열로 선언하고 메소드들을 연결한다.

// 29 ~ 32행
// 콜백함수에 델리게이트와 값들을 던져준다.

// 정말 이해를 못하겠다면 윈도우 API를 보면 이해가 갈 것이다.