using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    enum Days { Sunday, Monday, Tuesday = 3, Wednesday = 5, Thursday, Friday, Saturday }    // enum은 int형으로만 정의

    class Enum
    {
        public static void Main()
        {
            Days today = Days.Monday;
            //if(today == 1)            // enum과 int는 0 빼고 직접 비교할 수 없다.
            Console.WriteLine(today.ToString());   // 문자열로만 출력가능

            int n = (int)today;         // enum을 정수형(int 포함 short 등등)으로 변환 가능
            Console.WriteLine(n);       // 1이 출력된다.

            today = (Days)6;            // 정수를 enum값으로 변환 가능
            Console.WriteLine(today);   // 정수값에 해당하는 enum을 문자열로 출력
        }
    }
}

// 9행
// enum으로 각 요소들을 정의할 수 있다.
// 선언만 해놓으면 첫번째 요소부터 0으로 시작하여 +1씩 정의한다.
// 각 요소의 값을 직접 정의할 수도 있다.
// 요소는 int로만 정의가 가능하다.
// int의 표현범위를 넘어 long형으로 정의할 수 없다.

// 15 ~ 17행
// enum형에 값을 대입하여 출력할 수 있다.
// enum값은 int형이긴 하나 int형과 직접 비교할 수 있는 값은 0밖에 없다.
// enum형은 enum값과 비교해야 한다.
// enum을 출력하면 int형이 아니라 enum값이 출력된다.
// 즉, Monday가 출력된다.
// 왜냐하면 enum은 값형식이므로 ValueType을 상속 받는다.
// ValueType에 정의된 ToString()이 WriteLine()에서 출력을 요청하면 실행이 되기 때문이다.
// 따라서 값이 1이라고 하더라도 문자열의 형태로 출력이 되기 때문이다.

// 19, 20행
// enum값을 int형으로 형변환이 가능하다.
// 형변환을 하면 enum값에 맞는 정수로 변환이 된다.

// 22, 23행
// 정수를 enum으로 형변환 하면 정수에 맞는 enum값이 출력된다.