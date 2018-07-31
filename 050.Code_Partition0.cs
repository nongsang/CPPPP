using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;      // 내가 만든 파일과 연결할 수 있다.
                // 파일 이름이 아니라 namespace 이름이다.

namespace CPPPP
{
    class Code_Partition
    {
        public static void Main()
        {
            Log.LogWrite.Write("바보");   // 그냥 솔루션 자체에 코드 파일이 있으면 그냥 사용할 수 있다.
        }
    }
}