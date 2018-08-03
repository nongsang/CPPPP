using System;
using System.Collections.Generic;
using System.Linq;                  // LINQ를 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class LINQ_Immediately_Run
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            public override string ToString()
            {
                return string.Format("{0} : {1} in {2}", Name, Age, Address);
            }
        }

        class MainLanguage      // Person과 다른 클래스
        {
            public string Name { get; set; }
            public string Language { get; set; }
        }

        public static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "바보", Age = 19, Address = "Korea" },
                new Person { Name = "멍청이", Age = 25, Address = "Korea" },
                new Person { Name = "Adam", Age = 23, Address = "USA" },
                new Person { Name = "Marx", Age = 42, Address = "Germany" },
                new Person { Name = "Bacon", Age = 63, Address = "Britain" },
                new Person { Name = "Freud", Age = 25, Address = "Austria" },
                new Person { Name = "Nietzsche", Age = 23, Address = "Germany" }
            };

            List<MainLanguage> languages = new List<MainLanguage>       // Person 리스트와 별개로 다른 리스트가 존재
            {
                new MainLanguage { Name = "바보", Language = "C"},
                new MainLanguage { Name = "멍청이", Language = "C++"},
                new MainLanguage { Name = "바보", Language = "C#"},
                new MainLanguage { Name = "Freud", Language = "Java"},
                new MainLanguage { Name = "Marx", Language = "C++"},
                new MainLanguage { Name = "Benjamin", Language = "Python"}
            };


            var all = from person in people
                      // people에 있는 요소들을 person으로 가리켜서 반환하는데
                      where person.Address == "Korea"
                      // 가리킨 요소의 Address가 Korea인 경우만
                      select person;
                      // person형으로 형변환하여 (이미 person이면 그냥) all에 반환

            var oldestAge1 = all.Max((elem) => elem.Age);   // 주소가 Korea인 사람 가운데 가장 높은 연령을 추출한다.
                                                            // 여기서 oldestAge1는 int형이다.

            Console.WriteLine(oldestAge1);                   // 25

            // LINQ로 나타낸거랑 똑같지만 확장 메소드로 표현한 방법
            var oldestAge2 = people.Where((elem) => elem.Address == "Korea").Max((elem) => elem.Age);
            // 여기서도 oldestAge2는 int형이다.
            Console.WriteLine(oldestAge2);      // 따라서 foreach가 아니라도 값이 출력된다.
        }
    }
}

// 여기서 중요한 것은 Max 확장 메소드는 IEnumerable<T>로 반환하지 않는다는 것이다.
// 이 뜻은 메소드가 실행이 끝나면 결과값을 바로 생성된다는 점이다.
// foreach문으로 할 필요없이 출력이 가능하다.
// 따라서 LINQ에 있는 메소드라고 해도 전부 반환값이 IEnumerable<T>이 아니고 Max처럼 실행 즉시 반환을 하는 메소드도 존재한다.