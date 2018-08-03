using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector
{
    double x;
    double y;

    public Vector(double x, double y)       // 생성자
    {
        this.x = x;
        this.y = y;
    }

    //public Vector Move(double dx, double dy)      // 원래는 메소드를
    //{
    //    return new Vector(x + dx, y + dy);        // 다 정의해줬어야 했다.
    //}
    public Vector Move(double dx, double dy) => new Vector(x + dx, y + dy);     // C# 6.0부터 람다 형식으로 메소드 정의가 가능하다.

    //public void PrintIt()                         // 이것도 원래 메소드
    //{
    //    Console.WriteLine(this);
    //}
    public void PrintIt() => Console.WriteLine(this);   // 람다 형식으로 메소드 정의

    public override string ToString() => string.Format("x = {0}, y = {1}", x, y);   // ToString 오버라이딩이지만 람다 형식으로 메소드 정의

    public double Angle => Math.Atan2(y, x); // get만 자동 정의되고 set 기능은 제공되지 않는다.

    // 인덱서의 get 접근자를 람다 식으로 정의
    // 복잡해도 결국 단일 문이기만 하면 람다 식 적용 가능
    public double this[string angleType] =>
        angleType == "radian" ? this.Angle :                                // radian 인덱서로 접근하면 Angle 메소드 호출
        angleType == "degree" ? RadianToDegree(this.Angle) : double.NaN;    // degree 인덱서로 접근하면 RadianToDegree 메소드 호출

    static double RadianToDegree(double angle) => angle * (180.0 / Math.PI);

    // 생성자 / 종료자, 이벤트의 add/ Remover 접근자의 경우 메소드지만 람다 식을 이용하여 구현할 수 없다.
}

namespace CPPPP
{
    class Lambda_Method_Properties_Indexer
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(10, 20);

            Console.WriteLine(v1.Angle);
            Console.WriteLine(v1["radian"]);
            Console.WriteLine(v1["degree"]);
            Console.WriteLine(v1);
        }
    }
}