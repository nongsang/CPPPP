using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer { }  // 그냥 클래스, 상속용으로 만들었다.

interface IMoniter  // 인터페이스 사용법
{
    //public void TurnOn();     // 인터페이스는 인스턴스를 가지지 못하므로 접근 제어자가 무의미하다.
    void TurnOn();          // 어차피 오버라이딩할거라서 그냥 써도 됨.
}

interface IKeyboard
{
    int Key { get; set; }   // 프로퍼티는 가능, 필드는 불가능
}

class Notebook : Computer, IMoniter, IKeyboard      // 다중 상속이 가능해진다.
{
    public void TurnOn() { Console.WriteLine("Turn On"); }      // 오버라이딩이지만 인터페이스는 override 선언을 안해줘도 된다.
    void IMoniter.TurnOn() { Console.WriteLine("Turn On"); }    // 인터페이스에 메소드를 명시적으로 종속시킨다는 뜻.

    int key;
    public int Key      // 프로퍼티 오버라이딩
    {
        get { return key; }
        set { key = value; }
    }
}

namespace CPPPP
{
    class Interface
    {
        public static void Main()
        {
            // TurnOn()을 public으로 선언한경우
            Notebook notebook = new Notebook();
            notebook.TurnOn();

            // TurnOn()을 public으로 선언하지 않은 경우
            IMoniter mon = notebook as Notebook;
            mon.TurnOn();

            notebook.Key = 3;
            Console.WriteLine(notebook.Key);
        }
    }
}

// 7행
// 그냥 클래스
// 상속용으로 만들었다.

// 9 ~ 13행
// 인터페이스를 만드는 방법이다.
// 그냥 클래스처럼 만들면 된다.
// 다만 성질은 추상 클래스와 비슷하다.
// 메소드를 선언만 가능하며 접근 제어자는 사용할 수 없다.
// 어차피 오버라이딩으로 정의해줘서 사용할 목적으로 인터페이스를 정의하기 때문이다.

// 15 ~ 18행
// 인터페이스는 프로퍼티도 만들 수 있다.
// 역시 프로퍼티도 오버라이딩하여 쓰기위해 선언한다.

// 20 ~ 31행
// 일반 클래스 뿐만 아니라 인터페이스도 상속받는다.
// 여기서 인터페이스는 다중 상속이 가능하다.
//
// 22행
// 9 ~ 13행에서 선언한 메소드를 오버라이딩한다.
// 다만 인터페이스에서 선언한 메소드는 override 선언을 하지 않아도 된다.
// 인터페이스는 오버라이딩을 하여 사용할 목적으로 선언하기 때문이다.
//
// 23행
// 반환형 인터페이스.메소드();로 선언하면 접근 지시자 없이 외부에서 접근할 수 있으나, 다른 방식으로 접근해야 한다.
// 
//
// 26 ~ 30행
// 15 ~ 18행에서 선언한 프로퍼티도 오버라이딩이 가능하다.

// 40 ~ 41행
// 22행에서 처럼 인터페이스 메소드를 오버라이딩하여 public으로 선언하면 일반 인스턴스화로 접근하여 호출할 수 있다.

// 44 ~ 45행
// 23행에서 처럼 인터페이스 메소드를 인터페이스에 명시적으로 종속시킨다는 의미로 사용하면 인스턴스화로 접근이 불가능하다.
// 반드시 인터페이스로 형변화해야만 호출할 수 있다.