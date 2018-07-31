using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Person
    {
        public static int CountOfInstance;  // 정적 필드
        string name;

        public Person(string name)  // 생성자
        {
            ++CountOfInstance;      // 정적 필드게 값 +1
            this.name = name;       // 이 클래스의 필드에 매개변수의 값을 대입
            Console.WriteLine("생성자 호출");
        }
    }

    class Static_Field
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.CountOfInstance);  // 출력 결과 0

            Person person1 = new Person("홍길동");     // 여기서 CountOfInstance가 1
            Person person2 = new Person("홍길순");     // 여기서 CountOfInstance가 2

            Console.WriteLine(Person.CountOfInstance);  // 출력 결과 2
        }
    }
}

// 11행
// C/C++에서와 같이 static으로 정적 필드를 생성할 수 있다.
// C#에서는 클래스로 소속을 정해줘야 한다.
// 따라서 전역변수를 생성할 수 없으며, 얼마나 많이 클래스를 참조하는지 알 수 있는 정도로 사용이 가능하다.

// 17행
// this는 Person 클래스를 의미한다.
// 따라서 Person 클래스의 name 필드에 매개변수 name의 값을 대입한다.

// 26, 32행
// 필드를 public으로 선언하였으므로 Static_Field 클래스에서 Person 클래스의 필드에 접근할 수 있다.
// 이 부분은 중요하므로 꼭 알아두도록