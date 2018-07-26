using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class Person        // 클래스가 너무 큰데 크드를 2개 이상으로 나눌수 없나?
//{
//    string name;
//    int age;

//    public string Name { get { return name; } set { name = value; } }
//    public int Age { get { return age; } set { age = value; } }
//}

partial class Person    // partial을 사용하면 클래스를 나눠서 코딩할 수 있다.
{
    string name;
    public string Name { get { return name; } set { name = value; } }
}

partial class Person    // 위에서 크게 한덩이로 만드나 필요에 따라서 2개 이상으로 나누나 그게 그거다.
{
    int age;
    public int Age { get { return age; } set { age = value; } }
}

namespace CPPPP
{
    class Partial_Class
    {
        public static void Main()
        {
            Person person = new Person();   // 코드를 나눠도 하나의 클래스로 인식한다.

            person.Age = 10;        // get, set을 전부 정의했으므로
            person.Name = "바보";   // 저장이 가능  
        }
    }
}