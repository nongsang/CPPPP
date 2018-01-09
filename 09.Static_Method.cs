using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Person
    {
        private static int CountOfInstance;  // private 정적 필드
        string name;

        public Person(string name) // 생성자
        {
            ++CountOfInstance;
            this.name = name;
            Console.WriteLine("생성자 호출");
        }

        static public void OutputCount()    // public 정적 메소드
        {
            Console.WriteLine(CountOfInstance); // 정적 메소드에서 정적 필드에 접근
        }
    }

    class Static_Method
    {
        static void Main(string[] args)
        {
            Person.OutputCount();   // 클래스 이름으로 정적 메서드 호출

            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");

            Person.OutputCount();  // 출력 결과 2
        }
    }
}

// 11행
// 저번과는 다르게 public이 아니라 private로 선언하였다.
// Main() 메소드에서 호출을 못할텐데?

// 21행
// public 정적 메소드를 선언했다.
// 클래스 내부에서는 private인 필드도 얼마든지 접근할 수 있다.
// 이는 C++과 똑같다.
// 한정자와 static 예약어는 서로 바꿔도 의미가 같다.
// 메소드를 정적으로 선언해야만 정적 필드에 접근할 수 있다. -> 매우 중요.
// 필드가 정적이 아니라면 정적 메소드는 정적이 아닌 필드에 접근할 수 없다. -> 이것도 중요.

// 31, 36행
// 따로 인스턴스를 생성하지 않고 Person클래스의 메소드를 사용하고 있다.
// 이는 메소드가 public이면서 static이기 때문에 가능한 일이다.
// 만약 static이 아니라면 인스턴스를 new로 할당한 다음 사용해야 한다.

// 여기까지 왔을 때 static, public, new의 의미
// 1. static은 인스턴스와 관계없이 접근가능성을 나타낸다.
// 2. public은 인스턴스화 하였을 때 사용가능성을 나타낸다.
// 3. new는 인스턴스화 하여 메모리에 상주하는 역할을 한다.

// 따라서 static public의 의미는 인스턴스와 관계없이 접근했을 때 사용가능성은 public에 근거한다는 의미다.
// 거기에 new를 사용하여 singleton패턴을 구현하면 메모리에 상주하는 언제나 접근 가능한 객체가 생성되는 것이다.
// 그러므로 singleton은 모두가 공유하는 객체가 되는 것이다.