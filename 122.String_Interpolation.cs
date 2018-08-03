using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        //return "이름: " + Name + ", 나이: " + Age;                    // 이렇게 많이 쓰면 성능이 별로 좋지 않기 때문에

        //return string.Format("이름: {0}, 나이: {1}", Name, Age);      // 성능을 생각하면 Format을 많이 사용한다.

        return $"이름: {Name}, 나이: {Age}";                            // Format을 좀더 약식으로 사용하는 방법이다.

        // 컴파일 후 아래의 코드로 변경됨
        // return string.Format("이름: {0}, 나이: {1}", Name, Age);

        // 중괄호 자체를 출력에 포함하고 싶은 경우
        // return $"{{이름: {Name}, 나이: {Age}}}"; // {이름 = Anders, 나이 = 49}

        // 3항 연산자를 사용하는 것도 가능하고,
        // return $"이름: {Name.ToUpper()}, 나이: {(Age > 19 ? "성년" : "미성년")}";

        // 067.String_Format에서 했던 문자 간격이나 형식을 지정할 수 있다.
        // return $"이름: {Name,-10}, 나이: {Age,5:X}";

        // 070.Regular_Expression에서 사용했었으니 다시 확인해보도록
    }
}

namespace CPPPP
{
    class String_Interpolation
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Anders", Age = 49 };
            Console.WriteLine(person);                                  // 출력결과: 이름 = Anders, 나이 = 49
        }
    }
}