using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test                                  // ref의 제약 사항이 두 가지 있다.
{
    public ref int refreturnoflocalvalue()  // 1. 지역 변수를 return ref로 반환할 수 없다.
    {
        int x = 5;                          // 지역 변수의 유효 범위가 스택 상에 있을 때로 한정되기 때문이다.
        return ref x;                       // 메소드의 실행이 끝나면 ref로 반환한 인스턴스가 남아있을 보장이 없다.
    }

    public void changereflocalvar()         // 2. ref 예약어를 지정한 지역 변수는 다시 다른 변수를 가리키도록 할 수 없다.
    {
        int a = 5;
        ref int b = ref a;

        int c = 10;
        b = ref c;                          // 컴파일 에러, C++처럼 포인터의 개념으로 접근할 수 없다.
        ref b = ref c;                      // 컴파일 에러, 이런 식의 사용법도 허용되지 않음
    }
}

namespace CPPPP
{
    class Ref_Extention_Restriction
    {
        static void Main(string[] args)
        {
            
        }
    }
}