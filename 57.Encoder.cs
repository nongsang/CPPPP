using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;          // 문자열 관련 기능을 사용하려면 추가해야 한다.
using System.Threading.Tasks;

namespace CPPPP
{
    class Encoder
    {
        public static void Main()
        {
            string textData = "Hello World";

            byte[] buf = Encoding.UTF8.GetBytes(textData);  // 유니코드 문자셋 UTF8로 인코딩하여 바이트로 저장
            Console.WriteLine(buf);             // 값이 안나온다.

            string data = Encoding.UTF8.GetString(buf);     // 유니코드 문자셋 UTF8로 인코딩하여 문자열로 저장
            Console.WriteLine(data);            // 문자열은 아주 잘나온다.
                                                // 이밖에도 UTF32, UTF16 등등 유니코드 종류는 많다.
                                                // 최근에는 UTF8을 많이 쓰는 추세다.
        }
    }
}