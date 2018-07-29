using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class If_Type_Pattern_Matching
    {
        public static void Main()
        {
            object[] objList = new object[] { 100, null, DateTime.Now, new List<int>() };   // 배열의 각 요소들은 다른 값을 가지고 있다.

            foreach (object item in objList)    // 배열에 있는 모든 요소들을 순회하며 접근
            {
                if (item is 100)                // 여기서 item은 object형이지만 100이라는 상수가 있다면
                    WriteLine(item);            // 자동으로 int형으로 형변환하여 접근한다.
                                                // 상수와 비교를 하므로 상수 패턴

                else if (item is null)          // null이 있다면 item은 object형이라 null값을 받을 수 있으므로
                    WriteLine("Null");          // 형변환할 필요없이 그냥 Null을 출력
                                                // 상수와 비교를 하므로 상수 패턴

                //else if (item is DateTime dt) // DateTime타입이 있다면 자동으로 값형식으로 형변환하여 접근한다.
                else if (item is DateTime)      // 변수 이름 dt를 없애도 접근할 수 있으나 item으로 사용해야 한다.
                    WriteLine(item);            // 앞에서 나온 예와 달리 타입 패턴을 가진다.
                                                // 값을 비교하는 것이 아니라 요소가 값형식인 DateTime과 비교하기 때문이다.

                else if (item is List<int> list)// List<int>를 만나면 자동으로 참조형식으로 형변환하여 접근한다.
                                                //else if (item is List<int>)   // 변수 이름 list를 없애도 접근할 수 있으나 item으로 사용해야 한다.
                                                // 거기다가 list라는 변수명이 없으므로 list.Count같은 기능은 사용할 수 없다.
                    WriteLine(list.Count);      // 이것도 값을 비교하는 것이 아니라 참조타입과 비교하기 때문에 타입 패턴이다.

                else if (item is var elem)      // var 패턴이다.
                                                //else if(item is var)          // 타입 패턴과 달리 변수명을 생략할 수 없다.
                    WriteLine(elem);

                else if (item is var _)          // 변수가 필요없는 경우 _로 대체할 수 있다.
                    WriteLine(item);

                //object elem = item;           // var 패턴은 단순하게 item을 object형인 elem에 값을 넣고
                //if(true)                      // 항상 true가 되며 작업을 하기 때문에
                //    WriteLine(elem);          // var 패턴은 딱히 의미가 없다.

                else                            // 타입패턴이라는 이름에서 혼동할 수 있는데
                    WriteLine("아무것도 없음");  // item이 참조하는 대상의 값이 같을 때 작업을 하는 거지
                                           // 값이 다르더라도 값을 출력하는 것이 아니다.
                                           // 마찬가지로 대상이 List<int>형인 경우 작업을 하는 거지
                                           // List<double>형으로 했을 때 같은 리스트이므로 값을 출력한다의 의미가 아니다.
            }
        }
    }
}