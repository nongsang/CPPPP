using System;
using System.Collections;           // 자료구조를 사용하려면 추가, 콜렉션의 문제는 object를 인자로 받기 때문에 박싱이 발생한다.
using System.Collections.Generic;   // 값형식까지 커버하고 싶으면 Generic을 사용해야 한다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Collection_Array_List
    {
        public static void Main()
        {
            ArrayList ar = new ArrayList();     // 크기가 자유롭게 변하는 배열이라고 생각하면 된다.

            // 4개의 요소를 컬렉션에 추가
            ar.Add("Hello");
            ar.Add(6);
            ar.Add("World");
            ar.Add(true);

            Console.WriteLine("Contains(6): " + ar.Contains(6));    // 숫자 6을 포함하고 있는지 판단

            ar.Remove("World");     // "World" 문자열을 컬렉션에서 삭제

            // 2번째 요소의 값을 false로 변경
            ar[2] = false;
            Console.WriteLine();

            // 컬렉션의 요소를 모두 출력
            foreach (object obj in ar)
            {
                Console.WriteLine(obj);
            }

            ar.Sort();      // 요소들을 정렬한다.
                            // 하지만 모든 요소의 타입이 같을 때 유효하다.
                            // 다른 타입의 데이터가 있을 때 호출하면 ArgumentException이 발생한다.
        }
    }
}