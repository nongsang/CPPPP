using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    // 인스턴스 필드
    string title;
    decimal isbn;
    string author;

    static int count;   // 정적 멤버

    public Book(string title, decimal isbn, string author)  // 모든 생성자는 이 생성자를 호출한다.
    {
        
        this.title = title;     // this가 붙은 변수는 필드를 뜻하고
        this.isbn = isbn;       // 저장하려는 값은
        this.author = author;   // 매개변수이다.
        ++count;                // 생성자에서 정적 멤버 호출가능하다.
        //++(this.count);       // 정적 멤버에는 this로 사용이 불가능하다.
    }

    public Book(string title) : this(title, 0)  
    {
        // 매개변수가 1개인 생성자를 정의할 때 this를 이용하여 재정의 해준다.
        // this로 매개변수 2개를 넣고 호출했으므로 매개변수가 2개인 생성자를 호출한다.
        // 따라서 Book(string title, decimal isbn)이 호출된다.
    }

    public Book(string title, decimal isbn) : this(title, isbn, string.Empty)
    {
        // 매개변수가 2개인 생성자를 정의할 때 this를 이용하여 재정의 해준다.
        // this로 매개변수 3개를 넣고 호출했으므로 매개변수가 3개인 생성자를 호출한다.
        // 따라서 Book(string title, decimal isbn, string author)이 호출된다.
    }

    public Book() : this(string.Empty, 0, string.Empty)
    {
        // 디폴트 생성자를 호출할 때 this를 이용하여 재정의 해준다.
        // this로 매개변수 3개를 넣고 호출했으므로 매개변수가 3개인 생성자를 호출한다.
        // 따라서 Book(string title, decimal isbn, string author)이 호출된다.
        // 결국 Book(string title, decimal isbn, string author)를 호출하게 된다.
    }

    public void Show()
    {
        Console.Write(title + ", ");
        Console.Write(isbn + ", ");
        Console.WriteLine(author);
    }

    public static void Count()   // 정적 메소드
    {
        Console.WriteLine("책 수 : " + count);   // 정적 메소드에서 정적 멤버 사용가능
    }

    public void Close()
    // 컴파일러가 84행을 85행처럼 자동으로 해석하기 때문에, 실제로 번역되는 것은 Close(Book this)이다.
    {
        Console.WriteLine(this.title + " 책을 덮는다.");
        --count;    // 메소드에서 정적 멤버 사용가능
        Console.WriteLine("책 수 : " + count);
    }
}

namespace CPPPP
{
    class This
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("C");
            Book book2 = new Book("C++", 1234567890123);
            Book book3 = new Book("C#", 3210987654321, "Lion");
            Book book4 = new Book();

            book1.Show();       // C, 0,
            book2.Show();       // C++, 1234567890123,
            book3.Show();       // C#, 3210987654321, Lion
            book4.Show();       //  , 0,

            Console.WriteLine();

            Book.Count();       // 4

            Console.WriteLine();

            book1.Close();      // 3
            //book1.Close(book1);   // 실제로 번역되는 것은 다음과 같다.
        }
    }
}

// 10 ~ 12행
// 인스턴스를 생성하면 각 인스턴스가 고유하게 소유하고 있는 필드들이다.

// 14행
// 정적 필드이다.
// 몇개의 객체가 존재하는지 세기 위해서 만들었다.
// 어떤 특정한 인스턴스만 접근가능한 것이 아니며, 모두가 공유할 수 있다.

// 16 ~ 24행
// 앞으로 모든 초기화 코드는 이 코드에서 처리한다.

// 22행
// 정적 멤버는 생성자에서 접근이 가능하다.

// 23행
// 정적 멤버는 this를 이요해서 접근할 수 없다.
// 왜냐하면 정적 멤버는 어떤 특정한 인스턴스가 독점하여 사용하는 요소가 아니기 때문이다.

// 26 ~ 29행
// 매개변수가 1개인 생성자를 정의해줬다.
// 중요한 것은 생성자를 오버로딩한 것이 아니다.
// this를 이용하여 이미 정의되어 있는 생성자를 이용한다.
// this로 매개변수가 2개인 생성자를 호출한다.
// 따라서 매개변수에 1개만 넣어서 인스턴스를 생성하면 31 ~ 34행에 정의되어있는 생성자를 실행한다.

// 31 ~ 34행
// 매개변수가 2개인 생성자를 정의해줬다.
// 이 생성자도 오버로딩을 해준 것이 아니다.
// 매개변수에 2개만 넣어서 인스턴스를 생성하면 원생성자인 16 ~ 24행에 정의된 생성자를 실행한다.

// 36 ~ 39행
// 디폴트 생성자를 정의해줬다.
// 역시 this를 이용해서 처음에 정의해주었던 생성자에 값을 전달하여 실행한다.

// 48 ~ 51행
// 정적 메소드를 정의해주었다.
// 이 메소드는 인스턴스를 생성해주지 않아도 사용할 수 있다.
// 정적 메소드에서도 정적 멤버에 접근할 수 있다.

// 53 ~ 69행
// 일반 메소드를 정의해주었다.
// 이 메소드는 인스턴스를 생성해주어야 사용할 수 있다.
// 일반 메소드에서도 정적 멤버에 접근할 수 있다.

// 54행
// 85행에 의해서 컴파일러가 메소드를 자동으로 번역한다.

// 68 ~ 71행
// 각 매개변수의 갯수를 다르게하여 인스턴스를 생성한다.

// 73 ~ 76행
// 각 인스턴스의 저장된 멤버들을 출력한다.

// 80행
// 정적 멤버변수에 접근하는 방법이다.
// 정적이기 때문에 인스턴스를 만들어주지 않아도 접근이 가능하다.

// 85행
// 일반적으로 84행처럼 메소드를 사용하지만 컴파일러는 다르게 번역한다.
// 메소드에 자기 자신을 인수로 전달한다.
// 그렇기 때문에 컴파일러는 메소드를 54행처럼 번역하여 사용한다.
// 인스턴스를 가리키는 변수를 생성하므로 성능이 하락하게 된다.
// 따라서 인스턴스 멤버에 접근할 때는 정적 메소드를 만들어서 사용하는 것이 성능상 유리하다.
// 물론 컴퓨터 성능이 대부분 좋으니 무시해도 상관없다.