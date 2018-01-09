using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Person
    {
        static public Person President = new Person("대통령"); // 싱글턴 생성

        private string name;

        private Person(string name) // private 생성자
        {
            this.name = name;
            Console.WriteLine("생성자 호출");
        }

        public void DisplayName()
        {
            Console.WriteLine(name);
        }
    }

    class Singleton
    {
        static void Main(string[] args)
        {
            //Person person = new Person("홍길동");  // 생성자가 private이므로 오류

            Person.President.DisplayName();            
        }
    }
}

// 11행
// 싱글턴 패턴
// 메모리에 상주하면서 누구나 접근 가능하고 사용할 수 있는 클래스를 생성한다.
// static을 좀 더 현실적으로 사용하는 방법 중 하나다.

// 15행
// 생성자를 private로 만들었다.
// 따라서 외부에서 인스턴스화가 불가능하다.

// 31행
// 생성자를 private로 선언하였기 때문에 인스턴스화가 불가능하다.
// 그렇지만 사실상 이렇게 사용할 필요도 없다.
// 왜냐하면 객체 내주에서 이미 인스턴스화를 했기 때문이다.

// 33행
// 싱글턴으로 생성한 객체에 접근하는 방식이다.
// 앞으로 자주 사용할 방식이므로 잘 알아두자.