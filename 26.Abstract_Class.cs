using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    int x, y;

    public Point(int x, int y)
    {
        this.x = x; this.y = y;
    }

    public override string ToString()
    {
        return "X : " + x + ", Y : " + y;
    }
}

abstract class DrawingObject        // 추상 클래스
{
    public abstract void Draw();    // 추상 메소드, 순수 가상 클래스라고 생각하면 된다.

    public void Move() { Console.WriteLine("Move"); }   // 일반 메소드도 정의가능
}

class Line : DrawingObject      // 추상 클래스를 상속받았다.
{
    Point pt1, pt2;

    public Line(Point pt1, Point pt2)
    {
        this.pt1 = pt1; this.pt2 = pt2;
    }

    public override void Draw()
    {
        //throw new NotImplementedException();  // 추상 메소드를 오버라이딩하려하면 기본적으로 주어지는 것
        Console.WriteLine("Line : " + pt1.ToString() + " ~ " + pt2.ToString());
    }
}

namespace CPPPP
{
    class Abstract_Class
    {
        static void Main(string[] args)
        {
            DrawingObject line = new Line(new Point(10, 10), new Point(20, 20));    // 다형성 구현
            line.Move();    // 추상 클래스에도 일반 메소드가 있으므로 일반 메소드 실행
            line.Draw();    // 다형성에 따라 Line.draw()가 실행
        }
    }
}

// 7 ~ 20행
// 한 점의 정보들 담고 있는 클래스다.

// 22 ~ 27행
// 추상 클래스로 선언하였다.
// 가상 클래스랑 비슷하지만 다른 개념이다.
// 순수 가상 클래스에 가깝다.
//
// 24행
// 추상 메소드를 정의해줬다.
// 순수 가상 메소드라고 생각하면 된다.
// 따라서 상속받은 클래스에서 오버라이딩을 해줘야 한다.
// 추상 클래스 내부에서만 추상 메소드를 정의해줄 수 있다.
//
// 26행
// 일반 메소드도 선언해줄 수 있다.

// 29 ~ 43행
// 추상 클래스를 상속받는 클래스를 정의해줬다.
//
// 38 ~ 42행
// Draw()는 추상 메소드로, 아무런 정의가 되어있지 않으므로 반드시 오버라이딩을 해주어야 한다.
//
// 40행
// 추상 메소드를 override할 때 기본적으로 붙은 문장이다.
// 아직 잘 모르니 넘어가자

// 51행
// 추상 클래스로 자식 클래스의 인스턴스를 가리켜서 다형성을 구현하였다.

// 52행
// line이 추상 클래스임에도 일반 메소드가 존재하므로 실행이 된다.

// 53행
// Draw()는 추상 메소드이므로 다형성에 의하여 Line에서 오버라이드한 내용이 출력된다.