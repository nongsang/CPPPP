using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPPPP
{
    class Anonymous_Type
    {
        public static void Main()
        {
            var a = new { Count = 1, Title = "바보" };    // 각 원소들은 자료형이 없다.
                                                         // new 로 묶에서 전달하면 된다.
                                                         // a를 var로 정해야 익명 타입을 사용할 수 있다.

            Console.WriteLine(a.Count + " : " + a.Title);   // a를 하나의 구조체처럼 사용할 수 있으며, 한번 사용하면 익명 메소드처럼 사라진다.
        }
    }
}