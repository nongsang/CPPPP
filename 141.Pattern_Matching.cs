using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    // WriteLine()이라고 줄여서 쓰고싶어

namespace CPPPP
{
    class Pattern_Matching
    {
        public static void Main()
        {
            object obj = new List<string>();            // 리스트를 object형 변수에 저장

            //List<string> list = obj as List<string>;  // 기존에는 as로 형변환해서 저장해야 사용이 가능했다.

            if (obj is List<string> list)               // is를 사용해서 패턴을 매칭한다.
            {                                           // is만으로도 obj를 string으로 형변환하여 list 각 원소에 접근하여 작업을 한다.
                list.ForEach((e) => WriteLine(e));      // ForEach는 작업을 위한 메소드를 전달해야 하므로 람다로 전달한다.
            }                                           // obj는 obj임을 이미 알고 있으므로 뒤에 있는 접근할 대상의 자료형을 명시하므로써
                                                        // as의 역할을 is로 할 수 있다.

            if (obj is List<string>)    // List<string>의 뒤에 변수 이름이 없으면 
                WriteLine("바보");      // 그냥 obj 자료형이 호환이 되는지만 판별한다.
        }
    }
}