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
    public void Show()
    {
        Console.WriteLine("Class2");
    }
}

namespace CPPPP
{
    public class As_Is
    {
        public static void Main()
        {
            int i = 10;

            bool v = i is object;       // i를 object라고 부를 수 있는가?

            //bool v = int is object;   // '자료형 is 자료형'형식으로 쓸 수 없다.

            if (v)      // true
            {
                Console.WriteLine("int형은 Object형이다.");
            }

            bool b = i is sbyte;         // int형은 sbyte라고 부를 수 있는가?

            if (b)      // false
            {
                Console.WriteLine("int형은 sbyte형이다.");
            }

            Class2 c2 = new Class2();
            Class1 c1 = c2 as Class1;   // c2가 Class1과 호환되면 c2의 메모리를 가리키게 한다.

            if (c2 is Class1) Console.WriteLine("c2는 Class1이다.");   // 이건 당현히 가능

            if (c1 is Class2) Console.WriteLine("c1은 Class2이다.");   // 이건 왜 가능?

            if (ReferenceEquals(c1, c2)) c1.Show();     // 왜 Class1이지?

            Type type = c2.GetType();       // Type을 받아와서 쓰는게 정석이다.

            Console.WriteLine(type);        // 이건 당연히 Class2

            Console.WriteLine(c1.GetType());// c2를 Class1으로 형변환해서 저장했는데 왜 Class2라 뜨지?
        }
    }
}

// 31행
// int형인 i를 object형이라 부를 수 있는가?
// 가능하면 true, 불가능하면 false를 반환한다.
// object형 객체는 int나 double같은 기본 자료형을 포함하여 어떤 클래스보다 상위의 존재다.
// 한마디로 object는 모든 객체의 최고조상 클래스다.
//
// is형과 ==, Equals(), object.ReferenceEquals()는 작동방식이 조금씩 다르다.
// is는 호환이 가능한가?를 판별한다.
// 즉, 논리적인 물음에 참, 거짓을 판단하여 bool형을 반환한다.
//
// ==, Equals(), object.ReferenceEquals()는 값형식, 참조형식에 따라서 메모리 혹은 메모리값이 서로 같은가?를 판단하는 것이다.
// 논리적인 물음보다 실질적으로 값이 서로 같냐, 혹은 같은 메모리를 공유하고 있느냐를 판단하는 것이다.
// 이에 대해서는 따로 연구하여 올린다.

// 33행
// is는 '인스턴스 is 객체'형식으로 사용해야 한다.
// '객체 is 객체'와 같은 형식으로 사용하려 하기 때문에 사용이 불가능하다.

// 35 ~ 38행
// 31행이 true이면 실행이 된다.
// 어떤 객체든 object 객체라고 부를 수 있기 때문에 무조건 참이 되므로 항상 실행된다.

// 40행
// int형인 i를 sbyte형이라 부를 수 있는가?
// int, char, byte, double 등등 기본 자료형들은 object에서, 그리고 System.ValueType에서 파생이 됬다.
// object는 참조형이지만 값형식을 따르는 따르는 객체들을 정의하기 위해 System.ValueType을 상속하여 정의하였다.
// object는 System.ValueType를 상속하고 각 기본 자료형을 또 상속한다.
// 따라서 각 기본 자료형들은 같은 부모를 상속받은 별개의 객체이기 때문에 서로 호환이 되지 않는다.
// 결과적으로 false를 반환한다.

// 42 ~ 45행
// 40행이 false이므로 문자열이 출력되지 않는다.

// 48행
// as는 is와 비슷하지만 조금 다르다.
// as는 호환이 되는지 판단하는 것 뿐만 아니라 호환이 가능하다면 인스턴스를 가리키게끔 한다.
// 호환이 불가능하다면 null을 반환하게 된다.
// c2는 Class1을 상속받은 Class2형이기 때문에 Class1과 호환이 가능하다.
// 따라서 c1은 c2가 가리키는 메모리를 Class1으로서 가리킬 수 있는 것이다.

// 50행
// c2는 Class1형과 호환이 가능하므로 문장이 출력된다.

// 52행
// c1은 Class1형이므로 Class2형과 호환이 불가능하다.
// 다르게 말하자면 Class1을 Class2라고 부르는 것이 불가능하다는 뜻이다.
// '사람은 소크라테스다.'와 같은 문장이라고 보면 된다.
// 하지만 true가 나오게 되면서 문장이 출력된다.
//
// 이게 어찌된 일인지?
// c1은 참조형에 불과하며 실질적인 자료형은 Class2형이다.
// 따라서 'Class2형은 Class2형이다.'와 같은 문장이 되므로 참이 된다.

// 54행
// c1과 c2가 같은 메모리를 참조하고 있는지 판별하는 메소드다.
// 두 변수가 같은 메모리를 참조하므로 true가 나오게 되면서 문장이 출력된다.
// c1이 참조하는 메모리는 c2와 같으니 Class2라고 출력되겠지?
// 하지만 Class1이라고 출력된다.
// 이게 어찌된 일?
//
// C++에서 배웠던 참조형식과 실형식에 대한 내용과 같다.
// virtual이 아닌 참조는 참조형식으로 출력이 된다.

// 56행
// GetType()은 class의 타입 정보를 가지고 있는 System.Type의 인스턴스를 가져오는 메소드다.
// 그렇기 때문에 c2.GetType()은 c2의 class타입을 가져와서 type에 저장하는 것이다.

// 58행
// type을 출력하면 c2의 class타입을 출력하게 된다.
// c2는 Class2형이므로 당연히 Class2형이라고 출력된다.

// 60행
// c1은 Class1형인데 왜 Class2형이라 출력되지?
// 56행의 설명보다 더 정확히 말하자면 c1이 참조하는 메모리가 Class2형이기 때문이다.
// GetType()은 참조형식의 타입을 알려주는 것이 아니라 실형식의 타입을 알려준다.