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
                                        // 정적 생산자로 이전
        public string name;

        public Person(string name) // public 생성자
        {
            this.name = name;
            Console.WriteLine("생성자 호출" + this.name);
        }

        static Person() // 정적 생성자
        {
            President = new Person("홍길순");
            Console.WriteLine("정적 생성자 호출");
        }

        public void DisplayName()
        {
            //Person person1 = new Person("");
            //Console.WriteLine("----------");
            //Person person2 = new Person("");
            Console.WriteLine(name);
        }
    }

    class Static_Constructor
    {
        static void Main(string[] args)
        {
            Person person = new Person("홍길동");
            person.DisplayName();

            Person.President.DisplayName();            
        }
    }
}

// 11행
// 저번과 마찬가지로 싱글턴으로 생성자를 호출한다.

// 15행
// private가 아니라 public으로 생성자를 선언하여 외부에서 인스턴스화를 할 수 있도록 한다.

// 21행
// 정적 생성자를 선언하였다.
// 클래스 당 1개만 존재할 수 있고, 매개변수를 사용할 수 없다.
// 그리고 정적 생성자는 클래스를 아무리 생성해도 1번만 호출된다.
// 앞서 싱글턴으로 생성한 것보다 우선적으로 호출되는 것은 아니지만 최종 결과물은 정적 생성자로 선언한 이후에 결정된다.
// 따라서 명시적인 싱글턴은 21행처럼, 간편하게 하고 싶으면 11행처럼 사용하면 된다.

// 40행
// 앞서서 생성자를 public으로 선언했으므로 외부에서 인스턴스화가 가능하다.
// 또한 생성자가 호출되지만 정적 생성자는 더이상 호출되지 않음을 보여준다.

// 43행
// 11행처럼 싱글턴을 생성하는 방법과 21행처럼 정적 생성자를 정의하여 싱글턴을 생성하는 방법 중 어떤 것이 우선인가를 확인한다.
// 결과적으로 최종 결과물은 21행처럼 싱글턴을 생성한 것이다.
// 한마디로 싱글턴은 초기화한 상태로 메모리를 계속 점유하는 것이다.

// 싱글턴은 생성자를 private으로 선언해도 인스턴스화가 가능한 이유는 21행에서 정적 생성자가 인스턴스화를 하기 때문이다.
// 하지만 생성자가 private이므로 외부에서 인스턴스화가 불가능해진다.
// 생성자를 public으로 만들면 외부에서 인스턴스화가 가능하며, 싱글턴은 싱글턴대로 사용할 수 있다.
// 정적 생성자에서 인스턴스화를 하면 최종 결과물은 정적 생성자에서 생성한 것이 된다.