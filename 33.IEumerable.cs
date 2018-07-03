using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;       // IComparer와 마찬가지로 IEnumerator를 사용하려면 추가해야 한다.

namespace CPPPP
{
    class IEumerable
    {
        public static void Main()
        {
            int[] intArray = new int[] { 0, 1, 2, 3, 4, 5 };

            IEnumerator enumerator = intArray.GetEnumerator();  // Array는 IEnumerable 인터페이스를 구현했다.

            while(enumerator.MoveNext())        // IEnumerator의 기능 중 MoveNext()
            {
                Console.Write(enumerator.Current + " ");    // IEnumerator의 기능 중 Current
            }
            Console.WriteLine();

            string name = "Korea";

            // string 타입도 IEnumerable 인터페이스를 구현한 사례 중 하나다.
            foreach (char ch in name)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}

// 6행
// IComparer와 마찬가지로 IEnumerator의 기능을 사용하려면 추가해야 한다.

// 16행
// 배열은 Array형 이고, Array형은 IEnumerable을 상속받았으며, GetEnumerator()을 오버라이딩 하였다.
// IEnumarable은 GetEnumerator()만 존재한다.
// GetEnumerator()는 IEnumerator를 반환하게 된다.
// Iterator형태라면 전부 IEnumerator로 받을 수 있다.
// 따라서 intArray.GetEnumerator()로 IEnumerator를 받아서 다형성을 구현했다고 볼 수 있다.

// 18행
// IEnumerator의 기능 중 MoveNext()를 사용하여 다음 요소로 넘어간다.
// foreach처럼 순회를 한다.

// 20행
// IEnumerator의 기능 중 Current로 현재 요소를 반환한다.

// 27 ~ 30행
// string 타입은 각 문자를 char형으로 접근하여 출력하는 구조다.