using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class StaticOnly     // 정적 클래스
{
    static string name;     // 정적 필드, 하지만 public이 아니라 마음대로 접근 불가능
    public static string Name    // 정적 프로퍼티, 프로퍼티도 정적이여야 정적 필드에 접근할 수 있다.
    {
        get { return name; }
        set { name = value; }
    }
    public static void Print()      // 정적 메소드, 메소드도 정적이여야 정적 필드를 사용할 수 있다.
    {
        Console.WriteLine(name);
    }
}

namespace CPPPP
{
    class Static_Class
    {
        public static void Main()
        {
            StaticOnly.Name = "바보";     // 클래스가 Static이므로 인스턴스화를 하지 않아도 사용할 수 있다.
            StaticOnly.Print();         // 메소드도 마찬가지
                                        // 가장 대표적인 정적 클래스는 System.Math다.
                                        // 어디서든 사용해야 할 기능이라면 static으로 만들자.
        }
    }
}