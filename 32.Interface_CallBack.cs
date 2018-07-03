using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;       // IComparer를 사용하려면 추가해야 한다.

class IntegerCompare : IComparer        // IComparer를 상속
{
    public int Compare(object x, object y)      // IComparer를 Compare(object x, object y)를 오버라이딩
    {
        int xValue = (int)x;
        int yValue = (int)y;

        if (xValue > yValue) return -1;
        else if (xValue == yValue) return 0;

        return 1;
    }
}

namespace CPPPP
{
    class Interface_CallBack
    {
        public static void Main()
        {
            int[] intArray1 = new int[] { 5, 4, 3, 2, 1, 0 };   // 내림차순일 때

            Array.Sort(intArray1, new IntegerCompare());    // Compare()메소드를 오버라이딩한 클래스를 Sort에 넣어서 정렬한다.
            foreach (int item in intArray1)         // 오름차순으로 정렬된다.
                Console.Write(item + " ");
            Console.WriteLine();

            int[] intArray2 = new int[] { 0, 1, 2, 3, 4, 5 };   // 오름차순일 때

            Array.Sort(intArray2, new IntegerCompare());    // Compare()메소드를 오버라이딩한 클래스를 Sort에 넣어서 정렬한다.
            foreach (int item in intArray2)         // 내림차순으로 정렬된다.
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

// 6행
// IComparer를 사용하려면 포함해줘야 하는 라이브러리다.
// 2행에서 비슷한 것을 포함했는데, 이것은 제너릭이 포함된 것이다.
// 조금 다르다.

// 8 ~ 20행
// IComparer를 상속하여 클래스를 정의해줬다.
//
// 10 ~ 19행
// IComparer에 있는 Compare(object x, object y)를 오버라이딩한다.

// 28행
// 배열이 내림차순으로 정렬되어 있을경우를 만든다.

// 30행
// 배열을 정렬하는 Array.Sort()를 사용하여 배열을 정렬한다.
// 정렬기준은 IntegerCompare 클래스를 참조한다.
// 왜냐하면 IntegerCompare가 IComparer의 Compare()메소드를 가지고 있기 때문이다.
// IComparer를 전달해주어야 하나 인터페이스는 전달할 수 없으므로 클래스로 구현하여 전달해야 한다.

// 31, 32행
// 배열이 내림차순으로 정의가 되어 있으므로 오름차순으로 정렬된다.

// 35행
// 배열이 오름차순으로 정렬되어 있을경우를 만든다.

// 37행
// Sort()메소드를 사용하여 IntergerCompare와 같이 전달한다.

// 38, 39행
// 배열이 오름차순으로 정의되 되어 있으므로 내림차순으로 정렬된다.

// 오름차순, 내림차순으로 결정하는 기준은 첫 요소와 바로 뒷 요소와 비교했을 때 첫 요소가 크면 오름차순, 뒷 요소가 크면 내림차순으로 정렬된다.