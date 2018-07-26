using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Type_Inference
    {
        public static void Main()
        {
            var a = 5;              // C++의 auto와 같이 컴파일 시점에서 값이 정해져야 자료형이 자동으로 정해진다.

            Console.WriteLine(a);   // 제너릭과 섞어서 매개변수가 T, 반환형이 var인 메소드를 만들어서 더욱 유연하게 프로그래밍이 가능하다
        }
    }
}