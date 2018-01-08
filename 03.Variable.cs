using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Hello_World
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = n1;    // 값형식
            
            Console.WriteLine("n1 : " + n1);    // 문자열을 +로 연결할 수 있다.
            Console.WriteLine("n2 : " + n2);

            string s1 = "바보";
            string s2 = s1; // 참조형식

            Console.WriteLine("s1 : " + s1);
            Console.WriteLine("s2 : " + s2);
        }
    }
}

// 14행
// 기본 자료형인 int형 변수로 다른 int형 변수를 생성한다.
// 이때는 스택에 같은 값을 가진 int형 변수를 새롭게 생성하게 된다.
// 이를 '값 형식'이라고 한다.

// 16행 WriteLine()은 문자열에 +로 붙여서 문자열로 표현이 가능하다.
// +로 붙는 변수는 문자열이여도 되고, 다른 변수여도 상관없다.
// 디버그용으로 많이 쓴다.

// 20행
// C++에도 있던 string을 C#에서도 사용한다.
// const char* 대신으로 사용한다.
// 다른 점은 데이터 영역에 생성하는 것이 아니라 힙 영역에 생성한다.
// 기존에 생성한 string 데이터로 다른 string 데이터를 생성하면
// string형 변수로 stirng 변수를 생성하면 값이 같은 변수를 생성하는 것이 아니다.
// 스택에 string형 변수를 생성하고 기존 string변수가 가리키는 힙 데이터를 참조하는 것이다.
// 이를 참조 형식이라 한다.