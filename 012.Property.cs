using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Circle
    {
        double pi = 3.14;

        public double GetPi() { return pi; }    // getter
        public void SetPi(double value)         // setter
        {
            if (value < 3 || value > 5)
            {
                Console.WriteLine("오류");
                return;
            }
            pi = value;
        }

        public double Pi    // 프로퍼티, 메소드 형태가 아니다.
        {
            get { return pi; }  
            set
            {
                if (value < 3 || value > 5)
                {
                    Console.WriteLine("오류");
                    return;
                }
                pi = value;
            }
        }
        
    }

    class Property
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine(circle.Pi);

            circle.Pi = 10;
            Console.WriteLine(circle.Pi);

            circle.SetPi(3.14);
            Console.WriteLine(circle.GetPi());
        }
    }
}

// 13 ~ 22행
// C++에서 많이 본 getter와 setter다.
// getter와 setter는 이후 코드의 유지보수를 쉽게 하기 위해 사용하는 것이다.
// 범위를 벗어난 값을 검출하거나 디버그를 위해 만들어 놓는 것이다.

// 24 ~ 36행
// getter와 setter를 C#에서는 get과 set이라는 기능으로 제공해준다.
// 매번 getter와 setter를 정의해주기 힘들기 때문이다.
// 24행에서는 새로운 double형 변수 Pi를 public으로 접근할 수 있게 한다.
// get은 값을 반환, set은 값을 설정하는 역할이다.
// setter는 매개변수를 받아서 값을 설정하는데, set에서는 value라는 예약어가 매개변수의 역할을 한다.

// 48, 49행
// Pi를 호출하여 pi의 값을 출력할 수 있다.
// getter는 정의한 함수를 호출해야 하나, get은 새롭게 만들어준 변수로 접근하면 되는 것이다.
// set 또한 마찬가지로 새로운 변수에 값을 전달해주면 예약어인 value가 매개변수가 되어 값을 저장한다.

// 한가지 중요한 것은 getter, setter를 편하게 쓰기위해 get, set을 제공한다는 것이다.
// 24 ~ 36행처럼 get, set을 사용해도 13 ~ 22행처럼 자동으로 메소드를 분리해서 컴파일한다.
// 48, 49행도 51, 52행으로 자동으로 코드가 변경되어 컴파일 된다.