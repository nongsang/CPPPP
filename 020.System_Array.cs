using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class System_Array
    {
        private static void OutputArrayInfo(Array arr)         // 배열은 System.Array에서 상속받으므로 매개변수를 Array형으로 사용할 수 있다.
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);    // Rank 프로퍼티, 배열의 차원수를 출력해준다.
            Console.WriteLine("배열의 요소 수 : " + arr.Length);  // Length 프로퍼티, 배열의 길이를 출력해준다.
        }

        private static void OutputArrayElements(string title, Array arr)
        {
            Console.WriteLine("[" + title + "]");

            for (int i = 0; i < arr.Length; ++i)         // 배열의 길이만큼
            {
                Console.Write(arr.GetValue(i) + ", ");  // GetValue로 원소에 접근할 수 있다. 
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, true } };   // 배열은 자동으로 System.Array을 상속받는다.
            OutputArrayInfo(boolArray);

            Console.WriteLine();

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);

            Console.WriteLine();

            OutputArrayElements("원본 intArray", intArray);
            Array.Sort(intArray);                           // 자동으로 오름차순 정렬
            OutputArrayElements("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];         // 새로운 배열을 기존의 배열의 길이를 사용하여 생성한다.
            Array.Copy(intArray, copyArray, intArray.Length);   // 소스, 목표, 갯수를 적으면 Copy()로 복사저장이 가능하다.

            OutputArrayElements("intArray로부터 복사된 copyArray", copyArray);
        }
    }
}