using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Enum_Maintenance
    {
        static int Calc(char opType, int operand1, int operand2)        // 1번 메소드
        {
            switch (opType)
            {
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '*': return operand1 * operand2;
                case '/': return operand1 / operand2;
            }
            return 0;
        }

        enum CalcType { Add, Min, Mul, Div }        // enum으로 연산자를 결정

        static int Calc(CalcType opType, int operand1, int operand2)    // 2번 메소드
        {
            switch (opType)
            {
                case CalcType.Add: return operand1 + operand2;
                case CalcType.Min: return operand1 - operand2;
                case CalcType.Mul: return operand1 * operand2;
                case CalcType.Div: return operand1 / operand2;
            }
            return 0;
        }

        public static void Main()
        {
            Console.WriteLine(Calc('+', 1, 2));             // 1번 메소드 호출
            Console.WriteLine(Calc(CalcType.Div, 3, 2));    // 2번 메소드 호출
        }
    }
}

// 11 ~ 21행
// 연산자를 char형으로 전달하여 연산자를 결정한다.
// 딱히 동작에 이상함은 없지만 유지보수가 힘들다.
// 메소드에서 어떤 연산을 제공하는지 알 수 없으므로 내부코드를 보거나 제공되는 도움말을 참조해야 한다.
// 또, 오타라도 낸다면 정상적인 연산이 되지 않고, 연산을 추가할 경우에는 도움말로 추가됬음을 알려야 한다.
// 여러모로 불편하다.

// 23 ~ 35행
// 연산자를 enum으로 결정한다.
// enum정의만 봐도 지원되는 연산을 짐작할 수 있고, 오타가 발생해도 컴파일러가 오류를 발생한다.
// 유지보수가 더욱 쉬워진다.