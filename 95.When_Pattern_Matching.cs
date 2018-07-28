using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class When_Pattern_Matching
    {
        public static void Main()
        {
            int i = 345;

            if (i > 300) { }    // 이 if문을
            else { }            // switch문으로 바꿀  수 있다.    

            switch (i)
            {
                case int j when j > 300:    // 새롭게 생성한 int형 j에 i값을 저장 후 300을 초과하는지 검사한다.
                    WriteLine(j);           // 300을 초과한다면 출력
                    break;

                default:                    // 그렇지 않다면
                    WriteLine("바보");      // 출력 안함
                    break;
            }
        }
    }
}