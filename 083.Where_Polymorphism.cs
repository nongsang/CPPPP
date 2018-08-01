using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

class Base { }              // 기초가 되는 클래스

class Derived : Base { }    // 다형성이 구현된 클래스

class Utility
{
    public static T Allocate<T, V>() where V: T, new()  // V는 T이며, 디폴트 생성자가 있는 인자로 받는 강제를 걸어놓는다.
    {
        return new V();     // 모든 조건이 맞으면 V형으로 메모리 할당을 한다.
    }
}

namespace CPPPP
{
    class Where_Polymorphism
    {
        public static void Main()
        {
            Base a = new Derived();     // 전형적인 다형성을 이용한 할당이다.
                                        // 이 다형성 구현 코드를 제네릭으로 어떻게 구현할까?

            Base b = Utility.Allocate<Base, Derived>();     // Derived은 Base을 상속받기 때문에 Derived is Base라고 할 수 있다.
                                                            // 또한 Derived는 디폴트 생성자가 있으므로 b는 Derived형을 할당받는다.
        }
    }
}