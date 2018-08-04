using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;        // WriteLine()으로 줄여서 쓰고 싶어서 추가

namespace CPPPP
{
    class Literal_Improvements
    {
        public static void Main()
        {
            int number1 = 10000000;     // 한 눈에 상수값이 몇인지 확인할 수 없다.
            int number2 = 10_000_000;   // 콤마(,) 대신에 _로 단위를 띄어서 쓸 수 있다.
            int number3 = 10_00_0000;   // 단위를 어디에 놓든 표시할 수 있다.

            uint hex1 = 0xFFFFFFFF;
            uint hex2 = 0xFF_FF_FF_FF;  // 1바이트마다 띄어서 표현
            uint hex3 = 0xFFFF_FFFF;    // 2바이트마다 띄어서 표현

            uint bin1 = 0b0001000100010001;     // 비트로 표현하려면 앞에 0b를 붙여야 한다.
            uint bin2 = 0b0001_0001_0001_0001;  // 비트도 마찬가지로 단위를 나눌 수 있다.
        }
    }
}