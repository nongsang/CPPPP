using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    decimal isbn;

    public Book(decimal isbn)
    {
        Console.WriteLine("Book(decimal)");
        this.isbn = isbn;
    }

    public void Close()
    {
        Console.WriteLine("책 닫음");
    }
}

class EBook : Book
{
    //public EBook()
    //{
    //    // 자식 클래스가 디폴트 생성자를 호출하지만 부모 클래스는 디폴트 생성자가 없으므로 오류
    //    // 부모 클래스에서 디폴트 생성자를 만들든지
    //}

    public EBook() : base(0)
    {
        // base는 부모 클래스를 명시적으로 가리키는데 사용한다.
        // 따라서 EBook()의 생성자를 호출하면 부모클래스의 매개변수가 1개 있는 생성자에 0을 넣고 호출한다.
        Console.WriteLine("EBook()");
    }

    public EBook(decimal isbn) : base(isbn)
    {
        // 이렇게 연계도 가능하다.
        Console.WriteLine("EBook(decimal)");
    }

    public void HomeButton()
    {
        base.Close();       // 명시적으로 부모의 기능을 사용하겠다는 뜻.
        //Close();          // 묵시적으로 부모의 기능을 사용하겠다는 뜻.
    }
}

namespace CPPPP
{
    class Base
    {
        static void Main(string[] args)
        {
            EBook eBook1 = new EBook();                 // Book(decimal), EBook()
            EBook eBook2 = new EBook(1234567890123);    // Book(decimal), EBook(decimal)
        }
    }
}

// 25 ~ 29행
// 자식 클래스는 디폴트 생성자를 호출하지만 부모는 디폴트 생성자가 없으므로 오류가 발생한다.
// 부모 클래스에도 디폴트 생성자를 만들든지, 아니면 다른 방법으로 해결해야 한다.

// 31 ~ 36행
// base는 명시적으로 부모 클래스를 가리키는 방법이다.
// base(0)은 부모 클래스 생성자에 0을 인수로 넘겨주고 호출한다.
// 부모 클래스에는 매개변수가 1개인 생성자가 존재하므로 오류가 발생하지 않게된다.

// 38 ~ 42행
// 자식 클래스로 값을 받아서 부모 클래스의 멤버를 초기화하는 방법이 있다.

// 44 ~ 48행
// 명시적으로 부모 클래스의 메소드를 사용하는 방법과 묵시적으로 사용하는 방법이다.
// 어떤걸 쓸지는 프로그래머 몫이다.
// 웬만하면 명시적인게 좋을 것이다.

// 이 방법은 C++의 '생성자 상속'으로 소개한 바 있다.
// CPP_Abstraction/42.constructor_inheritance.cpp에 설명되어 있다.