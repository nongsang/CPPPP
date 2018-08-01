using System;
using System.Collections;           // 자료구조를 사용하려면 추가, 콜렉션의 문제는 object를 인자로 받기 때문에 박싱이 발생한다.
using System.Collections.Generic;   // 값형식까지 커버하고 싶으면 Generic을 사용해야 한다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Collection_Sorted_List
    {
        public static void Main()
        {
            SortedList sl = new SortedList();       // 해시테이블에 키값으로 정렬하는 기능을 넣는 컬렉션

            // 데이터를 삽입하자마자 정렬된다.
            // 해시테이블과 마찬가지로 키값이 같으면 ArgumentException이 발생한다.
            sl.Add(32, "Cooper");
            sl.Add(56, "Anderson");
            sl.Add(17, "Sammy");
            sl.Add(27, "Paul");

            foreach (int key in sl.GetKeyList())    // 키값을 기준으로 정렬된 상태로 출력
            {
                Console.WriteLine(string.Format("{0} {1}", key, sl[key]));
            }
        }
    }
}