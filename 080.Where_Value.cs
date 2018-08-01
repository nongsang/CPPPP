using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CPPPP
{
    class Where_Value
    {
        static int GetSizeOf<T>(T item)
        {
            return Marshal.SizeOf(item);    // Marshal의 SizeOf()는 값형식의 경우에만 데이터 크기를 반환한다.
                                            // 하지만 참조형식이 들어올 경우에 컴파일 오류는 발생하지 않고, ArgumentException을 발생시킨다.
        }

        static int GetSizeOfOnlyValue<T>(T item) where T : struct   // 값형식만 받을 수 있다는 명시와 함께 값형식만 받을 수 있게 강제
        {
            return Marshal.SizeOf(item);    // 값형식만을 받을 수 있다고 강제했기 때문에 참조형식이 들어오면 컴파일 오류를 발생시킨다
        }

        public static void Main()
        {
            Console.WriteLine(GetSizeOf(0.5f));     // 값형식
            Console.WriteLine(GetSizeOf(4m));       // 값형식
            Console.WriteLine(GetSizeOf("My"));     // 참조형식, 컴파일 오류는 발생하지 않으나 ArgumentException 발생

            Console.WriteLine(GetSizeOfOnlyValue(0.5f));// 값형식
            Console.WriteLine(GetSizeOfOnlyValue(4m));  // 값형식
            Console.WriteLine(GetSizeOfOnlyValue("My"));// 값형식만 받을 수 있게 강제했기 때문에 컴파일 오류 발생
        }
    }
}