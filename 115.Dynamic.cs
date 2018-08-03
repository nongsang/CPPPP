using System;
using System.Collections.Generic;
using System.Linq;                  // LINQ를 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Dynamic
    { 
        public static void Main()
        {
            var a = 5;      // 컴파일하면서 a는 int형으로 결정된다.
            a = "test";     // 컴파일 오류, 앞서 a는 int형으로 결정됬으므로 string값이 저장될 수 없다.

            a.CallFunc();   // 컴파일 오류, a는 CallFunc()이라는 메소드가 정의되어 있지 않다.

            dynamic b = 5;  // 5가 저장되어 있지만 int형으로도, 어떤 형식으로도 결정된게 아니다.
            b = "test";     // b는 형식이 지정되어 있지 않으므로 int형 값이 저장되어 있었어도 string값으로 바꿔 저장될 수 있다.

            b.CallFunc();   // b는 CallFunc()이라는 메소드가 정의되어 있지 않아도 오류는 뿜지 않지만 실행시에는 오류가 발생한다.
                            // dynamic은 루비나 파이썬과 같은 인터프리터 언어와 호환을 위해 만들었다.
                            // 자주는 쓰지는 않겠지만 알아는 두자.
        }
    }
}