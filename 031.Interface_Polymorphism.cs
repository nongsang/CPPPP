using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IDrawingObject    // 인터페이스
{
    void Draw();        // 인터페이스 메소드
}

class Line : IDrawingObject
{
    public void Draw() { Console.WriteLine("Line"); }   // 인터페이스 메소드 오버로딩
}

class Rectangle : IDrawingObject
{
    public void Draw() { Console.WriteLine("Rectangle"); }  // 인터페이스 메소드 오버로딩
}

namespace CPPPP
{
    class Interface_Polymorphism
    {
        public static void Main()
        {
            IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };  // 다형성 구현

            foreach (IDrawingObject item in instances)  // 각 요소에 접근하여 값을 메소드 호출
            {
                item.Draw();
            }

            IDrawingObject instance = new Line();   // 여기도 다형성
            instance.Draw();
        }
    }
}

// 7 ~ 10행
// 인터페이스를 만들어줬다.
// 순수 가상 클래스라고 생각하는게 속편하다.

// 12 ~ 15행
// 인터페이스 상속을 받아서 인터페이스 메소드를 오버라이딩 하였다.

// 17 ~ 22행
// 인터페이스 상속을 받아서 인터페이스 메소드를 오버라이딩 하였다.

// 28행
// 다형성을 구현하였다.

// 30 ~ 33행
// foreach로 각 요소에 접근하여 재정의된 메소드를 호출한다.