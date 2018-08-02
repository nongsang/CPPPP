using System;
using System.Collections;
using System.Collections.Generic;       // List<T>를 사용하기 위해 추가
using System.Linq;                      // IEnumerable의 확장 메소드를 사용하기 위해 추가
using System.Text;
using System.Threading.Tasks;

static class ExtensionMethodSample      // static 클래스임에 주의한다.
{
    // string은 sealed로 봉인된 클래스이므로 상속이 불가능하다.
    // 하지만 string 객체의 기능을 내가 정의하여 사용하고 싶다면?
    // 메소드를 확장하면 된다.
    // 클래스도 static, 메소드도 static으로 선언하였다.
    // static 메소드의 매개변수에 확장하고 싶은 객체와 this로 선언하면 메소드를 확장할 수 있다.
    public static int GetWordCount(this string txt)
    {
        return txt.Split(' ').Length;   // 들어온 string을 띄어쓰기로 나누어 길이를 세서 반환하는 기능
    }
}

namespace CPPPP
{
    class Extention_Method
    {
        public static void Main()
        {
            string text = "Hello, World!";

            Console.WriteLine("Count: " + text.GetWordCount());         // string의 기능을 내가 만든 메소드로 확장했다.

            Console.WriteLine("Count: " + ExtensionMethodSample.GetWordCount(text));    // 같은 의미

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(list.Min());      // LINQ에 정의되어있는 IEnumerable 확장 메소드를 사용했다.
        }
    }
}