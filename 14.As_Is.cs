using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
    public void Show()
    {
        Console.WriteLine("Class1");
    }
}

public class Class2 : Class1
{
    public void Show()      // 오버라이드, 나중에 다시 설명
    {
        Console.WriteLine("Class2");
    }
}

public class As_Is
{
    public static void Main()
    {
        int n = 10;
        long i = (long)n;

        if(i is long)       // is는 자료형이 같은지 비교한다.
        {
            Console.WriteLine(n.GetType()); // type을 출력하는 방법
            Console.WriteLine(i.GetType());
        }

        Class1 cl1 = new Class1();
        Class2 cl2 = cl1 as Class2;         // as로 안전한 형변환을 한다.

        Console.WriteLine(cl1 is Class1);   // true
        Console.WriteLine(cl1 is Class2);   // false
        Console.WriteLine(cl2 is Class1);   // false
        Console.WriteLine(cl2 is Class2);   // false

        Console.WriteLine(cl1.GetType());
        //Console.WriteLine(cl2.GetType()); // 불가능

        cl1.Show();
        //cl2.Show();                       // 불가능

        Class2 cl4 = new Class2();
        Class1 cl3 = cl4 as Class1;         // as로 안전한 형변환을 한다.

        Console.WriteLine(cl3 is Class1);   // true
        Console.WriteLine(cl3 is Class2);   // true
        Console.WriteLine(cl4 is Class1);   // true
        Console.WriteLine(cl4 is Class2);   // true

        Console.WriteLine(cl3.GetType());   // Class2???
        Console.WriteLine(cl4.GetType());   // Class2

        cl3.Show();                         // Class1???
        cl4.Show();                         // Class2
    }
}

// 17행
// Computer 상속을 받은 Notebook 클래스에서 메소드를 오버라이드 했다.
// C++에서 똑같은 개념이지만 C#에서는 조금 다르다.
// 다음에 다시 설명

// 28행
// int형을 long형으로 명시적 형변환을 했다.
// 하지만 암묵적인 형변환이 가능하다.

// 30행
// is 예약어를 이용한 자료형 비교
// expr is type이 원형
// expr과 type이 같은지를 비교한다.
// 자료형이 같으면 true, 아닐 경우 false를 반환한다.

// 32, 33행
// GetType()을 이용하여 자료형을 구할 수 있다.
// 값형식(원시 자료형), 참조형식(클래스)을 가리지 않고 자료형을 알려준다.
// 출력해주는 타입은 닷넷형식으로 출력해준다.
// 나중에 다시 설명

// 37행
// as 예약어를 이용한 형변환
// expression as type이 원형
// expression이 클래스형일 경우에 type형 클래스로 변환이 가능한지 비교한다.
// 값형식(int, long 등)끼리는 as를 사용할 수 없다. -> 중요
// 변환 가능하면 type형으로 반환
// 변환 불가능하면 null을 반환
//
// Class1형인 cl1을 이용하여 Class2형 변수를 생성한다.
// 하지만 '사람을 소크라테스라 부른다.'는 논리는 말도 안된다.
// 따라서 as의 반환값은 null

// 39행
// Class1형 cl1 안에 Class1이 있다.
// '사람은 사람이다.'
// 논리적으로 틀릴 수 없다.
// true

// 40행
// Class1형 cl1은 Class2이다.
// '사람은 소크라테스이다.'
// 말도 안되는 논리다.
// 모든 사람은 소크라테스가 아니기 때문이다.
// false

// 41행
// Class2형 cl2는 Class1이다.
// 소크라테스는 사람이다.
// 맞는 논리다.
// 하지만 애초에 사람을 소크라테스라고 부르는 과정이 논리적으로 맞지 않다.
// false

// 42행
// Class2형 cl2는 Class2이다.
// 소크라테스는 소크라테스이다.
// 완벽한 논리이다.
// 하지만 소크라테스라고 불리는 사람들은 원래 소크라테스와 같지 않다.
// false

// 45, 48행
// cl2에 null이 저장되어 있으므로 기능을 사용할 수 없다.

// 51행
// Class2형인 cl4를 이용하여 Class1형 변수를 생성한다.
// '소크라테스는 사람이다.'
// 소크라테스라는 사람에서 '사람'이라는 기능을 빼낸 것과 같다.

// 53행
// '사람은 사람이다.'
// 완벽한 논리다.
// true

// 54행
// '사람은 소크라테스이다.'
// 말도 안된다.
// 하지만 값은 true이다.
// 어찌된 일인가?
// 51행에서 '사람을 소크라테스라 부른다.'는 의미는 소크라테스의 기능을 가진 사람을 생성한다는 의미와 같다고 할 수 있지 않을까?
// 사람은 서로 다를지언정 기능이 서로 같다.

// 55행
// '소크라테스는 사람이다.'
// 맞는 논리다.
// true

// 56행
// '소크라테스는 소크라테스다.'
// 완벽한 논리다.
// true

// 58행
// cl3은 Class1형이다.
// 하지만 GetType()을 하니 Class2형으로 출력된다.
// 부모가 자식의 기능을 사용한다고 보는게 타당하지 않은가?

// 61행
// Class1이라 출력된다.
// Class2형인데 왜 Class1의 함수를 사용하는가?
// Class2라는 확장된 자료형을 가지고 있으나 Class1의 기능만 사용할 수 있다고 생각할 수 있따.

// 앞서 봤던 형변환은 논리적인 문제가 아니라 계층문제라고 보는 것이 맞을 듯 하다.
// 자식은 부모의 기능을 사용할 수 있는가?
// 부모는 자식의 기능을 사용할 수 있는가?
// 이는 조금 더 연구해봐야 한다.