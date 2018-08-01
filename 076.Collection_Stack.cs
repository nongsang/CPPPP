using System;
using System.Collections;           // 자료구조를 사용하려면 추가, 콜렉션의 문제는 object를 인자로 받기 때문에 박싱이 발생한다.
using System.Collections.Generic;   // 값형식까지 커버하고 싶으면 Generic을 사용해야 한다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Collection_Stack
    {
        public static void Main()
        {
            Stack st = new Stack();     // 후입선출, 나중에 들어온 데이터일 수록 먼저 삭제되는 자료구조

            st.Push(1);                 // 1이 제일 밑에 있다.
            st.Push(5);                 // 5가 그 위에 올라간다.
            st.Push(3);                 // 3이 그 위에 올라간다.

            int last = (int)st.Pop();   // 제일 위에 있는 값을 빼면서 그 빠진 값이 무엇인지 검출하려고 새로운 변수에 저장한 것
                                        // 제일 위에 있던 값은 3이므로 남은 데이터는 아래부터 1, 5 순서대로 쌓여있다.

            st.Push(7);                 // 7이 그 위에 쌓이면서 아래부터 1, 5, 7이 쌓이게 된다.

            while (st.Count > 0)        // 스택에 값이 있으면
            {
                Console.Write(st.Pop() + ", ");     // 스택 제일 위에 있는 값을 하나씩 빼면서 빠진 값을 출력한다.
            }

            Console.WriteLine();

            st.Clear();                 // 그냥 스택에 있는 모든 값을 삭제하고 싶으면 Clear를 한다.
        }
    }
}