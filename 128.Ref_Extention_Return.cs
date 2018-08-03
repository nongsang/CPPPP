using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class IntList
    {
        int[] list = new int[2] { 1, 2 };   // 배열로 만들고

        public int[] GetList()              // 배열을 반환해서 값을 바꿔야 했다.
        {
            return list;
        }

        public ref int GetFirstItem()       // C# 7.0이 되면서
        {
            return ref list[0];             // ref로 배열 요소 하나만 반환하는 것이 가능해졌다.
                                            // 반환값이 ref int형이며 반환하는 대상도 ref로 반환함을 알려줘야 한다.
        }

        internal void Print()
        {
            Array.ForEach(list, (e) => Console.Write(e + ","));
            Console.WriteLine();
        }
    }

    class Ref_Extention_Return
    {
        static void Main(string[] args)
        {
            {
                IntList intList = new IntList();        // 클래스를 사용한다고 하고
                int[] list = intList.GetList();         // 리스트를 가져와서
                list[0] = 5;                            // 요소의 값을 바꿔야 했다.
                                                        // 왜냐하면 배열은 참조형이기 때문에 배열을 받아와야 인덱스 접근하여
                                                        // 값을 바꿀 수 있기 때문

                intList.Print();                        // 전체 값 출력
            }

            {
                IntList intList = new IntList();
                ref int item = ref intList.GetFirstItem();  // GetFirstItem의 반환값이 ref임에도 ref로 명시를 해줘야 한다.
                item = 5;                                   // 배열의 첫번째 값을 5로 저장

                intList.Print();                            // 전체 값 출력
            }

            {
                MyMatrix matrix = new MyMatrix();
                matrix.Put(0, 0) = 1;                       // ref의 극단적인 예로 메소드에 값을 전달할 수 있다.
                                                            // 메소드를 하나의 변수로 사용이 가능한 것이다.

                int result = matrix.Put(0, 0) = 1;          // 따라서 메소드를 호출함과 동시에 변수에 값을 전달하는 것도 가능하다.
                Console.WriteLine(result);
                Console.WriteLine(matrix.Put(0, 0));        // 하지만 여기까지 메소드를 벌써 3번이나 호출했다.
                                                            // 직관적이지 않으니까 가급적이면 쓰지 말자.
            }
        }
    }

    class MyMatrix
    {
        int[,] _matrix = new int[100, 100];

        public ref int Put(int column, int row)
        {
            return ref _matrix[column, row];
        }
    }
}