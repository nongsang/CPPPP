using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    string name;            // 필드랑
    public string Name      // 프로퍼티와 매치하여
    {
        get { return name; }    // 게터와
        set { name = value; }   // 세터를 지원해준다.
    }

    public string _name { get; set; }       // 하지만 이렇게 하면 더 쉽게 프로퍼티를 정의할 수 있다.

    //private string n;                     // n은 그냥 임시로 쓴 이름이다. 실제로는 컴파일러가 식별가능한 임시객체를 만든다.
    //public string _name                   // 위에 자동 구현 프로퍼티를 사용하면
    //{
    //    get { return n; }                 // 알아서 이렇게
    //    set { n = value; }                // 확장하여 컴파일한다.
    //}
}

namespace CPPPP
{
    class Auto_Implemented_Property
    {
        public static void Main()
        {
            Person person = new Person();

            person._name = "바보";
            Console.WriteLine(person._name);
        }
    }
}