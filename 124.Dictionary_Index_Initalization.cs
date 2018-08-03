using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Dictionary_Index_Initalization
    {
        static void Main(string[] args)
        {
            {
                var weekends = new Dictionary<int, string>  // 기존 딕셔너리를 초기화하는 방법
                {
                    { 0, "Sunday" },
                    { 6, "Saturday" },
                    { 6, "Saturday2" },         // 키값이 같으면 컴파일 오류는 발생하지 않으나 ArgumentException이 발생한다.
                };
            }

            {
                Dictionary<int, string> weekends = new Dictionary<int, string>();   // 위의 딕셔너리 초기화는 이런 방식으로 컴파일 된다.
                                                                                    // 딕셔너리를 생성하고
                weekends.Add(0, "Sunday");                                          // 값을 하나씩
                weekends.Add(6, "Saturday");                                        // 추가하는 방법을 사용한다.
                weekends.Add(6, "Saturday2");                                       // 이 방법도 ArgumentException이 발생한다.
            }

            {
                var weekends = new Dictionary<int, string>  // C# 6.0부터 새로운 딕셔너리 초기화를 제공한다.
                {
                    [0] = "Sunday",                         // 키 / 값 개념에 좀 더 어울리는
                    [6] = "Saturday",                       // 직관적인 초기화 구문이다.
                    [6] = "Saturday2",                      // 기존 딕셔너리 초기화처럼 ArgumentException이 발생하지 않고
                                                            // 키값을 찾아서 값을 바꾼다.
                };
            }

            {
                Dictionary<int, string> weekends = new Dictionary<int, string>();   // 위의 딕셔너리 초기화는 이런 방식으로 컴파일 된다.
                                                                                    // 딕셔너리를 생성하고
                weekends[0] = "Sunday";                                             // 키와 값을 바로 넣는다.
                weekends[6] = "Saturday";
                weekends[6] = "Saturday2";                                          // 키값을 찾아서 값을 바꾼다.
            }

            var people = new Dictionary<string, int>
            {
                ["Anders"] = 7,      // TKey 타입이 string이므로 인덱서 초기화도 string 타입
                ["Sam"] = 10,
            };
        }
    }
}