using System;
using System.Collections;           // IEnumerable을 사용하려면 추가
using System.Collections.Generic;   // IEnumerable<int>도 사용하고 있으므로 추가
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NaturalNumber : IEnumerable<int>   // IEnumerable을 상속받아서 GetEnumerator 기능을 사용할 수 있다.
{
    public IEnumerator<int> GetEnumerator()     // IEnumerable<int>에 있는 GetEnumerator 오버라이딩
    {
        return new NaturalNumberEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()     // IEnumerable에 있는 GetEnumerator 오버라이딩
    {
        return new NaturalNumberEnumerator();   // GetEnumerator()은 둘 다 정의를 해줘야 한다.
    }

    public class NaturalNumberEnumerator : IEnumerator<int> // 클래스 안에 있는 클래스도 IEnumerable<int>를 상속
    {                                                       // IEnumerator<int>의 기능도 상속받는다.
        int current;                                        // 그리고 직접적으로 IEnumerator<int>의 기능을 사용한다는 의미이다.

        public int Current              // IEnumerator<int>의 Current 프로퍼티 오버라이딩
        {
            get { return current; }     // 현재값 반환
        }

        object IEnumerator.Current      // IEnumerator의 Current 프로퍼티 오버라이딩
        {
            get { return current; }     // Current 프로퍼티 둘 다 정의를 해줘야 한다.
        }

        public void Dispose() { }       // Dispose() 오버라이딩

        public bool MoveNext()          // IEnumerator<int>의 MoveNext() 오버라이딩
        {
            ++current;                  // 값을 하나 올리고
            return true;                // true 반환
        }

        public void Reset()             // 리셋하면
        {
            current = 0;                // 0
        }
    }
}

namespace CPPPP
{
    class Natural_Number_Infinite_Set
    {
        public static void Main()
        {
            NaturalNumber number = new NaturalNumber(); // 생성하면서 number는 NaturalNumberEnumerator 기능을 사용한다.

            foreach (int n in number)       // number의 Current와 MoveNext를 호출하면서 다음 요소로 전진할 뿐이다.
                Console.WriteLine(n);       // 값을 출력
        }
    }
}

// foreach문이 동작하는 순서는 이렇다.
// 1. GetEnumerator()를 호출하여 IEnumerator를 받아온다.
// 2. MoveNext()를 하여 다음 요소가 있으면 다음 요소를 가리키게 하고 true를 반환한다.
//    여기서 MoveNext()는 필드의 값을 +1로 구현하여 다음 요소로 넘어감을 표현했다.
// 3. Current를 호출하여 현재 가리키는 요소를 반환한다.
// 4. 2, 3을 반복한다.
//
// 단순히 필드 하나의 값을 계속 +1하면서 요소를 받환받은 것밖에 없다.
// 무한집합은 List같은 자료형일 경우 무한한 크기를 가져야 구현이 가능하다.
// 하지만 IEnumerator와 IEnumerable을 이용하면 메모리에 상관없이 무한집합을 구현할 수 있다.

// IEnumerable과 IEnumerable<T>, IEnumerator와 IEnumerator<T>의 관계가 궁금해진다.
// 어떻게 제너릭하게 구현되어 있을까?
//
// IEnumerable<T>는 IEnumerable을 상속받는다.
// 그리고 GetEnumerator()를 오버라이딩 하여 IEnumerator<T>를 반환한다.
//
// IEnumerator<T>는 IEnumerator를 상속받는다.
// IEnumerator의 Current는 object, MoveNext()는 bool, Reset()는 void를 반환한다.
// IEnumerator<T>는 IEnumerator의 Current만 T를 반환하도록 오버라이딩 되어있다.
// 또한 IDisposable을 상속받으므로 Dispose() 오버라이딩 해줘야 한다.
// Current만 T형으로 오버라이딩 되어있으므로 값을 받아 출력할 때 오버헤드가 없는 것이다.