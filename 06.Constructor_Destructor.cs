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

        ~Person()   // 생성자
        {
            Console.WriteLine("소멸자 호출");
        }
    }

    class Class
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

// 19 ~ 22행
// 소멸자 정의
// C++과 다른 점은 한정자를 정의하면 안된다.
// 생성은 프로그래머가 임의로 할 수 있지만 소멸은 가비지 컬렉터가 알아서 한다.
// 가비지 컬렉터가 알아서 해주므로 delete 예약어가 없으며 일부러 소멸에 신결쓸 이유가 없다.