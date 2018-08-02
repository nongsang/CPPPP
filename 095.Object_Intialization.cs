using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    string _name;               // 예전에는 필드에 값을 넣어주려면
    int _age;                   // 일일히 생성자를 정의해줘야 했다.

    public string Name          // 하지만 여러경우의 생성자를
    {                           // 정의하기 귀찮잖아
        get { return _name; }   // 그래서 C#에서는
        set { _name = value; }  // 필드나 프로퍼티가 public으로 선언이 되어있으면
    }                           // 생성자를 구현안해도
                                // 알아서 값을 넣고 생성한다.
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

namespace CPPPP
{
    class Object_Intialization
    {
        public static void Main()
        {
            Person p1 = new Person();                               // 이런 클래스 초기화를 하는 여러가지 방법을 제공한다.
            Person p2 = new Person { Name = "Anders" };             // public으로 선언된
            Person p3 = new Person { Age = 10 };                    // 프로퍼티나 필드에 직접
            Person p4 = new Person { Name = "Anders", Age = 10 };   // 생성하면서 값을 저장할 수 있다.
        }
    }
}