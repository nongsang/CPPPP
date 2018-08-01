using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

class Base
{
    public Base()
    {
        Console.WriteLine("Base 생성자");
    }
}

namespace CPPPP
{
    class Where_New
    {
        static T AllocateIfNull<T>(T item) where T : class  // 참조형식만 받을 수 있다.
        {
            if (item == null)   // 전달된 인자가 null이면
                item = new T(); // 새롭게 메모리를 할당한다.
                                // 문제는 매개변수로 받은 인자가 디폴트 생성자를 가지고 있다고 장담하지 못한다.
                                // string형이 들어오면 어떻게?
                                // 그래서 컴파일 오류를 발생
            return item;
        }

        static T AllocateIfNullNew<T>(T item) where T : class, new()    // 참조형식만 받을 수 있으며, 디폴트 생성자를 가진 인자만 받도록 강제
        {                                                               // 제한을 동시에 2개를 둘 수 있다.
            if (item == null)       // 전달된 인자가 null이면
                item = new T();     // 참조형이면서 디폴트 생성자를 가진 인자만, 새롭게 메모리를 할당한다.

            return item;
        }

        public static void Main()
        {
            Base a = null;              // a가 null이므로
            Base b = AllocateIfNull(a); // AllocateIfNull에서 a의 메모리를 할당하고, b도 a의 할당한 메모리를 가리킨다.
                                        // 하지만 a가 디폴트 생성자를 가지고 있음에도 AllocateIfNull에서 컴파일 오류가 발생

            Base c = null;                  // c가 null이므로
            Base d = AllocateIfNullNew(a);  // AllocateIfNullNew에서 c의 메모리를 할당하고, d도 c의 할당한 메모리를 가리킨다.
                                            // AllocateIfNull과 달리 생성자를 정의한 인자를 전달하므로 메모리 할당이 이루어진다.
        }
    }
}