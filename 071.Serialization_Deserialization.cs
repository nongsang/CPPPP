using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Serialization_Deserialization     // 여기서 CPPPP_DB / 01.Memory_Stream.cs로 데이터베이스를 공부하면 된다.
    {
        public static void Main()
        {
            // 기본 타입의 값을 GetBytes을 이용하여 바이트 배열로 변환
            // 이를 직렬화라고 한다.
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);

            // 바이트 배열을 기본 타입으로 복원
            // 이를 역직렬화라고 한다.
            // 바이트를 기본 자료형으로 변환하는 메소드는 어느 위치에서부터 변환을 하는지 인덱스를 명시해야 한다.
            bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
            short shortResult = BitConverter.ToInt16(shortBytes, 0);
            int intResult = BitConverter.ToInt32(intBytes, 0);

            // 직렬화된 바이트 배열을 출력하면 어떤 구조로, 어떤 순서로 데이터가 저장되어 있는지 알 수 있다.
            // 하지만 값이 거꾸로 출력이 되는데, 이는 CPU의 구조에 따라서 다르다.
            // 인텔호환 CPU는 리틀엔디안이라는 방식을 사용하는데, 데이터를 거꾸로 저장한다.
            // RISC 프로세서 계열에서는 빅엔디안이라는 방식을 사용하는데, 데이터를 곧바로 저장한다.
            // 대표적인 CPU로 AMD의 CPU가 있다.
            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));

            // 직렬화 역직렬화가 꼭 바이트 배열이여야만 하는 것이 아니다.
            // 수단이 바이트 배열이 아닌 문자열이 되는 경우도 있다.
            int n = 1652300;
            string text = n.ToString();     // 숫자 1652300을 문자열로 직렬화
            int result = int.Parse(text);   // 문자열로부터 숫자를 역직렬화해서 복원
        }
    }
}