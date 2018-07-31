using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Array
    {
        private static void OutputArrayInfo(Array arr)          // 배열은 System.Array에서 상속받으므로 매개변수를 Array형으로 사용할 수 있다.
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);    // Rank 프로퍼티
            Console.WriteLine("배열의 요소 수 : " + arr.Length);  // Length 프로퍼티
        }

        private static void OutputArrayElements(string title, Array arr)
        {
            Console.WriteLine("[" + title + "]");

            int len = arr.Length;           // 변수에 길이를 저장하고
            for(int i = 0; i < len; ++i)    // 이렇게 쓰는게 좋다.
            {
                Console.Write(arr.GetValue(i) + ", ");      // GetValue
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
            Array.Sort(intArray);       // Sort
            OutputArrayElements("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];         // 새로운 배열 생성
            Array.Copy(intArray, copyArray, intArray.Length);   // Copy

            OutputArrayElements("intArray로부터 복사된 copyArray", copyArray);
        }
    }
}

// 11행
// 배열은 System.Array 클래스에서 상속받으므로 매개변수를 Array로 만들어서 사용할 수 있다.

// 13행
// Rank 프로퍼티는 배열의 차원수를 출력해준다.

// 14행
// Length 프로퍼티는 배열의 길이를 출력해준다.

// 21 ~ 22행
// for문의 조건식에 arr.Length();를 사용하는 것보다 변수에 값을 저장하여 사용하는 것이 더 빠르다.

// 24행
// arr.GetArray(i)로 배열의 원소에 접근할 수 있다.

// 31행
// 배열을 생성하면 자동으로 System.Array를 상속받는다.

// 42행
// 배열을 Sort로 정렬할 수 있다.
// 기본은 오름차순이다.

// 45행
// 새로운 배열을 기존의 배열의 길이를 사용하여 생성한다.

// 46행
// 소스, 목표, 갯수를 적으면 Copy()로 복사저장이 가능하다.