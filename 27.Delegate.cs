using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mathematics
{
    delegate int CalcDelegate(int x, int y);    // 델리게이트로 선언, 함수포인터같이 사용할 수 있는 객체이다.

    // 각각 정적 메소드로 인스턴스 없이 호출할 수 있지만 private이므로 클래스 내부에서만 호출 가능;
    static int Add(int x, int y) { return x + y; }
    static int Sub(int x, int y) { return x - y; }
    static int Mul(int x, int y) { return x * y; }
    static int Div(int x, int y) { return x / y; }

    CalcDelegate[] methods;     // 델리게이트를 배열로 생성

    public Mathematics()    // 생성자, 모든 정적 메소드를 델리게이트에 할당
    {
        // 할당할 때 함수의 이름만 써주면 된다.
        methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Sub, Mathematics.Mul, Mathematics.Div };
    }

    // 외부에서 접근할 수 있는 메소드
    public void Calculate(int operand1, char opCode, int operand2 )
    {
        switch(opCode)
        {
            case '+':
                Console.WriteLine("+ : " + methods[0](operand1, operand2)); // 델리게이트 배열에 접근
                break;
            case '-':
                Console.WriteLine("- : " + methods[1](operand1, operand2)); // 델리게이트 배열에 접근
                break;
            case '*':
                Console.WriteLine("* : " + methods[2](operand1, operand2)); // 델리게이트 배열에 접근
                break;
            case '/':
                if(operand2 != 0)
                    Console.WriteLine("/ : " + methods[3](operand1, operand2)); // 델리게이트 배열에 접근
                else
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                break;
        }
    }
}

namespace CPPPP
{
    class Delegate
    {
        delegate void WorkDelegate(int arg1, char arg2, int arg3);  // Main()에서 사용할 델리게이트 선언

        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;     // 수학관련 클래스의 메소드를 델리게이트에 저장한다.

            // 함수포인터처럼 사용할 수 있다.
            work(10, '+', 5);
            work(10, '-', 5);
            work(10, '*', 5);
            work(10, '/', 5);
        }
    }
}

// 9행
// 델리게이트로 함수의 대리자를 생성한다.
// 함수포인터같은 역할을 하는 객체이다.
// 이 델리게이트는 매개변수를 2개 받을 수 있고, 각 매개변수는 int형인 함수의 대리자로 사용이 가능하다.

// 12 ~ 15행
// 정적 메소드들을 정의해줬다.
// private로 선언되었기 때문에 클래스 내부에서만 사용할 수 있다.
// 델리게이트에 연결해줄 것이다.

// 17행
// 9행에서 선언한 델리게이트를 배열형태로 선언했다.

// 19 ~ 22행
// 생성자를 정의해줬다.
// 생성자가 호출되면 델리게이트 각 원소에 함수들을 할당해주었다.
// 함수들을 할당할 때 함수의 이름만 적어주면 된다.
// 즉, 소괄호 없이 함수 이름만이다.
// 매개변수가 없어도 마찬가지로 이름만 젓으면 된다.

// 25 ~ 46행
// 외부에서 접근할 수 있는 메소드를 정의해준다.
// 정의를 해줄 때 델리게이트에 접근하여 함수의 기능을 사용한다.

// 52행
// Main()에서 사용할 델리게이트도 만든다.

// 57행
// 52행에서 선언한 델리게이트에 클래스에서 정의한 메소드와 연결해준다.
// 여기서도 19 ~ 22행에서 처럼 델리게이트와 메소드를 연결할 때 메소드 이름만 써주면 된다.
// 중요한 것은 델리게이트로 선언한 변수도 매개변수가 3개고 연결해준 메소드도 매개변수가 3개다.
// 매개변수가 같은 델리게이트와 메소드를 연결해줘야 한다.

// 61 ~ 64행
// 델리게이트는 함수포인터처럼 델리게이트 이름에 매개변수만 전달하여 메소드 호출이 가능하다.