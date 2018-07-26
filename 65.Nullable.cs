using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Nullable
    {
        public static void Main()
        {
            Nullable<int> a = null; // int형이지만 null값을 받을 수 있게 만들어준다.
            Console.WriteLine(a);   // 값이 null이므로 아무것도 출력이 안된다.

            int? b = null;          // Nullable<int>의 약식이다.
            Console.WriteLine(b);   // 설문조사에서 아무것도 선택하지 않을 때 '예', '아니오'가 아니라 '미정'으로 저장할 수 있다.
        }
    }
}