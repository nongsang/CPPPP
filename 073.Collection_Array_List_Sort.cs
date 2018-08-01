using System;
using System.Collections;           // 자료구조를 사용하려면 추가, 콜렉션의 문제는 object를 인자로 받기 때문에 박싱이 발생한다.
using System.Collections.Generic;   // 값형식까지 커버하고 싶으면 Generic을 사용해야 한다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person : IComparable      // CompareTo를 정의할 수 있다.
{
    public int Age;
    public string Name;

    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }

    public int CompareTo(object obj)        // CompareTo를 정의해줘서 비교하여 정렬할 수 있다.
    {
        Person target = (Person)obj;

        if (this.Age > target.Age) return 1;
        else if (this.Age == target.Age) return 0;

        return -1;              
    }

    public override string ToString()
    {
        return string.Format("{0}({1})", this.Name, this.Age);
    }
}

namespace CPPPP
{
    class Collection_Array_List_Comparison
    {
        public static void Main()
        {
            ArrayList ar = new ArrayList();

            // Person 요소들만 저장한다.
            ar.Add(new Person(32, "Cooper"));
            ar.Add(new Person(56, "Anderson"));
            ar.Add(new Person(17, "Sammy"));
            ar.Add(new Person(27, "Paul"));

            ar.Sort();      // 모든 타입이 Person으로 같기 때문에 정렬이 가능
                            // 정렬은 비교연산으로 결과가 나오며, 비교기준이 있어야 한다.
                            // 그리고 Person은 내가 만든 클래스 타입이기 때문에 비교기준을 정의해줘야 한다.
                            // IComparable을 상속 받아서 CompareTo에 비교기준을 정의해주면 비교기준에 따라서 정렬한다.

            foreach (Person person in ar)
            {
                Console.WriteLine(person);
            }
        }
    }
}