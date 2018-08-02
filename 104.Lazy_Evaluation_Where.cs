using System;
using System.Collections.Generic;
using System.Linq;                  // Where을 사용하기 위해서 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Lazy_Evaluation_Where
    {
        public static void Main()
        {
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };
            {
                IEnumerable<int> enumList = list.Where(elem => elem % 2 == 0);          // 짝수를 반환하는데 IEnumerable<int>형이다.
                Array.ForEach(enumList.ToArray(), elem => { Console.WriteLine(elem); });// 요소들을 배열에 저장
            }

            Console.WriteLine();

            {
                List<int> evenList = list.FindAll(elem => elem % 2 == 0);   // FindAll은 List<int>형으로 반환한다.
                evenList.ForEach(elem => { Console.Write(elem + ","); });   // FindAll은 실행이 완료되면 조건에 맞는 목록을 만들어서 반환.
                                                                            // 따라서 조건에 맞는 목록을 만들기 위해 메모리를 사용한다.
            }

            Console.WriteLine();

            {
                IEnumerable<int> enumList = list.WhereFunc();                           // 사실 Where은 WhereFunc()와 같은 구조다.
                Array.ForEach(enumList.ToArray(), elem => { Console.WriteLine(elem); });// Where은 실행됬을 때 어떤 작업도 하지 않는다.
                                                                                        // 이후 열거자로 순회했을 때, 식이 하나씩 실행된다.
                                                                                        // 이를 지연된 평가(lazy evaluation)라고 한다.
                // IEnumerable을 반환하는 모든 메소드가 이런 방식으로 동작한다.
            }
        }
    }

    static class ExtensionSample        // 정적 클래스
    {
        public static IEnumerable<int> WhereFunc(this IEnumerable<int> inst)    // 확장 메소드로 정의했다.
        {
            foreach (var item in inst)  // 받은 요소 중
            {
                if (item % 2 == 0)      // 짝수를 찾으면
                {
                    yield return item;  // 반환하고 다시 찾는다.
                }
            }
        }
    }
}