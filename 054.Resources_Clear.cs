using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                // File이나 FileStream을 사용하려고 추가

namespace CPPPP
{
    class Resources_Clear
    {
        static void Main(string[] args)
        {
            FileCreate();           // 파일을 생성하고

            Console.WriteLine("파일이 열려있습니다.");
            Console.ReadLine();     // 파일에 입력
        }

        static void FileCreate()
        {
            FileStream fs = new FileStream("output.log", FileMode.Create);  // 파일을 생성후
            //fs.Close();                                                   // 파일 삭제
                                                                            // Close()가 없으면 프로그램이 돌고 있는 동안
                                                                            // 생성된 파일을 삭제할 수 없다.
                                                                            // 왜냐하면 생성된 파일을 관리 힙에서 계속 물고 있기 때문이다.
                                                                            // 따라서 Close()는 파일을 더이상 관리하지 않게 해주는 기능이다.
            fs.Dispose();       // 하지만 Close가 자원해제를 대표할 수 없다.
                                // IDisposable 인터페이스를 상속받아, Dispose로 파일을 해제하는 것이 권장된다.
                                // FileStream은 IDisposable을 상속받으므로 Dispose를 사용할 수 있다.
        }
    }
}