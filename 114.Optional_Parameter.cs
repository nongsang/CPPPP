using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Optional_Parameter
    {
        static void Output(string name, int age = 0, string address = "Korea")          // 선택적 매개변수, C++의 디폴트 매개변수와 같다.
        {                                                                               // ref나 out과 같이 사용할 수 없다.
            Console.WriteLine(string.Format("{0} : {1} in {2}", name, age, address));
        }

        public static void Main()
        {
            Output("바보");               // 바보 : 0 in Korea -> 미리 값을 매개변수에 지정을 했기 때문에 가능
            Output("멍청이", 14);         // 멍청이: 14 in Korea
            Output("말미잘", 20, "USA");  // 말미잘 : 20 in USA
        }
    }
}