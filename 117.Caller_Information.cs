using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;  // 호출자 정보를 사용하려면 추가

namespace CPPPP
{
    class Caller_Information
    {
        static void Main(string[] args)
        {
            LogMessage("테스트 로그");   // 메소드를 호출
        }

        // CallerMemberName은 이 메소드를 호출한 메소드의 이름을 출력한다.
        // CallerFilePath은 이 메소드를 호출한 소스코드 파일 경로를 출력한다.
        // CallerLineNumber은 이 메소드를 호출한 소스코드의 줄 번호를 출력한다.
        // 또한 모든 매개변수는 선택적 매개변수 형식이여야 한다.
        static void LogMessage(string text, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine("텍스트: " + text);
            Console.WriteLine("LogMessage를 호출한 메서드 이름: " + memberName);
            Console.WriteLine("LogMessage를 호출한 소스코드의 파일명: " + filePath);
            Console.WriteLine("LogMessage를 호출한 소스코드의 라인번호: " + lineNumber);
        }
    }
}