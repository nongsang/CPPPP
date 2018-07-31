using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test { }

namespace CPPPP
{
    class Object_Equals
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10;

            Console.WriteLine(a.Equals(b));         // true
            Console.WriteLine("10".Equals(a));      // false, 10은 정수이며 "10"은 문자열이므로 서로 다르다.
            Console.WriteLine(10.0m.Equals(a));     // ture, 10과 10.0m는 표현범위만 다른 같은 값이다.
            Console.WriteLine(a == 10.0f);          // true

            Console.WriteLine();

            Test test1 = new Test();
            Test test2 = test1;
            Test test3 = new Test();             // test1과 같은 데이터지만 다른 인스턴스

            Console.WriteLine(Equals(test1, test2));            // true
            Console.WriteLine(test1.Equals(test2));             // true
            Console.WriteLine(ReferenceEquals(test1, test2));   // true
            Console.WriteLine(Equals(test1, test3));            // false
            Console.WriteLine(test1.Equals(test3));             // false
            Console.WriteLine(test1 == test3);                  // false

            Console.WriteLine();

            string s1 = "Hello";
            string s2 = s1;
            string s3 = string.Copy(s1);                        // 새로운 인스턴스를 만들어주는 방법
            //string s3 = new string("Hello".ToCharArray());    // 이렇게 새로운 인스턴스를 만들어줘도 된다.

            Console.WriteLine(Equals(s1, s2));              // true
            Console.WriteLine(s1 == s2);                    // true
            Console.WriteLine(ReferenceEquals(s1, s3));     // false
            Console.WriteLine(s1.Equals(s3));               // true
            Console.WriteLine(s1 == s3);                    // true
        }  
    }
}

// object가 가지고 있는 Equals()를 알아본다.
// ==과 ReferenceEquals()도 같이 비교해서 보자.

// 19행
// Equals()를 사용하는 법이다.
// 값형식일 때 두 값이 서로 같으면 true, 다르면 false를 반환한다.

// 20행
// 상수에서 직접 Equals() 메소드를 호출할 수 있다.
// 비교하는 데이터는 "10"이라는 문자열이다.
// 따라서 10이라는 정수와 "10"이라는 문자열은 서로 다르기 때문에 false다.

// 21행
// 정수를 Equals() 메소드로 변수와 비교한다.
// 실수와 정수는 표현 범위만 다른 같은 데이터이기 때문에 ture

// 22행
// == 연산자 메소드로 직접 비교하는 연산이다.
// 실수와 정수는 표현 범위만 다른 같은 데이터이기 때문에 true

// 28 ~ 29행
// 인스턴스 이름.Equals(인스턴스 이름)으로 사용하는 방법과 object.Equals(인스턴스 이름, 인스턴스 이름)으로 사용하는 방법이 있다.
// 두 방법은 서로 다를게 없다.
// 클래스에서 Equals()는 같은 인스턴스를 가리키는지를 판단한다.

// 30행
// ReferenceEquals(인스턴스 이름, 인스턴스 이름)는 이렇게 사용하는 방법밖에 없다.
// 같은 인스턴스를 가리키는지를 판단한다.
// 클래스에서는 ReferenceEquals()와 Equals()는 서로 같은 의미다.

// 31 ~ 32행
// 클래스에서 Equals()와 ReferenceEquals()는 둘 다 같은 의미로, 같은 인스턴스를 가리키는지를 판단한다.
// 따라서 test1과 test3는 메모리의 내용이 같으나, 서로 다른 인스턴스를 가리키므로 false가 출력된다.

// 33행
// 클래스에서도 == 연산은 같은 인스턴스를 가리키는지를 판단한다.
// test1과 test3는 서로 다른 인스턴스를 가리키므로 false가 출력된다.

// 39행
// s1과 같은 문자열을 복사하여 새로운 인스턴스를 생성한다.

// 40행
// 이것도 문자열이 같은 새로운 인스턴스를 만드는 방법이다.

// 42 ~ 43행
// string형에서 Equals()와 ==은 서로 같은 값을 가지는지 판단하는 메소드다.
// s1과 s2가 가리키는 인스턴스의 값이 서로 같기 때문에 true를 출력한다.

// 44행
// s3는 같은 문자열을 가진 다른 인스턴스이므로 s1과 가리키는 인스턴스가 서로 다르다.
// 따라서 false를 출력한다.

// 45 ~ 46행
// s1과 s3가 같은 문자열을 가지지만 다른 인스턴스를 가지므로, Equals()와 == 모두 true를 출력한다.

// 정리
// 값형식 변수 (기본 자료형) -> a.Equals(b)    : 값비교
//                            Equals(a, b)   : 값비교
//                            a == b         : 값비교
//
// 참조형식 변수 (클래스 등) -> a.Equals(b)    : 참조위치 비교
//                            Equals(a, b)   : 참조위치 비교
//                            a == b         : 참조위치 비교
//
// string 변수는 참조형식이지만 인스턴스의 값을 비교한다.
// 그러므로 string은 값형식 변수와 똑같이 작동한다.