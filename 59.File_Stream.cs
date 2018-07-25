using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;            // 파일관련 기능을 사용하려면 추가해야 한다.

namespace CPPPP
{
    class File_Stream
    {
        public static void Main()
        {
            using (FileStream fs = new FileStream("Test.txt", FileMode.Create)) // 파일을 생성하려면 using으로 해야 한다.
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);  // 유니코드 포멧을 정해주고 파일에 입력하는 역할을 한다.
                sw.WriteLine("Hello World");        // 이렇게 한다고 파일에 입력되는 것이 아니라
                sw.WriteLine("Anderson");           // 버퍼에 입력되는 것이다.
                sw.Write(32000);                    // 버퍼에 입력해놨다가
                sw.Flush();                         // 버퍼를 비우면서 파일에 입력한다.
                                                    // Flush를 안하면 버퍼에 있는 내용이 삭제되며 파일에 입력이 안된다.
                //sw.Close();                       // Close()도 상관없다.
            }
        }
    }
}