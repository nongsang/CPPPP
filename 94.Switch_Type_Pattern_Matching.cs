using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Switch_Type_Pattern_Matching
    {
        public static void Main()
        {
            object[] objList = new object[] { 100, null, DateTime.Now, new List<int>() };   // 배열의 각 요소들은 다른 값을 가지고 있다.
            //object[] objList = null;     // null이면 아무값도 안가지고 있다는 의미이므로 System.NullReferenceException이 발생한다.

            foreach (object item in objList)    // 배열에 있는 모든 요소들을 순회하며 접근
            {
                switch (item)
                {
                    case 100:               // 100이 있으면
                        WriteLine(item);    // 값을 출력
                        break;
                    case null:              // null이 있으면
                        WriteLine("Null");  // 값을 출력
                        break;
                    case DateTime dt:       // DateTime 자료형을 가진 요소가 있으면
                        WriteLine(item);    // DateTime을 가리키는 item의 값을 출력
                        break;
                    case List<int> list:        // List<int>형 데이터가 있으면 list의 데이터 갯수 출력
                        WriteLine(list.Count);  // List<int>형인지를 검사하는 것이지 List<double>처럼 같은 리스트라고 출력하지는 않는다.
                        break;
                    //default:      // 기존처럼 default로 해도 되고.
                    case var elem:  // 이렇게 해도 default랑 같은 뜻이다.
                                    // elem는 아무 의미 없음
                        WriteLine("아무것도 없음");
                        break;
                }
            }
        }
    }
}