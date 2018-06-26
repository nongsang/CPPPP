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
    class Object_ToString
    {
        static void Main(string[] args)
        {
            Object_ToString toString = new Object_ToString();
            Console.WriteLine(toString.ToString());             // CPPPP.Object_ToString

            Test test = new Test();
            Console.WriteLine(test.ToString());                 // Test

            float f = 10.0f;
            Console.WriteLine(f.ToString());                    // 10, 소숫점 아래는 0으로 맞추었으므로 출력되지 않는다.

            decimal d = 10.0m;
            Console.WriteLine(d.ToString());                    // 10.0, decimal이므로

            string s = "Hello";
            Console.WriteLine(s.ToString());                    // Hello
        }
    }
}

// object형 클래스가 가지고 있는 메소드를 알아본다.
// 모든 객체는 object형 클래스를 상속받는다.
// 그렇기 때문에 모든 객체는 object의 메소드를 사용할 수 있다.
// 그 중에서 ToString()을 알아본다.

// 7행
// 모든 클래스는 object를 상속받기 때문에 직접 object를 상속 받는다고 써도 되고 안써도 상관없다.

// 18 ~ 19행
// 자기자신을 실행하는 클래스를 할당하여 이름을 출력한다.
// 네임스페이스 안에 있으므로 클래스 이름 뿐만 아니라 네임스페이스 이름까지 같이 출력된다.

// 21 ~ 22행
// Test 클래스는 어느 네임스페이스에도 속하지 않으므로 클래스 이름만 출력된다.

// 24 ~ 25행
// float형은 소숫점이 0이면 소숫점 이하는 출력하지 않는다.

// 27 ~ 28행
// decimal형은 소숫점이 0이더라도 소숫점을 출력한다.

// 30 ~ 31행
// string형은 문자열을 출력한다.