using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Kilogram
{
    double kg;

    public Kilogram(double value)
    {
        this.kg = value;
    }

    public Kilogram Add(Kilogram target)
    {
        return new Kilogram(this.kg + target.kg);
    }

    // 메소드 오버로딩은 반환형만 다르다고 다른 메소드로 인식하지 않는다.
    //public void Add(Kilogram target)
    //{
    //    this.kg += target.kg;
    //}

    public override string ToString()   // object형 메소드를 오버라이딩했다.
    {
        //return this.kg.ToString();    // 무조건 string형으로 반환해야 한다.
        return this.kg + "kg";
    }

    public static Kilogram operator+(Kilogram ob1, Kilogram ob2)    // 연산자 오버로딩
    {
        return new Kilogram(ob1.kg + ob2.kg);
    }

    //public static Kilogram operator=(Kilogram targer)   // operator=() 연산자는 오버로딩 불가능
    //{
    //    this.kg = targer.kg;
    //    return this;
    //}
}

namespace CPPPP
{
    class Overlord
    {
        static void Main(string[] args)
        {
            Kilogram kg1 = new Kilogram(3.5);
            Kilogram kg2 = new Kilogram(2.7);

            Kilogram kg3 = kg1 + kg2;       // 34 ~ 36행 연산자 메소드가 호출된다.

            Kilogram kg4 = kg3.Add(kg2);    // 16 ~ 19행 메소드가 호출되며 새로운 인스턴스를 반환한다.

            Console.WriteLine(kg3.ToString());
            Console.WriteLine(kg4.ToString());
        }
    }
}

// 16 ~ 19행
// 클래스형끼리 Add로 연관지어주면 각 인스턴스의 필드끼리 더하여 새로운 인스턴스를 만드는 메소드다.

// 22 ~ 25행
// 단순히 원래 있던 인스턴스의 필드에 값을 더하여 저장하는 메소드다.
// 반환형이 void일 뿐이기 때문에 반환형만 다른 16 ~ 19행 메소드가 존재하면 다른 메소드로 구분을 하지 못한다.

// 27 ~ 31행
// object형 메소드인 ToString()을 오버라이딩 해준다.
// 반드시 생각해줘야 하는 것은 반환형이 string형이여야 한다.
// 또한 반환값이 string형이여야 한다.
// 필드.ToString()으로 써줘도 되지만 단순히 필드 + "문자열"로 쉽게 string형으로 변환하여 전달할 수 있다.

// 33 ~ 36행
// + 연산자 오버로딩이다.
// C++과 다른점은 C++에서는 Kilogram operator+(const Kilogram& rhs)로 오버로딩을 해주어야 한다.
// C#에서는 매개변수를 2개를 사용하여 이항 연산임을 보여준다.
// 또한 static을 붙여주어 어디서든 불릴 수 있는 메소드임을 명시한다.

// 38 ~ 42행
// = 연산자는 오버로딩이 불가능하다.

// 54행
// 34 ~ 36행 연산자 메소드가 호출된다.

// 56행
// 16 ~ 19행 메소드가 호출되며 새로운 인스턴스를 반환한다.