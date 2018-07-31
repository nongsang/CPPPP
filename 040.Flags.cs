using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    enum Days { Sunday = 1, Monday = 2, Tuesday = 4, Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64 }

    [Flags]     // 플래그를 쓰면 enum의 인스턴스가 여러개의 enum값을 포함하는 용도로 선언
    enum Language { C, Java, Python }

    class Flag
    {
        public static void Main()
        {
            Days workingDays = Days.Monday | Days.Wednesday | Days.Friday;    // enum의 다중값

            Console.WriteLine(workingDays);         // 정수값을 모두 더해서 출력

            Console.WriteLine(workingDays.HasFlag(Days.Friday));    // 다중값 중 Friday가 존재하는가
            Console.WriteLine(workingDays.HasFlag(Days.Sunday));    // 다중값 중 Sunday가 존재하는가

            Language languages = Language.C | Language.Java | Language.Python;

            Console.WriteLine(languages);   // Language는 Flags로 선언했으므로 enum으로 출력
        }
    }
}

// 9행
// enum 요소 하나하나에 값을 정의

// 11, 12행
// enum을 사용하기 앞서 Flags로 특성(Attribute)을 지정할 수 있다.
// Flags는 enum 인스턴스에 여러개의 enum값을 저장할 수 있게 해준다.

// 18행
// enum의 인스턴스에 여러개의 enum값을 저장할 수 있다.

// 20행
// enum의 인스턴스를 출력하면 enum의 정수값을 더하여 출력한다.
// enum값은 정수가 맞지만 일반적으로 생각하는 것은 enum값을 순서대로 출력하는 것이다.
// 이건 다른 방법이 필요하다.

// 22, 23행
// HasFlag()로 enum 인스턴스에 해당하는 enum값이 존재하는지 판별한다.

// 25행
// 마찬가지로 enum 인스턴스에 여러개의 enum값을 저장한다.
// 18행 같지만 다른 것은 Language는 Flags로 선언했다.
// 그래도 여기서는 달라진건 없다.

// 27행
// enum을 Flags로 선언했기 때문에 인스턴스를 출력하면 enum값을 정수가 아닌 string으로 출력한다.