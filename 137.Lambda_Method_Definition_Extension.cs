using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

public class Vector                         // C# 7.0부터 추가된 람다 식 확장법이다.
{                                           // 119.Lambda_Method_Properties_Indexer에서 확장됬다.
    double x;
    double y;

    public Vector(double x) => this.x = x;  // 생성자를 람다로 정의 가능하다.
                                            // 하지만 x, y 둘 다 정의하려면 문장이 2개가 되므로 x, y 둘 중 하나만 람다로 정의가 가능하다.

    public Vector(double x, double y)       // 2개의 문장으로 초기화할 수 밖에 없으므로 람다 식으로 정의 불가능
    {
        this.x = x;
        this.y = y;
    }

    ~Vector() => Console.WriteLine("~dtor()");  // 소멸자도 람다로 정의 가능

    public double X
    {
        get => x;
        set => x = value;   // set 접근자도 람다로 정의 가능
    }

    public double Y
    {
        get => y;
        set => y = value;   // set 접근자도 람다로 정의 가능
    }

    public double this[int index]                           // 인덱서
    {
        get => (index == 0) ? x : y;                        // 인덱서의 get 접근자는 이전부터 람다로 정의 가능했다.
        set => _ = (index == 0) ? x = value : y = value;    // 인덱서 set 접근자도 람다로 정의 가능
                                                            // 일반 람다는 ()로 했지만 인덱서는 _로 사용해서 람다로 사용할 수 있다.
    }

    private EventHandler positionChanged;
    public event EventHandler PositionChanged       // 이벤트의 add/remove 접근자 정의 가능
    {
        add => this.positionChanged += value;       // add를 람다로 재정의
        remove => this.positionChanged -= value;    // remove를 람다로 재정의
    }

    public Vector Move(double dx, double dy)        // 그냥 Vector 클래스의 메소드
    {
        x += dx;
        y += dy;

        positionChanged?.Invoke(this, EventArgs.Empty); // 이건 잘 모르겠다.
        //positionChanged?(this, EventArgs.Empty);      // 이건 불가능
        //positionChanged(this, EventArgs.Empty);       // 이건 가능

        return this;            // return this로 정의한 값을 갱신
    }

    public void PrintIt() => Console.WriteLine(this);   // 일반 메소드를 람다로 정의

    public override string ToString() => string.Format("x = {0}, y = {1}", x, y);   // 오버라이딩도 람다로 가능
}

namespace CPPPP
{
    class Lambda_Method_Definition_Extension
    {
        public static void Main()
        {
            Vector v = new Vector(10, 20);      // 생성후
            v[0] = 11;                          // 인덱서로
            v[1] = 21;                          // 값 변경

            Console.WriteLine(v);

            v.PositionChanged += PositionChanged;
            v.Move(100, 100);
        }

        private static void PositionChanged(object sender, EventArgs e)
        {
            if (sender is Vector)
                Console.WriteLine((sender as Vector).ToString());
        }
    }
}