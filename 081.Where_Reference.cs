using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CPPPP
{
    class Where_Reference
    {
        static void CheckNull<T>(T item)
        {
            if (item == null)                       // 입력받은 인수가 null이면
                throw new ArgumentNullException();  // 예외발생
                                                    // 하지만 값형식이 들어와도 비교를 한번 하기 때문에 자원을 괜히 소모하게 된다.
        }

        static void CheckNullOnlyReference<T>(T item) where T : class   // 참조형식만 받을 수 있다는 명시와 함께 참조형식만 받을 수 있게 강제
        {
            if (item == null)
                throw new ArgumentException();
        }

        public static void Main()
        {
            CheckNull(0.5f);        // 값형식이 전달되도 예외는 발생하지 않지만 비교를 한번 하므로 자원을 소모한다.
            CheckNull("My");        // 참조형식을 전달했으므로 제대로된 목적을 달성할 수 있다.

            CheckNullOnlyReference(0.5f);   // 참조형식만 받게 강제했으므로 값형식을 전달하면 컴파일 오류
            CheckNullOnlyReference("My");   // 참조형식을 전달했으므로 제대로된 목적을 달성할 수 있다.
        }
    }
}