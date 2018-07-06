using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Vector       // 벡터는 구조체
{
    public int x;   // 멤버에 값을 안넣고 선언한다.
    public int y;   // 어차피 초기화 불가능
}

class Point         // 포인트는 클래스
{
    public int x;   // 멤버에 값을 안넣어줘도
    public int y;   // 자동으로 0으로 초기화
}

namespace CPPPP
{
    class Ref
    {
        static void ChangeVector1(Vector vt)       // 1번 벡터용 메소드, Call By Value
        {
            vt.x = 7;
            vt.y = 14;
        }

        static void ChangeVector2(ref Vector vt)   // 2번 벡터용 메소드, Call By Reference
        {
            vt.x = 7;
            vt.y = 14;
        }

        static void ChangePoint1(Point pt)       // 1번 포인트용 메소드, Call By Value
        {
            pt = new Point();   // 클래스는 이렇게 할당을 안하면

            pt.x = 7;           // 값을
            pt.y = 14;          // 저장할 수 없다.
        }

        static void ChangePoint2(ref Point pt)   // 2번 포인트용 메소드, Call By Reference
        {
            pt = new Point();

            pt.x = 7;
            pt.y = 14;
        }

        public static void Main()
        {
            Vector v1;
            v1.x = 5;       // x는 5
            v1.y = 10;      // y는 10
            ChangeVector1(v1);     // 1번 벡터용 메소드가 호출된다.
            Console.WriteLine("v1.x : " + v1.x + " v1.y : " + v1.y);    // 그래서 값이 안바뀜

            Console.WriteLine();

            Vector v2;
            v2.x = 5;       // 이번에도 x는 5
            v2.y = 10;      // y는 10
            ChangeVector2(ref v2); // 2번 벡터용 메소드가 호출된다.
            Console.WriteLine("v2.x : " + v2.x + " v2.y : " + v2.y);    // 그래서 값이 바뀜

            Console.WriteLine();

            Point p1 = null;    // class는 null로 초기화를 해줘야 한다.
            ChangePoint1(p1);
            //Console.WriteLine("p1.x : " + p1.x + " p1.y : " + p1.y);    // 값이 반환이 되지 않아서 출력이 불가
            Console.WriteLine("p1 : " + p1);

            Console.WriteLine();

            Point p2 = null;
            ChangePoint2(ref p2);
            Console.WriteLine("p2.x : " + p2.x + " p2.y : " + p2.y);    // 값이 전달됬으므로 출력 가능
            Console.WriteLine("p2 : " + p2);        // 클래스 이름이 출력
        }
    }
}

// 7 ~ 11행
// 벡터는 구조체로 구현했다.
// 따라서 값형식을 따른다.

// 13 ~ 17행
// 포인트는 클래스로 구현했다.
// 따라서 참조형식을 따른다.

// 23 ~ 27행
// 벡터를 매개변수로 받는 메소드다.
// Call By Value를 보기 위해서 구현

// 29 ~ 33행
// 벡터의 주소를 매개변수로 받는 메소드다.
// Call By Reference를 보기 위해서 구현.
// C++에서 매개변수를 받을 때 &로 선언한 것과 같다.

// 35 ~ 41행
// class형인 포인트로 Call By Value를 구현하기 위해 정의
// 클래스형을 받았으므로 new로 할당을 한 후에 사용해야 한다.

// 43 ~ 49행
// Call By Reference를 보기 위해서 구현

// 53 ~ 57행
// 구조체인 Vector를 메소드에 그냥 전달했다.
// 그 결과 Vector의 멤버는 값이 바뀌지 않았다.
// 왜냐하면 벡터를 복사하여 값을 바꾸기 때문이다.
// 즉, 메소드 안에서는 복사한 벡터를 바꾼 것이지, 원본 벡터를 바꾼것이 아니다.
// 따라서 Call By Value로 구현되기 때문에 문제가 생길 수 있다.

// 61 ~ 65행
// 구조체인 Vector를 ref로 선언하여 전달하였다.
// 그냥 보내면 값형식인 Vector를 복사하여 전달하지만 ref를 선언하여 보내면 객체의 주소값을 전달한다.
// 그렇기 때문에 포인터로 Call By Reference를 구현한 것이다.

// 69 ~ 72행
// Point는 클래스이므로 그냥 사용할 수 없다.
// 나중에 사용할 생각이면 null로 초기화 해야 한다.
// 메소드 안에서 new로 할당하여 사용했다해도 메소드가 끝나는 순간 할당된 인스턴스가 사라지면서 사용할 수 없게된다.
// 이것이 Call By Value의 문제점이다.

// 76 ~ 79행
// Point를 ref로 전달하였다.
// ref로 전달하면 인스턴스를 가리키게 되므로 메소드에서 값을 바꾸면 그대로 사용이 가능하다.
// Call By Reference를 사용하면 가능해진다.