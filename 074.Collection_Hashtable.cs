using System;
using System.Collections;           // 자료구조를 사용하려면 추가, 콜렉션의 문제는 object를 인자로 받기 때문에 박싱이 발생한다.
using System.Collections.Generic;   // 값형식까지 커버하고 싶으면 Generic을 사용해야 한다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Collection_Hashtable
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable(); // '키'와 '데이터'로 이루어진 자료구조다.

            // 4개의 요소를 컬렉션에 추가
            ht.Add("key1", "add");          // 해시 테이블에 값을 넣을 때 키값을 해시코드로 바꾸어서 저장한다.
            ht.Add("key2", "remove");       // 따라서 값을 찾을 때 해시코드를 검색하기 때문에 검색이 매우 빠르다.
            ht.Add("key3", "update");       // 하지만 입력한 키값이 달라도 해시코드가 같으면 Argument Exception이 발생한다.
            ht.Add("key4", "search");       // 또한 키값과 데이터를 동시에 저장하고 있기 때문에 메모리가 많이 낭비된다.
                                            // 게다가 키와 값이 모두 object 타입으로 다뤄지기 때문에 박싱문제가 생긴다.

            Console.WriteLine(ht["key4"]);  // "key4" 키 값에 해당하는 값을 출력

            ht.Remove("key3");              // "key3" 키 값에 해당하는 요소를 컬렉션에서 삭제

            ht["key2"] = "delete";          // "key2" 키 값에 해당하는 값을 "delete"로 변경
            Console.WriteLine();

            foreach (object key in ht.Keys) // 컬렉션의 모든 키 값을 열람하고, 그 키에 대응되는 값을 출력
            {
                Console.WriteLine("{0} ==> {1}", key, ht[key]); // 정렬된 순서는 모르겠다. 해시테이블에선 정렬이 별로 중요하지도 않고
            }
        }
    }
}

// 검색 속도의 중요도에 따라서 ArrayList 또는 Hashtable을 선택하여 사용한다.
// ArrayList는 검색 속도가 O(n)이다.
// Hashtable은 검색 속도가 O(1)이다.
// 컬렉션의 크기가 작다면 ArrayList가 좋으며, 크기가 커질 수록 Hashtable이 더 좋다.