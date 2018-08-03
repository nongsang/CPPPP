using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Duck_Typing
    {
        static int DuckTypingCall(dynamic target, dynamic item) // 인자로 받은 대상들이 같은 기능을 가지고 있지만 서로 다른 타입이라면
        {                                                       // 매개변수를 dynamic으로 선언하여
            return target.IndexOf(item);                        // 호출하면 서로 호환이 된다.
        }                                                       // 이를 덕 타이핑이라고 한다.

        static int Test(Base a, Base b) // 보통은 a, b가 서로 다른 타입이라도 같은 부모를 상속하고 있으면 느슨한 타입으로 정의하여 사용한다.
        {                               // a, b가 같은 부모를 상속하지 않더라도 공통된 메소드를 가지고 있을 때 공통된 메소드를 사용하고 싶으면
            return a.Method(b);         // 덕 타이핑이 좋은 방법이다.
        }

        public static void Main()
        {
            string txt = "test func";                           // string과 List<T>는 IndexOf라는 메소드를 제공한다.
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };   // 하지만 List<T>와 string은 같은 클래스를 상속받는 것이 아니기 때문에
                                                                // 이름도 같고 기능도 같은 다른 메소드이다.

            Console.WriteLine(DuckTypingCall(txt, "test")); // 출력 결과: 0
            Console.WriteLine(DuckTypingCall(list, 3)); // 출력 결과: 2
        }
    }
}