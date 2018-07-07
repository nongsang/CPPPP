using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Scheduler
{
    readonly int second = 1;    // 읽기 전용
    readonly string name;       // 읽기 전용

    public Scheduler() { this.name = "일정관리"; }      // 생성자에서는 초기화 가능

    public void Run()
    {
        //this.second = 5;      // 일반 메소드에서 읽기 전용 멤버에 값을 전달할 수 없다.
    }
}

namespace CPPPP
{
    class Readonly_Const
    {
        const string TEXT = " 변수의 값 : ";    // 상수로 고정

        public static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine("x 변수의 값 : " + x);    // 이렇게
            Console.WriteLine("y 변수의 값 : " + y);    // 하는 것보다

            Console.WriteLine("x" + TEXT + x);         // 이렇게 하는게
            Console.WriteLine("y" + TEXT + y);         // 훨씬 좋다.
        }
    }
}

// 9, 10행
// const와 다르게 readonly로 읽기 전용으로 만들었다.

// 12행
// readonly는 생성자로 초기화해줄 수 있다.
// const는 값을 정해주지 않아도 그냥 상수로 정해지지만 readonly는 초기화 기회가 주어진다.

// 16행
// 일반 메소드에서 readonly로 선언된 멤버의 값을 변결할 수 없다.

// 24행
// readonly가 아니라 const로 선언했다.
// 명백하게 상수로 재사용함을 알려준다.

// 31, 32행
// 일반적인 UI 구현 방법이다.
// 하지만 만약 요구사항에서 '~변수의 값'에서 '~ ==' 이라고 표현한다면?
// 일일히 바꿔야하는 부분을 찾아서 바꿔줘야 한다.

// 34, 35행
// 따라서 앞서 const로 선언한 상수를 정해놓으면 유지보수가 편해진다.
// 요구사항이 바뀌어도 상수값만 바꾸면 되니까 말이다.

// readonly와 const는 둘 다 상수로 처리되는 특성이 있다.
// 정확하게 두 예약어의 차이는, readonly는 런타임 상수, const는 컴파일 상수라는 것이다.
// readonly는 런타임에 값이 주어지고 상수로 지정이 된다.
// const는 컴파일 타임에 값이 정해져야 한다.
// 따라서 재사용만을 위한다면 const로 하는 것이 좋고, 그 밖에는 readonly가 좋다.
// 유연성이 좋기 때문이다.