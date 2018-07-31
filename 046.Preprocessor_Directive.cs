using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Preprocessor_Directive
    {
        public static void Main()
        {
            string txt = Console.ReadLine();    // 문자열을 입력받아서 txt에 저장한다.
                                                // 참고로 Read()는 처음으로 입력받은 문자의 아스키값을 반환한다.

            if (string.IsNullOrEmpty(txt) == false)     // 입력받은 문자열이 null이거나 비어있지 않다면, 즉 입력받은 값이 있다면
                Console.WriteLine("사용자 입력 : " + txt);   // 출력
#if OUTPUT_LOG      // OUTPUT_LOG 전처리 상수가 정의되어 있으면 이 밑으로 코드를 포함하여 컴파일 한다.
            else
                Console.WriteLine("입력되지 않음");
#endif              // 정의되어 있지 않으면 이 위로 코드를 포함하지 않고 컴파일한다.
                    // 조건부 컴파일을 설정하는 방법은 솔루션 탐색기 -> 프로젝트 항목(CPPPP) -> 빌드 -> 조건부 컴파일 기호 -> 원하는 기호 입력

#if __X86__         // __X86__이 정의되어있다면 출력
    Console.WriteLine("입력되지 않음");
#elif __X64__       // 아니면 __X64__가 정의되어 있을 때
    Console.WriteLine("입력되지 않음");
#else               // 아무것도 아니라면 출력
            Console.WriteLine("아무것도 정의 안됨");
#endif              // 이외에도 많이 있으니 한번 찾아보길
        }
    }
}