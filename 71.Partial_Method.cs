using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

partial class Person        // 부분 메소드는 부분 클래스에서 먼저 선언해야 한다.
{
    //partial void Print()          // 메소드는 파티셜 선언하고 그냥 정의하면 안된다.
    //{
    //    Console.WriteLine("바보");
    //}

    partial void Print();   // 선언만 하고 다른 부분 클래스에서 정의해주는 것이다.

    public void Log()   // 부분 메소드를 사용하고 싶으면
    {
        this.Print();   // 이렇게 다른 public 메소드에서 선언할 수 밖에 없다.
    }                   // 부분 메소드는 전부 static이며, private이기 때문이다.
}

partial class Person        // 앞서 부분 클래스에서 선언한 부분 메소드를 정의할 수 있다.
{
    partial void Print()        // 메소드의 파티셜 선언은 선언과 정의를 나누기 위한 것이다.
    {
        Console.WriteLine("멍청이");   // partial 메소드는 public으로 선언이 불가능하다.
    }                                 // new, abstract, virtual, override, sealed 전부 안된다.
}                                     // 왜냐하면 partial 메소드는 전부 static이기 때문이다.

namespace CPPPP
{
    class Partial_Method
    {
        // 일반 메소드는 partial로 메소드를 나눌 수 없다.
        // 부분 메소드의 partial은 정의를 따로 나눠놓는다를 의미하는게 아니다.
        // 선언과 정의를 나눠놓는다는 의미다.
        // partial 메소드는 부분 클래스에서만 선언하고 정의할 수 있다.
        //partial static void Print()
        //{
        //    Console.WriteLine("바보");
        //}

        public static void Main()
        {
            Person person = new Person();       // 부분 메소드를 쓰고싶으면

            person.Log();   // public 메소드에서 호출해야 한다.
        }                   // 어차피 부분 클래스, 부분 메소드 잘 안쓴다.
    }                       // 엄청 잘 쓰겠다는 생각은 안해도 된다.
}