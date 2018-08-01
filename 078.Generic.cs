using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book<T>                   // 제너릭 한개를 사용한 클래스
{
    T data;                     // 모든 필드를 전부
    T name;                     // 제너릭으로 선언할 수 있다.

    public T Data
    {
        get { return data; }
        set { data = value; }
    }

    public void Show(T name)    // 매개변수도 제너릭 선언이 가능하다.
    {
        this.name = name;               // 매개변수를 object로 해도 같은 결과가 나오지만
        Console.WriteLine(this.name);   // 값형식이 들어오면 참조형으로 변환을 하므로 성능저하가 일어난다.
    }
}

class Book<T, N>                // 제너릭 2개 사용 가능
{
    T name;                     // 각 제너릭을
    N Author;                   // 변수로 선언 가능

    public T Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Show(T name, N Author)  // 각각을 매개변수로 사용 가능
    {
        Console.WriteLine("바보");
    }
}

namespace CPPPP
{
    class Generic
    {
        static void Show<T>(T item)     // 메소드도 제너릭 사용 가능
        {
            Console.WriteLine(item);
        }

        public static void Main()
        {
            Book<int> intBook = new Book<int>();                    // 템플릿을 1개 사용한 클래스 호출

            Book<string, string> book = new Book<string, string>(); // 템플릿을 2개 사용하는 클래스 호출
            book.Show("사람", "멍청이");                             // 각각의 값을 던져줘야 한다.

            Show<int>(10);      // 제너릭 메소드 호출
            Show(10);           // 타입을 쓰지 않아도 자동으로 타입을 정의한다.
        }
    }
}

// 기존 콜렉션은 object로 값을 받기 때문에 박싱 문제가 있었다.
// 박싱/언박싱 문제를 없애기 위해서 제너릭을 사용하면 된다.
// Collections.Generic에 있는 자료구조는 모두 제너릭으로 구형이 되어 있기 때문에 박싱 언박싱 문제없이 사용할 수 있다.