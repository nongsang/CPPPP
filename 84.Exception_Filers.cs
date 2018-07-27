using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어
using System.IO;        // 파일관련 기능을 쓰려면 추가해야한다.

namespace CPPPP
{
    class Exception_Filers
    {
        public static void Main()
        {
            string filePath = @"c:\temp\test.txt";

            try
            {
                string txt = File.ReadAllText(filePath); // 경로에 있는 텍스트를 읽어서 txt에 저장
            }
            //catch(FileNotFoundException e) when (filePath.IndexOf("temp") != -1)  // 경로에 temp가 있는 경우에만 예외처리
            //catch (FileNotFoundException e) when (Check(filePath))  // 메소드를 던져도 된다.
            catch (FileNotFoundException e) when (Log(e))   // Log의 결과가 무조건 false이므로 
            {
                WriteLine("바보");                          // 이 문자열은 출력이 되지 않는다. 
            }                                               // 하지만 try문에서 이미 예외가 발생하므로 오류 내용이 출력된다.

            try
            {
                // 예외필터를 사용하지 않아도
            }
            catch (Exception e)
            {
                Log(e);     // 기존의 예외구문으로 만들 수 있다.
                throw;      // 하지만 예외필터는 IL코드로 바로 변경되므로 기능은 같아도 예외필터가 훨씬 좋다.
            }
        }

        static bool Check(string filePath)      // 경로에 temp가 포함되어 있으면 예외처리 메소드
        {
            return filePath.IndexOf("temp") != -1;
        }

        static bool Log(Exception e)
        {
            WriteLine(e.ToString());    // 예외를 받아서 오류 내용을 출력한다.
            return false;               // 무조건 false를 반환하므로 예외필터로 정의된 catch문은 실행되지 않는다.
        }
    }
}