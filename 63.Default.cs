using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Default
    {
        public static void Main()
        {
            int intValue = default(int);    // default로 자료형의 기본값을 반환하여 저장한다.
            Console.WriteLine(intValue);

            double doubleValue = default(double);   // 그냥 default가 기본값을 받환한다는 뜻이니까
            Console.WriteLine(doubleValue);         // 꼭 이렇게 초기화할 때만 쓰지 않아도 된다.
                                                    // 인덱스값을 넘어서 접근할 때 기본 값을 전달한다든지, 사용방법은 많다.

            string txt = default(string);       // string은 기본값이 null이다.
            Console.WriteLine(txt ?? "(Null)");
        }
    }
}