using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;              // Encoding 기능을 사용하려면 추가
using System.Threading.Tasks;

namespace CPPPP
{
    class Unicode_Encoding
    {
        public static void Main()
        {
            string textData = "Hello World";

            byte[] buf = Encoding.UTF8.GetBytes(textData);  // 유니코드 문자셋 UTF8로 인코딩하여 바이트로 저장
            Console.WriteLine(buf);                         // 바이트의 배열은 값이 안나온다.

                                                            // 바이트의 배열만으로 값을 출력할 수 없다.
                                                            // C#과 Java사이처럼 플랫폼 사이에 문자열을 맞추는 역할정도로 쓰인다.
                                                            // 또한 UTF32, UTF16 등등 유니코드 종류는 많기 때문에 유니코드도 통일해야 한다.
                                                            // 효율상의 이유로 UTF8을 쓰는 추세이기 때문에 UTF8로 인코딩을 한다.

            string data = Encoding.UTF8.GetString(buf);     // 유니코드 문자셋을 UTF8로 인코딩하여 문자열로 저장
            Console.WriteLine(data);                        // 문자열은 아주 잘나온다.
        }
    }
}