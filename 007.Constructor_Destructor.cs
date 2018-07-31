using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Person
    {
        string name;

        public Person() // 생성자
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }

        ~Person()   // 소멸자
        {
            Console.WriteLine("소멸자 호출");
        }
    }

    class Constructor_Destructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main 시작");
            Person person = new Person();
            Console.WriteLine("Main 끝");
        }
    }
}

// 13 ~ 17행
// 생성자 정의
// 기본적으로 C++과 다른게 없다.
// 생성자 오버로딩이 가능하며 변환 생성자를 정의하면 디폴트 생성자를 명시적으로 정의해줘야 한다.
// 또한 public으로 선언을 해야 한다.

// 19 ~ 22행
// 소멸자 정의
// C++과 다른 점은 한정자를 정의하면 안된다.
// 생성은 프로그래머가 임의로 할 수 있지만 소멸은 가비지 컬렉터가 알아서 한다.
// 가비지 컬렉터가 알아서 가비지 컬렉션으로 메모리를 관리하므로 delete 예약어가 없으며 소멸에 신경 쓸 이유가 없다.
// 다만 한가지 주의해야 할 점은 가비지 컬렉션이 언제 발생하는지 정확히 알 수 없다는 것이다.
// 트래픽이 몰리는 순간 가비지 컬렉션이 호출되면 퍼포먼스가 떨어질 수 있다.
// 게다가 가비지 컬렉터 입장에서 소멸자가 정의된 클래스의 객체를 관리하려면 더 복잡한 과정을 거쳐야 하므로 퍼포먼스 하락이 발생한다.
// 닷넷이 관리하지 않는 시스템 자원을얻은 경우에만 소멸자만 정의하는 것이 좋다.
// 네이티브 프로그램과 협업에서 다시 설명한다.