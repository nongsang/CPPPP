using System;
using System.Collections;           // 자료구조를 사용하려면 추가, 콜렉션의 문제는 object를 인자로 받기 때문에 박싱이 발생한다.
using System.Collections.Generic;   // 값형식까지 커버하고 싶으면 Generic을 사용해야 한다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Collection_Queue
    {
        public static void Main()
        {
            Queue q = new Queue();          // 선입선출, 먼저 들어온 데이터가 먼저 삭제되는 구조를 가진 자료구조

            q.Enqueue(1);                   // 1을 집어넣는다.
            q.Enqueue(5);                   // 바로 뒤에 5를 집어넣는다.
            q.Enqueue(3);                   // 바로 뒤에 3을 집어넣는다.

            int first = (int)q.Dequeue();   // 제일 앞에 있는 값을 빼면서 빠진 값이 무엇인지 검출하려고 새로운 변수에 저장
                                            // 제일 앞에 있는 값은 1이므로 남은 데이터는 앞에서 5, 3 순서대로 있다.

            q.Enqueue(7);                   // 7이 그 뒤에 집어넣으면서 5, 3, 7이 있게된다.

            while (q.Count > 0)             // 값이 있으면
            {
                Console.Write(q.Dequeue() + ", ");  // 앞에서부터 차례로 값을 삭제하면서 삭제한 값이 무엇인지 출력한다.
            }

            q.Clear();                      // 그냥 모든 값을 삭제하고 싶으면 Clear()를 하면 된다.
        }
    }
}