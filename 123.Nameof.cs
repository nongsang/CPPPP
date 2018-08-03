using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Nameof
    {
        static void OutputPerson(string name, int age)
        {
            WriteLine($"name == {name}");   // 정규표현식을 써서 name ==,  age == 까지는 반드시 들어가는 문자열이다.
            WriteLine($"age == {age}");     // 하지만 만약 매개변수의 이름이 바뀐다면 name과 age라는 문자열을 일일히 찾아서 바꿔줘야 한다.
                                            // {변수 명}은 정규표현식에서 변수 값을 사용하는 방법이다.
            WriteLine($"{nameof(name)} == {name}"); // nameof()는 변수, 클래스 등등을 소속 없이 순수하게 이름만 반환한다.
            WriteLine($"{nameof(age)} == {age}");   // typeof()는 소속까지 표현하여 반환한다.
        }

        public static void Main()
        {
            OutputPerson("바보", 12);     // 그냥 내용을 전달하는 것.
        }
    }
}