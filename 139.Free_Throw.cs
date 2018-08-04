using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;        // WriteLine()으로 줄여서 쓰고 싶어서 추가

class Person
{
    string Name { get; }

    public Person(string name) => Name = name ?? throw new ArgumentException(nameof(name)); // 생성자를 람다와 ?? 연산자의 결합으로 정의

    public string GetLastName() => throw new NotImplementedException(); // 메소드를 수행할 수 없을 때 NotImplementedException 호출

    public void Print()
    {
        Action action = () => throw new Exception();    // Action이지만 매개변수가 없으므로 _가 아니라 ()를 사용한다.
        action();
    }

    public string GetFirstName()
    {
        var parts = Name.Split(' ');

        
        return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!"); // 삼항 연산자 표현식에서 사용 가능
        // return (parts.Length > 0) ? throw new InvalidOperationException() : parts[0];        // true, false 값을 바꿔도 가능
    }
}

namespace CPPPP
{
    class Free_Throw
    {
        public static void Main()
        {
            bool Assert(bool result) =>     // 지역 함수로 람다 정의
#if DEBUG                                   // 전처리
                result = true ? result : throw new ApplicationException("ASSERT");  // C# 7.0 이후부터 가능한 throw 구문
#elif RELEASE
            result = true ? result : AssertException("ASSERT");         // C# 7.0 이전에는 메소드로 우회해서 throw을 사용해야 했다.
#else
            result;
#endif

            void assert(bool result) =>                                             // 위의 식은 아래처럼 컴파일 할 수 있다.
#if DEBUG
            _ = result == true ? result : throw new ApplicationException("ASSERT");
#elif RELEASE
            _ = result == true ? result : AssertException("ASSERT");
#else
            _ = result;
#endif
        }

        static bool AssertException(string msg)
        {
            throw new ApplicationException(msg);
        }
    }
}