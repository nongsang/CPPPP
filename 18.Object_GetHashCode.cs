using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Book { }

    class Object_GetHashCode
    {
        static void Main(string[] args)
        {
            int n1 = 256;
            int n2 = 256;
            Book book1 = new Book();
            Book book2 = new Book();

            Console.WriteLine(n1.GetHashCode());        // 256
            Console.WriteLine(n2.GetHashCode());        // 256
            Console.WriteLine(book1.GetHashCode());     // 46104728
            Console.WriteLine(book2.GetHashCode());     // 12289376
        }  
    }
}

// 20 ~ 21행
// GetHashCode()는 인스턴스를 식별할 수 있는 int값을 반환한다.
// int형 변수를 해쉬값을 구하면 그냥 변수가 가지고 있는 값이 그 해쉬값이 된다.
//
// short형의 해쉬값은 short형이 표현할 수 있는 범위에서 결정된다.
// long형의 해쉬값은 int형보다 표현범위가 크므로 int형이 표현할 수 있는 범위에서 결정된다.
// 따라서 long형이나 기타 자료형에서 해쉬값이 충돌할 수 있는 경우가 발생한다.

// 22 ~ 23행
// book1과 book2는 같은 데이터지만 다른 인스턴스이기 때문에 다른 해쉬값을 가진다.
// 둘이 같은 인스턴스를 가리킨다면 같은 해쉬값을 가진다.

// 해쉬값과 Equals()를 쓰까서 객체가 동일한지 판별하게끔 코드를 만들 수 있다.
// 해쉬값은 실행할 때 마다 바뀌지 않는다.
// 해쉬값은 Framework 버전에 따라서 값이 바뀔 수 있다.
// 그러므로 Framework 버전에 따라서 실행때 마다 바뀔 수도 있고 아닐 수도 있다.