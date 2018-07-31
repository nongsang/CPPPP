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
        fs.Close();
    }
}

namespace CPPPP
{
    class IDisposable_Class_Exception
    {
        static void Main(string[] args)
        {
            FileLogger log = null;

            try         // 만약 작업중에 예외가 발생하면
            {
                log = new FileLogger("sample.log");

                // 파일에 입력
                log.Write("Start");
                log.Write("End");
            }
            finally     // 반드시 실행하는 예외처리문에서 Dispose문을 호출한다.
            {           // 더 짧게는 안되나?
                log.Dispose();  // 파일해제
            }
        }
    }
}