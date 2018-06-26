using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test : object     // object를 상속함을 써주지 않아도 자동으로 상속받는다.
{

}

namespace CPPPP
{
    class Object_GetType
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Type type = test.GetType();     // 인스턴스의 Type값을 가져온다.

            Console.WriteLine(type.FullName);   // Test

            Console.WriteLine(typeof(Test));    // 클래스의 이름으로부터 바로 Type을 구하는 방법
        }
    }
}

// object형의 GetType()은 class를 생성할 때 가지고 있는 System.Type의 인스턴스를 가져온다.

// 19행
// test의 Type을 가져온다.

// 21행
// Type을 출력한다.
// FullName을 써도 되고 안써도 된다.

// 23행
// 인스턴스를 만들지 않아도 클래스 이름으로 바로 Type을 구하는 방법이다.