using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]; // 1차원 배열 선언
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 }; //1차원 배열
            int[,] arr2 = new int[2, 3];
            int[,,] arr3 = new int[2, 3, 4];    // 3차원 배열

            int[][] arr4 = new int[5][];    // 2차원 가변배열
            arr4[0] = new int[10];      // 가변배열 선언
            arr4[1] = new int[4];
        }
    }
}

// 13행
// C/C++과 달리 자료형 옆에 []로 배열임을 알린다.
// 배열은 기본적으로 포인터이기 때문에 참조형식이므로 new로 동적할당하여 힙에 생성된다.

// 14행
// C/C++과 같이 원소의 갯수를 세어 배열의 크기를 정하는 방법을 사용할 수 있다.

// 15행
// 2차원 배열이다.
// 자료형 옆에 []안에 ,로 인수의 갯수를 알려준다.

// 16행
// 3차원 배열이다.
// 2차원 배열과 마찬가지로 []안에 ,를 2개 넣어서 인수가 3개 들어감을 알려준다.

// 18행
// 2차원 가변배열을 선언하는 방법이다.
// 다차원 배열을 선언하는 방법과 약간 다르게 자료형 옆에 []를 2개 써서 2차원 배열임을 알린다.
// 또한 행의 길이는 반드시 알려줘야 한다.

// 19행
// 정해지지 않은 나머지 열의 크기를 따로 정해줄 수 있다.
// 메모리 절약은 되지만 관리하기가 힘들어서 잘 안쓰인다.