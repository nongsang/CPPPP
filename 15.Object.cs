using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Class : object
    {
        public int Data = 100;

        public Class() { }

        public Class(int data)
        {
            Data = data;
        }
    }

    class Object
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("n.Equals(5.0) : " + n.Equals(5.0f));  // false
            Console.WriteLine("n == 5.0 : " + (n == 5.0));          // true    

            Console.WriteLine();

            Class c1 = new Class();
            Console.WriteLine("c1.Data.Equals(100) : " + c1.Data.Equals(100)); // 흠...

            Console.WriteLine();

            Class c2 = new Class(200);
            Class c3 = c2;              // 저번에 string에서 봤지?
            Class c4 = new Class(200);
            Console.WriteLine("c2 = new, c3 = c2, c4 = new");
            Console.WriteLine("c2.Equals(c3) : " + c2.Equals(c3));  // 그럴 수 있지
            Console.WriteLine("c2.Equals(c4) : " + c2.Equals(c4));  // 띠용?
            Console.WriteLine("c2 == c3 : " + (c2 == c3));          // 이것도 주소값 비교
            Console.WriteLine("c2 == c4 : " + (c2 == c4));          // 주소값이니까 false

            Console.WriteLine();

            string txt1 = "text";
            string txt2 = null;
            Console.WriteLine("txt1 : text, txt2 : null");
            Console.WriteLine("txt1.Equals(txt2) : " + txt1.Equals(txt2));
            //Console.WriteLine("txt2.Equals(txt1) : " + txt2.Equals(txt1));    // 이렇게 말고
            Console.WriteLine("'text'.Equals(txt2) : " + "text".Equals(txt2));  // 이렇게 쓰자
            //Console.WriteLine("txt1 == txt2 : " + txt1 == txt2);  // 이렇게 하면 안된다.
            Console.WriteLine("txt1 == txt2 : " + (txt1 == txt2));

            Console.WriteLine();

            Console.WriteLine("txt3 : new 'a', txt4 : new 'a' 'b'");
            string txt3 = new string(new char[] { 'a' });
            string txt4 = new string(new char[] { 'a', 'b' });
            Console.WriteLine("txt3.Equals(txt4) : " + txt3.Equals(txt4));
            Console.WriteLine("txt3 == txt4 : " + (txt3 == txt4));

            Console.WriteLine();

            Console.WriteLine("n1 : 256, n2 : 256, n3 : 1234");
            short n1 = 256;
            short n2 = 256;
            short n3 = 1234;
            Console.WriteLine("n1.GetHashCode() : " + n1.GetHashCode());
            Console.WriteLine("n2.GetHashCode() : " + n2.GetHashCode());
            Console.WriteLine("n3.GetHashCode() : " + n3.GetHashCode());

            Console.WriteLine();

            Console.WriteLine("c2 = new, c3 = c2, c4 = new");
            Console.WriteLine("c2.GetHashCode() : " + c2.GetHashCode());
            Console.WriteLine("c3.GetHashCode() : " + c3.GetHashCode());
            Console.WriteLine("c4.GetHashCode() : " + c4.GetHashCode());
        }
    }
}

// 9행
// 내가 정의한 클래스가 object를 상속받고 있다.
// object는 System.Object의 C#형태이며 모든 타입의 부모다.
// object는 자체가 참조형이면서 값 형식의 부모 타입이다.
// 닷넷에서는 System.ValueType이라는 타입에서 값 형식을 상속받게 하고 있고, System.ValueType은 object를 상속받는다.
// 따라서 int, long, enum, struct 등등은 ValueType으로 정의할 수 있다.
// System.String, System.Array, 그 밖에 내가 정의한 클래스는 object는 직접적으로 상속받는다.

// 26행
// object 클래스의 메소드 중 하나인 Equals()함수다.
// 값을 비교하여 참, 거짓을 반환한다.
// 중요한 것은 값 형식일 때 메모리 타입까지 비교한다는 것이다.
// n의 값은 5가 맞지만 Equals()를 사용해서 5.0인가를 물어보면 false가 나온다.

// 27행
// '=='을 이용해서 값을 비교한다.
// Equals()와 비교해서 실질적으로 값을 비교한다.
// 메모리 타입까지는 비교하지 않으므로 편하게 쓰려면 '=='이 쓰기 좋다.

// 31행
// 클래스에 있는 필드에 직접 접근하여 비교하는 것이 가능하다.

// 37행
// string에서 봤었던 참조형식의 특성이다.
// 동적할당 되어 있는 문자열을 두 포인터가 가리키는 상황으로 만들었다.

// 40행
// 동적할당 된 메모리를 가리키는 두 포인터를 Equals()로 비교한다.
// 스택에 생성되어 있는 두 포인터는 서로 같은 주소값을 가지고 있으므로 두 값이 서로 같다고 판단한다.

// 41행
// 두 인스턴스가 가진 필드에는 값이 똑같이 200이 저장되어 있다.
// 하지만 두 인스턴스는 같지 않다는 결과가 나오는데, 이게 어찌된 일?
// 앞서 말했듯이 '스택'에 있는 값을 비교한다.
// 스택에 있는 두 변수는 자유영역에 있는 메모리의 주소값을 담고 있다.
// 따라서 Equals는 두 변수가 가지고 있는 주소값을 비교한 것이다.
// 그러므로 false

// 42행
// 값형식을 비교하므로 주소값을 비교해서 true가 된다.

// 43행
// 주소값을 비교해서 false가 된다.

// 50행
// txt1이 주체가 되어 txt2와 비교하는 것이다.
// txt2이 null이므로 비교하면 false

// 51행
// txt2이 주체가 되어 txt1과 비교하는 것이다.
// txt2가 null이므로 txt2에 접근하면 오류를 뿜어낸다.
// 애초에 값이 있어야 성립하는 것.

// 52행
// 변수에 값이 없을 수 있음을 상정하고 상수와 비교를 한다.
// 51행처럼 null에 접근해서 오류를 낼 수 있음을 대비하는 방법

// 53행
// '+'를 먼저 계산하므로 무조건 false가 출력된다.

// 54행
// txt1 == txt2가 아니라 (txt1 == txt2)로 묶어줘야 한다.

// 59, 60행
// string을 char배열로 문자 하나하나씩 정해줄 수 있다.
// new string 뿐만 아니라 new char[]도 해야한다.

// 70, 71행
// GetHashCode()는 인스턴스를 고유하게 식별할 수 있는 4바이트 int값을 반환한다.
// n1과 n2의 값이 서로 같으므로 해시코드가 서로 같다.

// 72행
// n3는 값이 다르므로 해시코드가 n1과 n2와 해시코드가 다르다.

// 77, 78행
// c2와 c3는 같은 메모리를 가리키고 있으므로 같은 해시코드를 가진다.

// 79행
// c4는 c2와 c3가 가리키는 메모리와 다르므로 다른 해시코드를 가진다.

// GetHashCode()는 Equals()와 연계되는 경우가 많다.
// 해시코드는 2³²만큼 할당할 수 있다.
// 따라서 해시코드의 한계는 있으므로 서로 충돌할 수 있다.
// 이 때 Equals()를 추가로 사용하여 정말로 같은지 비교를 할 수 있다.
// 이럴거면 Equals()만 사용해도 같은지 환인할 수 있지 않나?
// 이건 좀 고민해봐야한다.