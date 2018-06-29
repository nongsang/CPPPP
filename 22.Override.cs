using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public virtual void Move()  // virtual로 가상메소드로 선언한다.
    {
        //Console.WriteLine(this.GetType() + " 이동한다");      // 인스턴스의 type을 출력한다.
        Console.WriteLine(nameof(Animal) + " 이동한다");        // Animal에서 호출하므로 Animal의 이름을 출력한다.
    }

    public override string ToString()
    {
        return nameof(Animal);
    }
}

class Lion : Animal
{
    public void Move()          // 오버라이딩이 아니므로 참조형식의 메소드가 실행된다.
    {
        Console.WriteLine(nameof(Lion) + " 네 발로 움직인다");
    }
}
class Whale : Animal
{
    public override void Move() // 오버라이딩 됬음을 알려준다.
    {
        Console.WriteLine(nameof(Whale) + " 헤엄친다");
    }
}

class Human : Animal
{
    public new void Move()      // 부모 클래스와 같은 이름의 별개의 메소드임을 알려준다.
    {
        Console.WriteLine(nameof(Human) + " 두 발로 움직인다");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        base.Move();        // 원본 메소드 호출
        Console.WriteLine(nameof(Bird) + " 날개를 움직인다");
    }
}

namespace CPPPP
{
    class Override
    {
        static void Main(string[] args)
        {
            Animal a1 = new Lion();     // 다형성을
            Animal a2 = new Whale();    // 호출하는
            Animal a3 = new Human();    // 방법
            Animal a4 = new Bird();     // 이다.

            Console.Write("Lion : ");
            a1.Move();              // Lion은 오버라이딩을 안했으므로 Animal의 메소드가 출력된다.

            Console.Write("Whale : ");
            a2.Move();              // Whale은 오버라이딩을 했으므로 Whale의 메소드가 출력된다.

            Console.Write("Human : ");
            a3.Move();              // Human은 new로 부모 클래스와 이름만 같은 메소드를 만들어줬으므로 Animal의 메소드가 출력된다.

            Console.WriteLine("Bird : ");
            a4.Move();              // 부모 클래스의 메소드와 자식 클래스의 메소드가 같으 출려된다.

            //Animal.ToString();        // static 메소드가 아니므로 불가능
            Animal a = new Animal();
            Console.WriteLine(a.ToString());
        }
    }
}

// 9행
// virtual로 가상메소드 선언을 해주었다.
// 이렇게 해줘야만 자식 클래스를 다형성으로 구현할 수 있다.

// 11행
// GetType()은 클래스 인스턴스의 Type을 출력한다.
// 부모 클래스의 메소드가 출력되는지를 판단하기 위해 사용한다면 잘못된 생각이다.

// 12행
// nameof()를 이용하여 클래스의 이름을 출력한다.
// GetType()은 인스턴스의 풀네임, 네임스페이스에 존재하면 네임스페이스까지 출력해준다.
// 메소드가 어느 클래스에 속하는지 판단하기 위해서는 다른 방법을 사용해야 한다.
// nameof()로 본인의 클래스 이름을 출력하게 한다.
// nameof()는 순수하게 클래스의 이름만 출력하므로 좀 더 단순하게 사용할 수 있다.

// 15행
// ToString()은 object형에서 기본적으로 상속을 받으므로 override로 재정의 해줄 수 있다.

// 23행
// 오버라이딩이 아니라 단순히 부모 클래스와 메소드 이름이 같은 것 뿐이다.
// C++에서 말하는 참조형식과 실형식의 구성으로 표현하면 참조형식의 메소드가 실행된다.
// 그렇기 때문에 다형성이 구현되지 못한다.

// 30행
// override 예약어를 사용하여 메소드가 오버라이딩 됬음을 알려준다.
// override를 사용해야 다형성을 구현할 수 있다.

// 38행
// new를 용하여 부모 클래스의 메소드와 자식 클래스의 메소드가 이름만 같은 별개의 메소드임을 명시적으로 알려준다.
// 이는 일부러 메소드의 이름을 같게 만들어준 프로그래머의 의도가 있음을 알려준다.

// 48행
// 부모 클래스의 메소드를 사용함을 보여준다.
// 문제는 부모 클래스를 만들었던 개발자가 자식 클래스에서 base를 호출하거나 호출하지 못해게 강제할 수 있는 방법이 없다.
// 따라서 가상 메서드를 하위 클래스에서 오버라이딩을 할 때 반드시 상위 클래스의 도움말을 확인해야 한다.
// 만약 자신이 상위 클래스의 개발자라면 이 점을 반드시 도움말에 기록해야 한다.

// 59 ~ 62행
// 부모 클래스로 자식클래스를 가리켜서 다형성을 구현한다.

// 76행
// static 메소드가 아니므로 불가능
// ToString()을 재정의할 때 static으로 선언하면 가능하다.