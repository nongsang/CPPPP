using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Short_Circuit_Evaluation
    {
        public static void Main()
        {
            int n1 = 10;
            int n2 = 6;

            bool result = ((n1 % 3) == 0 && (n2 % 3) == 0); // (n1 % 3) == 0에서 이미 false이기 때문에 (n2 % 3) == 0는 연산을 하지 않는다.
                                                            // 이를 단락 계산 또는 단축 평가라고 한다.
        }
    }
}