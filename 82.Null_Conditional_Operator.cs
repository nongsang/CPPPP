using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Null_Conditional_Operator
    {
        public static void Main()
        {
            List<int> list = null;

            if (list != null)                // null인지 체크 안하면
                WriteLine(list.Count);      // 데이터가 없으므로 System.NullReferenceException 발생
                                            // null을 반환해도 받을 수 없으므로 예외가 발생한다.

            WriteLine(list?.Count);              // 좀 더 간략하게 사용하는 방법이다.
            WriteLine(list != null ? new int? (list.Count) : null); // 이렇게 알아서 삼항연산자로 번역해서 출력한다.
                                                                    // 따라서 null이 반환이 가능하므로 예외가 발생하지 않는다.
                                                                    // 그냥 아무것도 출력이 안될 뿐

            if (list != null)                       // 예전에는 이렇게 리스트에 원소가 있는지 확인하고
            {
                for(int i = 0; i< list.Count; ++i)  // 각 요소들을
                    WriteLine(list[i]);             // 출력했어야 했다.
            }

            for(int i = 0; list != null && i< list.Count; ++i)  // 아니면 이렇게 조건문에 null 판단문도 넣어서
                WriteLine(list[i]);                             // 출력을 했어야 했다.

            for(int i = 0; i < list?.Count; ++i)            // null 조건 연산자로 쉽게 null인지 판별하면서
                WriteLine(list[i]);                         // null이면 실행하지 않고 null이 아니라면 출력한다.

            int? n = list?[0];      // list != null이라면 nullable변수에 list[0]값을 전달할 수 있다.
                                    // int가 값형식이므로 nullable 선언이 되어 있어야 가능하다.

            string[] lines1 = { "test", "txt" };// string형 배열이므로 여러 문자열을 받을 수 있다.
            string firstElement1 = lines1?[0];  // 제일 앞부분에 있는 문자열을 반환
            WriteLine(firstElement1);           // test 출력

            string[] lines2 = null;             // 값을 가진 문자열이 없으므로
            string firstElement2 = lines2?[0];  // null 반환, firstElement2는 null을 받을 수 있으므로 string?으로 선언할 필요는 없다.
            WriteLine(firstElement2);           // 아무것도 출력 안됨

            string lines3 = "test";             // string형이므로 문자열 하나만 받을 수 있다.
            //string firstElement3 = lines3?[0];// 원소 한개를 반환하면 char?형이므로 string으로 받을 수 없다.
            char? firstElement3 = lines3?[0];   // 왜냐하면 lines?[0] 자체가 null값을 받을 수 있는 문자 1개이기 때문이다.
                                                // 문자 1개면 char형이지만 값형식이므로 null값을 받기 위해 char?형으로 받아야 한다.
            WriteLine(firstElement3);           // t 출력

            int count = list?.Count ?? 0;       // ?? 연산자는 참조형식의 값을 판단하는 연산자다.
                                                // 따라서 list.Count는 값형식이므로 ?? 연산자를 사용할 수 없다.
                                                // list?.Count가 null을 반환하면 0을 count로 반환하게 된다.
            WriteLine(count);                   // 0 출력

            if(list != null)        // list에 값이 있다면
            {                       // 값을 집어 넣는다.
                list.Add(5);        // 뭐 이런 방법이 일반적인 방법이다.
                list.Add(6);
                list.Add(7);
                list.Add(8);
                list.Add(9);
            }

            list?.Add(5);       // 값이 있는지 확인하고 값이 없다면 null을, 값이 있다면 5를 넣는다.
            list?.Add(6);       // 근데 이 방법을 많이 사용하면?

            if(list != null)    // 계속
            {
                list.Add(5);    // 이런 식으로 번역해서 실행하기 때문에
            }

            if (list != null)   // 성능 저하가
            {
                list.Add(6);    // 심하겠네?
            }                   // 1개만 집을 넣을 때 쓰자.

        }
    }
}