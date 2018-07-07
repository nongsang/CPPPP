using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CPPPP
{
    class Out
    {
        static int Divide(int n1, int n2)       // 1번 메소드
        {
            if (n2.Equals(0))           // 얼핏 괜찮아 보이지만
            {
                return 0;               // 분모가 0일 때와
            }
            return n1 / n2;             // 0이 올바른 값일 때 모두 결과값이 0이다.
        }                               // 결과값만 보고 올바른 결과가 나왔는지 구분이 힘들다.

        struct DivideResult             // 이번에는
        {
            public bool Success;        // 올바른 값인지 구분하고
            public int Result;          // 값을 출력하는 구조체를 만들어서 구별하게 해보자.
        }

        static DivideResult Devide(int n1, int n2)     // 2번 메소드
        {
            DivideResult ret = new DivideResult();      // 아이디어는 좋은데

            if(n2.Equals(0))                // 구조체를 할당하므로
            {
                ret.Success = false;        // 메모리를 낭비한다.
                return ret;                 // 어차피 곧바로 쓰고
            }
            ret.Success = true;             // 버려질 구조체인데
            ret.Result = n1 / n2;           // 메소드도 복잡해진다.
            return ret;
        }

        static bool Divide(int n1, int n2, out int result)     // 3번 메소드
        {
            if(n2.Equals(0))        // 간단하게
            {
                result = 0;         // 결과값은 result로 보내고
                return false;       // 이 메소드 자체는
            }
            result = n1 / n2;       // 올바른 결과인지만
            return true;            // 구분하게 구현한다.
        }

        public static void Main()
        {
            int value;  // out으로 쓸 것이므로 초기화 안해도 된다.
            if (Divide(15, 3, out value) == true)   // 이렇게 사용하면 된다.
                Console.WriteLine(value);

            int n;
            if(int.TryParse("123", out n) == true)  // 변환을 시도해본다.
                Console.WriteLine(n);

            double d;
            if (double.TryParse("12E3", out d) == true) // double은 지수 표기법도 지원
                Console.WriteLine(d);

            bool b;
            if (bool.TryParse("trues", out b) == false)   // 문자열을 변환할 수 있지만 실패하면
                Console.WriteLine(b);                     // 자료형의 기본값을 저장한다.

            sbyte sb;
            if (sbyte.TryParse("256", out sb) == false)  // 표현범위를 넘으면
                Console.WriteLine(sb);                   // 디폴트 값으로 저장
        }
    }
}

// 12 ~ 19행
// 두 값을 나누는 메소드다.
// 문제는 분모가 0일 경우와 올바른 결과를 낸 경우 모두 결과값이 0이라는 것이다.
// 즉, 결과값이 0이면 올바른 값인지, 실패한 것인지 구별을 못한다는 뜻이다.
// 다른 방법을 찾아야 한다.

// 21 ~ 39행
// 결과값만으로 올바른 값인지 구분할 수 없으므로 구조체에 값과 성공결과를 저장하여 판별한다.
// 아이디어는 좋지만 메모리를 그만큼 차지하고, 느리고, 코드가 복잡해진다.
// 다른 방법이 필요하다.

// 41 ~ 50행
// 메소드 자체는 계산이 성공했는지만 판단하고, 결과값은 result로 보낸다.
// 이렇게 하면 결과값을 가지는 변수만 따로 만들어주면 되므로 더 편해진다.

// 54 ~ 56행
// out으로 넣어줄 변수는 초기화 안해줘도 된다.
// 메소드에 값을 넣어주면 out으로 선언된 변수에 결과값이 전달되다.
// 반환값은 bool형이므로 true, false만 판단하고 실제 구하는 값은 result가 된다.
// out은 ref와 비슷하지만 ref는 다른 곳에서 메소드로 전달할 때 사용, out은 메소드 안에서 결과를 다른 곳으로 보낼 때 사용한다.
// 이렇게 구현할 수 있게 해준 이유는 반환값은 1개만 전달할 수 있지만 그와 별개로 다른 값이 동시에 도출해야할 경우를 구현할 수 있게 해주기 위함이다.

// 58 ~ 72행
// out을 사용한 닷넷 프레임워크 메소드를 사용했다.
// 각 기본 타입에서 TryParse()를 제공한다.
// 값을 변환하려는 자료형으로 변환이 가능하면 true를 전달하며 변수에 저장한다.
// 변환이 불가능하면 false를 전달하며 변수에는 디폴트 값이 저장된다.
// int형이면 0, bool형이면 false 등등
// double형은 지수표기법도 기원한다.
// 표현범위를 넘어도 false를 반환하고 디폴트 값을 저장