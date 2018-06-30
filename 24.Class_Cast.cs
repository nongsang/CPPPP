using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Currency  // 통화라는 뜻
{
    decimal money;
    public decimal Money { get { return money; } }      // Money라는 프로퍼티를 호출하면 money라는 필드를 반환

    public Currency(decimal money)
    {
        this.money = money;
    }
}

class Won : Currency    // 형변환 메소드를 오버라이드를 하지 않았으므로 다른 클래스로 형변환이 불가능
{
    public Won(decimal money) : base(money) { } // 부모클래스에 있는 money에 값을 저장

    public override string ToString()
    {
        return Money + "Won";
    }
}

class Dollar : Currency
{
    public Dollar(decimal money) : base(money) { }

    public override string ToString()
    {
        return Money + "Dollar";
    }

    public static implicit operator Dollar(Yen Yen)     // Yen을 Dollar로 형변환이 가능해진다.
    {
        return new Dollar(Yen.Money * 0.9m);    // money를 프로퍼티로 선언했기 때문에 Money
    }
}

class Yen : Currency
{
    public Yen(decimal money) : base(money) { }

    public override string ToString()
    {
        return Money + "Yen";
    }

    public static explicit operator Yen(Won won)
    {
        return new Yen(won.Money * 0.9926m);    // money를 프로퍼티로 선언했기 때문에 Money
    }
}

namespace CPPPP
{
    class Class_Cast
    {
        static void Main(string[] args)
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(100);

            //won = dollar;   // 부모, 자식 관계가 아닌 클래스끼리는 형변환이 불가능하다.
            dollar = yen;   // 형변환 연산자를 implicit으로 오버로딩 했으므로 묵시적 형변환이 발생한다.
            dollar = (Dollar)yen;   // 명시적으로 해도 상관없다.
            //yen = won;      // 형변환 연산자를 explicit으로 오버로딩 했으므로 명시적 형변환을 해야한다.
            yen = (Yen)won;

            Console.WriteLine(won);
            Console.WriteLine(dollar);
            Console.WriteLine(yen);
        }
    }
}

// 10행
// money 멤버를 Money라는 프로퍼티로 선언했다.
// 그것도 get으로 읽기만 가능하게 했다.

// 18 ~ 26행
// 돈 중에서 원화를 표현한 클래스다.
// 기본적으로 부모, 자식 클래스 끼리의 형변환은 가능하다.
// 하지만 그 밖에 다른 클래스와는 정의해주지 않으면 형변환이 불가능하다.
// 이 클래스는 형변환 오버라이딩을 해주지 않았으므로 형변환이 불가능하다.

// 28 ~ 41행
// 돈 중에서 달러를 표현한 클래스다.
//
// 37 ~ 40행
// 엔화를 달러로 형변환했을 때 새롭게 달러 값을 정하여 인스턴스를 생성하는 의미를 나타낸다.
// implicit예약어를 사용하여 암묵적으로 형변환할 수 있게 해준다.

// 43 ~ 56행
// 돈 중에서 엔화를 표현한 클래스다.
//
// 52 ~ 55행
// 원화를 엔화로 형변환할 때 새로운 값으로 엔화 인스턴스를 생성한다.
// explicit예약어를 사용하여 명시적으로 형변환을 표현해야 사용이 가능하다.

// 68행
// 달러를 원으로 변환하여 가치를 매기는 명령이다.
// 문제는 Won클래스에 다른 클래스를 형변환하는 메소드가 정의되어있지 않기 때문에 명시적으로도 형변환이 불가능하다.

// 69 ~ 70행
// Dollar클래스에 형변환 연산자를 implicit으로 오버로딩 했으므로 묵시적 형변환이 발생한다.
// 또한 명시적으로 형변환해도 상관없다.

// 71 ~ 72행
// Yen클래스에 형변환 연산자를 explicit으로 오버로딩 했으므로 명시적 형변환만 해야한다.
// 따라서 묵시적으로 형변환이 일어나지 않게 된다.