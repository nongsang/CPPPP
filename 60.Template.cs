using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book<T>       // 템플릿 한개를 사용한 클래스
{
    T data;
    T name;

    public T Data
    {
        get { return data; }
        set { data = value; }
    }

    public void Show(T name)        // 매개변수도 템플릿으로 사용가능
    {
        this.name = name;               // 매개변수를 object로 해도 같은 결과가 나오지만
        Console.WriteLine(this.name);   // 값형식이 들어오면 참조형으로 변환을 하므로 성능저하가 일어난다.
    }                                   // 이를 박싱(boxing)이라고 한다.
}

class Book<T,N>     // 템플릿 2개 사용 가능
{
    T name;
    N Author;

    public T Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Show(T name, N Author)  // 각각을 매개변수로 사용 가능
    {
        Console.WriteLine("바보");      // 반대로 System.ValueType으로 매개변수를 만들고 참조형식을 던지면 값형식으로 변환해야 한다.
    }                                   // 이를 언박싱(unboxing)이라고 한다.
}                                       // 박싱과 언박싱이 일어나면 성능저하가 일어나므로 템플릿을 사용하면 박싱 언박싱이 일어나지 않는다.
                                        // 이렇게 자료형에 구애받지않고 프로그래밍을 하는 방법을 제너릭 프로그래밍이라고 한다.
namespace CPPPP
{
    class Generic
    {
        public static void Main()
        {
            Book<int> intBook = new Book<int>();    // 템플릿을 1개 사용한 클래스 호출

            Book<string, string> book = new Book<string, string>(); // 템플릿을 2개 사용하는 클래스 호출
            book.Show("사람", "멍청이");     // 각각의 값을 던져줘야 한다.
        }
    }
}