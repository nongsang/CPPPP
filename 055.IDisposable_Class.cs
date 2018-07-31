using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                // File이나 FileStream을 사용하려고 추가

class FileLogger : IDisposable      // IDisposable을 상속하여 객체의 사용이 끝나면 Dispose 메소드를 호출해야 함을 명시한다.
{
    FileStream fs;

    public FileLogger(string fileName)  // 생성자
    {
        fs = new FileStream(fileName, FileMode.Create);
    }

    public void Write(string txt)
    {
        // 생략
    }

    public void Dispose()   // 파일을 해제하려면 반드시 호출
    {
        fs.Close();         // 하지만 문제가 있다.
                            // 파일을 열고 메모리가 파일을 물고 있을 때 예외가 발생한다면?
                            // Dispose가 호출되지 않으므로 자원이 정상적으로 회수가 되지 않는다.
    }
}

namespace CPPPP
{
    class IDisposable_Class
    {
        static void Main(string[] args)
        {
            FileLogger log = new FileLogger("sample.log");

            // 파일에 입력
            log.Write("Start");
            log.Write("End");

            log.Dispose();  // 파일해제
        }
    }
}