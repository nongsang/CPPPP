using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Book  // 반드시 클래스를 만들고 사용하자
    {
        // 필드
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;

        // 메소드
        public void Open()
        {
            Console.WriteLine("Book is Opened");
        }

        public void Close()
        {
            Console.WriteLine("Book is Closed");
        }
    }

    class Class
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book(); // 클래스의 인스턴스 생성

            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920775m;
            gulliver.Title = "걸리버 여행기";
            gulliver.Contents = "...";
            gulliver.PageCount = 384;

            gulliver.Open();
            gulliver.Close();
        }
    }
}

// 9 ~ 18행
// C/C++에서 처럼 클래스를 정의할 수 있다.
// C/C++과 다른 것은 반드시 클래스 내부에 멤버변수와 멤버함수를 정의하고 사용해야 한다는 것이다.

// 12 ~ 16행
// 멤버변수들이다.
// C#에서는 멤버변수를 필드라고 부른다.
// C/C++과 문법이 다른 점은 필드 하나하나마다 한정자를 붙여줘야 한다는 것이다.
// 한정자에 대해서는 다음에 자세히 알아본다.

// 19 ~ 27행
// 멤버함수들이다.
// C#에서는 멤버함수를 메소드라고 부른다.
// 역시 한정자를 하나하나 지정을 해줘야 한다.

// Class가 많이 있어도 Main()메소드를 가진 클래스를 식별하니 걱정하지 않아도 된다.