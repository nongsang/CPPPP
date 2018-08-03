using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    //public string Name { get; set; }            // 예전에는 자동구현 속성인 필드의 초기값을 가지고 싶으면

    //public Person()                             // 생성자를 사용하여
    //{
    //    this.Name = "바보";                     // 초기화를 해줬어야 했다.
    //}

    public string Name { get; set; } = "바보";    // C# 6.0부터 자동구현 속성에 초기화가 가능해졌다.
}

namespace CPPPP
{
    class Auto_Implement_Property_Initialization
    {
        static void Main(string[] args)
        {

        }
    }
}