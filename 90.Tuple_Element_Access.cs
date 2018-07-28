using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Tuple_Element_Access
    {
        static (bool, int) ParseInteger(string txt) // 값을 2개 던지나 튜플의 원소의 이름이 없다.
        {                                           // 다른 위치에서 사용할 때 이름을 부여할 수 있다.
            int number = 0;                         // 사실 원소 이름이 있어도 없어도 상관없다.
            bool result = false;

            try
            {
                number = int.Parse(txt);
                result = true;
            }
            catch { }

            return (result, number);        // 반환할 때 Tuple을 만들어서 반환하지 않고 그냥 던진다.
        }

        public static void Main()
        {
            //(var success, var number) result = ParseInteger("10");// 튜플의 변수 명이 있으면 오류가 생긴다.
                                                                    // (var success, var number) 자체를 자료형으로 인식하기 때문이다.
            (var success, var number) = ParseInteger("10");         // 튜플의 변수명 없이 튜플의 각 원소명만 있어야 저장이 가능하다.

            WriteLine(success);     // 각 원소명에 접근하여
            WriteLine(number);      // 출력이 가능하다.
        }
    }
}