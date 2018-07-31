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

        //static private Person President = new Person("대통령");  // private로 선언하면 외부에서 접근불가

        private string name;

        private Person(string name) // private 생성자
        //public Person(string name)    // public으로 정의하여 일반적인 인스턴스화도 한다면?
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
            Console.WriteLine("main 시작");

            Person.President.DisplayName();     // 이 경우에는 Main 이전에 생성자를 먼저 호출한다.

            //Person person = new Person("홍길동");  // 생성자가 private이므로 오류
                                                    // 만약 생성자가 public이라면 사용가능
                                                    // 싱글턴으로 생성했으면서도 new로 할당하면 생성자와 소멸자가 2번 호출된다.

            Console.WriteLine("main 끝");
        }
    }
}

// 11행
// 싱글턴 패턴
// 메모리에 상주하면서 누구나 접근 가능하고 사용할 수 있는 클래스를 생성한다.
// static을 좀 더 현실적으로 사용하는 방법 중 하나다.

// 13행
// private로 선언하면 외부에서 사용이 불가능하다.

// 17행
// 생성자를 private로 만들었다.
// 따라서 외부에서 인스턴스화가 불가능하다.

// 18행
// 싱글턴으로 만들었음에도 public으로 선언이 가능하다.
// 이 경우에는 new로 할당이 가능.

// 37행
// 싱글턴으로 생성한 객체에 접근하는 방식이다.
// 이렇게 사용하면 생성자는 Main() 이전에 먼저 호출된다.
// 앞으로 자주 사용할 방식이므로 잘 알아두자.

// 38행
// 생성자를 private로 선언하였기 때문에 인스턴스화가 불가능하다.
// 그렇지만 사실상 이렇게 사용할 필요도 없다.
// 왜냐하면 객체 내부에서 이미 인스턴스화를 했기 때문이다.
// 만약 생성자를 public으로 선언했으면 new로도 생성이 가능해진다.
// 하지만 그럴경우 생성자와 소멸자가 2번씩 호출된다.