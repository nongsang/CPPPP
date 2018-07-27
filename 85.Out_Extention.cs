using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Out_Extention
    {
        public static void Main()
        {
            //int result = int.TryParse("5");   // 이렇게는 못함
            int.TryParse("5", out int result1);  // result 생성과 동시에 저장할 변수를 설정할 수 있다.

            int result2;                     // 기존에는 변수를 먼저 선언하고 넣었어야 했지만 이제는 생성과 동시에 설정이 가능
            int.TryParse("5", out result2);  // 확장된 방법은 자동으로 이렇게 기존 방법으로 바꿔서 해석한다.

            int.TryParse("5", out int result3); // 기존 방법으로 바꿔서 해석하므로
            //int.TryParse("5", out int result3); // 변수를 중복 선언을 하게 된다.
                                                // 그러므로 같은 명령을 2번 내리면 안된다.

            int.TryParse("5", out var result4); // type도 var로 타입추론이 가능하다.

            int.TryParse("5", out int _);   // 값을 받환받았지만 사용하지 않아도 되는 상황에서는'_'를 변수를 사용하면 된다.
            int.TryParse("5", out var _);   // var도 사용가능하다.
            int.TryParse("5", out _);       // 심지어 자료형을 정하지 않아도 된다.

            _ = 6;      // 자료형의 선언 없이 익명의 변수처럼 사용할 수 있다.
            int n = _;  // 하지만 _는 아주 짧은 기간만 존재하는 임시변수같은 존재이므로 값을 다른 곳에 저장할 수 없다.

            WriteLine(_ = 7);   // 이 줄에서만 _는 7이라는 값을 가진다.
                                // 람다에서 반환받는 값이 2개지만 1개만 사용할 때 그냥 없는 취급하려고 _를 쓰면 되겠다.
        }
    }
}