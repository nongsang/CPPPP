using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Data_Type
    {
        static void Main(string[] args)
        {
            sbyte a = 10;   // 1바이트 정수
            byte b = 20;    // 1바이트 unsigned 정수
            long c = 30;    // 8바이트 정수, long long과 같다.
            ulong d = 40;   // 8바이트 unsigned 정수

            float e = 50.0f;    // 4바이트 실수
            double f = 60.0;   // 8바이트 실수
            decimal g = 70.0m;  // 16바이트 실수

            char h = '\u0023';  // 2바이트 유니코드
            string i = "바보";  // 유니코드 문자열
        }
    }
}

// 13행
// C#에서는 1바이트 정수를 제공한다.
// byte 자료형만 signed를 나타내는 s를 붙이는 sbyte를 사용한다.

// 14행
// byte형은 기본적으로 unsigned형이다.

// 15행
// 8바이트 정수
// C++의 long long과 같은 의미다.

// 16행
// byte형을 제외하고 unsigned를 표현하고 싶으면 u가 붙은 자료형을 사용한다.
// int형도 마찬가지

// 18행
// float형은 초기화 할 때 f를 붙여서 한다.

// 20행
// 16바이트 실수형이다.
// 초기화 할 때 뒤에 m를 붙여야 한다.
// 반올림이 일어나지 않으므로 회계용으로 사용한다.

// 22행
// C#은 기본적으로 유니코드를 지원하기 때문에 char형은 2바이트다.
// 유니코드를 직접 더장하기 위해서 \u를 붙이면 된다.
// Windows Forms에서 유니코드를 제대로 다룰 것이다.
// 유니코드가 기본이기 때문에 ASCII를 사용하고 싶으면 명시적 타입 캐스팅을 해야한다.
// 참고로 변수명도 한글로 지을 수 있다.

// 23행
// const char*형 대신으로 사용한다고 생각하면 된다.