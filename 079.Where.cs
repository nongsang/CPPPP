using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book { }  // IComparable을 상속받지 않은 깡 클래스

class BookUtility       // Book을 사용하는 클래스
{
    public static Book Max(Book item1, Book item2)
    {
        if (item1.CompareTo(item2) >= 0)    // item1은 Book형이며, IComparable에 있는 CompareTo를 상속받지도, 재정의하지도 않았으므로 오류
            return item1;

        return item2;
    }
}

class GenericUtility    // 자료형을 제너릭하게 사용하는 클래스
{
    public static T Max<T>(T item1, T item2)
    {
        if (item1.CompareTo(item2) >= 0)    // 제너릭하게 템플릿으로 정의해도 Book처럼 CompareTo를 재정의하지 않은 클래스가 존재하므로 오류
            return item1;

        return item2;
    }
}

class Utility   // 템플릿을 사용하지만 제약조건을 걸었다.
{
    public static T Max<T>(T item1, T item2) where T : IComparable  // T는 제너릭이지만 IComparable을 상속받는 데이터만 대입이 가능하다.
    {
        if (item1.CompareTo(item2) >= 0)        // IComparable을 상속받은 모든 객체들은 CompareTo를 사용할 수 있으므로 컴파일 성공
            return item1;

        return item2;
    }
}

namespace CPPPP
{
    class Where
    {
        public static void Main()
        {
            Console.WriteLine(Utility.Max(1, 2));   // IComparable을 상속받은 객체만 받을 수 있게 정의했으므로 값이 나온다.
            Console.WriteLine(BookUtility.Max(1, 2));   // Book형은 IComparable을 상속받지도 않았고, CompareTo도 정의가 안되어 있으므로 오류
            Console.WriteLine(GenericUtility.Max(1, 2));    // 제너릭하지만 모든 객체가 IComparable을 상속받지 않았으므로 실행도중 오류
        }
    }
}