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
    class IDisposable_Class_Using
    {
        static void Main(string[] args)
        {
            using(FileLogger log= new FileLogger("sample.log")) // using을 사용하여 try / finally보다 더 짧게 할 수 있다.
            {                                                   // 컴파일러에 의해 내부적으로는 try / finally와 동일하게 번역된다.
                log.Write("Start");                             // 더 개선하는 방법은
                log.Write("End");                               // CPPPP_Upgrade/022.IDisposable_Exception_Close.cs를 참조
            }
        }
    }
}