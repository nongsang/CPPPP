using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    internal void Deconstruct(out int x, out int y)     // Deconstruct는 튜플처럼 사용할 수 있다.
    {                                                   // 매개변수는 out으로 정의를 해줘야 한다.
        x = X;                                          // 따라서 값을 2개 던져줄 수 있는 튜플이면서
        y = Y;                                          // 그 결과 값을 던져준 변수에 다시 돌려주는 튜플이다.
    }

    internal void Deconstruct(out int x, out int y, out int width, out int height)  // Deconstruct는 1개 이상 오버로딩하여 정의할 수 있다.
    {
        x = X;
        y = Y;
        width = Width;
        height = Height;
    }
}

namespace CPPPP
{
    class Deconstruct
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 6, 20, 25);   // 값을 전부 전달해서 생성

            {
                (int x, int y) = rect;                      // rect의 Deconstruct 중 매개변수가 2개인 메소드를 정의했으므로 사용가능
                Console.WriteLine($"x == {x}, y == {y}");
            }

            {
                (int _, int _) = rect;                      // 매개변수가 2개인 Deconstruct를 호출했지만 값을 받지 않았으므로 의미가 없음

                (int _, int y) = rect;                      // 기존 튜플처럼 사용할 수 있다.
                Console.WriteLine($"y == {y}");             // y만 받았으므로 y만 출력
            }

            {
                (int x, int y, int width, int height) = rect;       // rect값을 튜플로 받았다.
                Console.WriteLine($"x == {x}, y == {y}, width  = {width}, height = {height}");  // 전부 풀력

                (int _, int _, int _, int _) = rect;        // 변수가 4개인 Deconstruct를 호출했지만 값을 받지 않았으므로 이것도 의미없음

                (int _, int _, int w, int h) = rect;        // 4개 값중 2개만 받았다.
                Console.WriteLine($"w == {w}, h == {h}");

                (var _, var _, var _, var last) = rect;     // 4개 값 중 1개만 받았다.
                Console.WriteLine($"last == {last}");
            }
        }
    }
}