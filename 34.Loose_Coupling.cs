using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IPower        // 인터페이스
{
    void TurnOn();
}

class Computer : IPower     // 인터페이스 상속
{
    public void TurnOn()
    {
        Console.WriteLine("Computer : Turn On");
    }
}

class Moniter : IPower      // 인터페이스 상속
{
    public void TurnOn()
    {
        Console.WriteLine("Moniter : Turn On");
    }
}

class TightCouplingSwitch
{
    public void TurnOn(Computer machine)    // 컴퓨터 클래스를 받는다.
    {
        Console.WriteLine("Computer Switch");
        machine.TurnOn();
    }

    public void TurnOn(Moniter machine)     // 모니터 클래스를 받는다.
    {
        Console.WriteLine("Moniter Switch");
        machine.TurnOn();
    }
}

class LooseCouplingSwitch
{
    public void TurnOn(IPower machine)      // 인터페이스를 상속 받는 클래스를 받는다.
    {
        Console.WriteLine("IPower Switch");
        machine.TurnOn();
    }
}

namespace CPPPP
{
    class Loose_Coupling
    {
        public static void Main()
        {
            TightCouplingSwitch tightSwitch = new TightCouplingSwitch();
            tightSwitch.TurnOn(new Computer());     // 만약 컴퓨터 클래스와
            tightSwitch.TurnOn(new Moniter());      // 모니터 클래스를 받는 메소드를 둘 다 정의해주지 않았다면?
            
            Console.WriteLine();

            LooseCouplingSwitch looseSwitch = new LooseCouplingSwitch();
            looseSwitch.TurnOn(new Computer());     // 공통의 인터페이스를 상속받은
            looseSwitch.TurnOn(new Moniter());      // 클래스를 전부 부용할 수 있는 메소드
        }
    }
}

// 7 ~ 10행
// 인터페이스를 정의해줬다.

// 12 ~ 26행
// 컴퓨터 클래스와 모니터 클래스는 인터페이스를 상속받으며 공통으로 전원을 넣는 기능을 구현한다.

// 28 ~ 41행
// 스위치를 눌러 전원을 키는 클래스를 구현하였다.
// TurnOn()이라는 메소드를 정의해줄 때 컴퓨터, 모니터를 받아서 작동한다.
// 하지만 둘 다 이름만 다른 동일한 동작이기 때문에 효율적이지 못하다.
// 이를 강한 결합이라고 한다.
// 자료형에 맞춰서 인수를 던져줘야 하는 것.

// 43 ~ 50행
// 마찬가지로 스위치를 눌러 전원을 키는 클래스를 구현하였다.
// TurnOn()이라는 메소드를 정의해줄 때 IPower 인터페이스를 받아서 작동한다.
// IPower 인터페이스와 호환되는(상속받은 클래스든 IPower 인터페이스 자체든) 인수는 모두 처리가 가능하다.
// 이렇게 인터페이스를 상속받은 클래스들만은 자료형의 구애받지 않고 처리할 수 있게끔 하는 방식을 느슨한 결합이라 한다.

// 59, 60행
// 강한 결합으로 정의된 메소드에 각 클래스를 전달한다.
// 만약 메소드에 전달하려는 인수의 클래스가 정의되어 있지 않다면 실행할 수 없다.
// 단지 인수의 자료형이 다르다는 이유만으로 같은 메소드를 자료형만 다르게 또 정의해야 한다.
// 낭비일 수 밖에 없다.

// 65, 66행
// 느슨한 결합으로 정의된 메소드에 각 클래스를 전달한다.
// 느슨한 결합이기 때문에 IPower를 상속받은 클래스라면 전부 인수로 전달할 수 있다.