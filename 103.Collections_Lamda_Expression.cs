using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Collections_Lamda_Expression
    {
        public static void Main()
        {
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };       // 데이터가 있다면

            foreach (var item in list)                              // 일반적으로
                Console.WriteLine(item + " * 2 == " + (item * 2));  // foreach만 구현을 할 것이다.

            list.ForEach(elem => { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });   // 콜렉션의 ForEach과 람다로 구현이 된다

            Array.ForEach(list.ToArray(), elem => { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });  // 배열에 저장도 가능

            list.ForEach(delegate (int elem) { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });   // 익명 메소드도 사용가능

            foreach (var item in list)      // 리스트의 모든 요소를
            {
                if (item % 2 == 0)          // 짝수인지 판정해서
                    list.Add(item);         // List에 추가한다.
            }

            List<int> evenList = list.FindAll(elem => elem % 2 == 0);   // 콜렉션의 FindAll과 람다로 해당 값을 모두 찾을 수 있다.
                                                                        // 여기서 중요한 것은 List<int>형으로 받았다는 점이다.
                                                                        // 다음에 또 나오니까 기억해두도록
            evenList.ForEach(elem => { Console.Write(elem + ","); });   // 그리고 출력

            int count = 0;

            foreach (var item in list)  // 리스트의 모든 요소 중
            {
                if (item > 3)           // 3 초과인 요소가 있으면
                    ++count;            // 갯수를 센다.
            }

            Console.WriteLine("3보다 큰 수는 " + count + "개 있음.");

            int listCount = list.Count((elem) => elem > 3);             // 복잡하니 Count와 람다로 만들 수 있다.
            Console.WriteLine("3보다 큰 수는 " + listCount + "개 있음.");
        }
    }
}