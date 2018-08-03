using System;
using System.Collections.Generic;
using System.Linq;                  // LINQ를 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class LINQ_Outer_Join
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

            var nameToLangList = from person in people
                                     // people에 있는 요소들을 person으로 가리켜서 반환하는데
                                 join language in languages
                                 // languages에 있는 요소들을 language로 가리켜서 서로 연관짖는다.
                                 on person.Name equals language.Name
                                 // person이 가리키는 요소의 Name과 language가 가리키는 요소의 Name이 같은 것끼리 묶어서
                                 into lang
                                 // lang에다 콜렉션으로 저장한다.
                                 from language in lang.DefaultIfEmpty(new MainLanguage())
                                 // language로 lang의 요소들을 가리키는데 lang의 요소들은 people의 목록이 기준이다.
                                 // 이 목록에서 languages에 없는 요소들은 new MainLanguage()를 하여 값이 없는 상태로 저장한다.
                                 select new { Name = person.Name, Age = person.Age, Language = language.Language };
                                 // 그리고 익명타입으로 형변환하여 nameToLangList에 반환한다.
                                 // 주의해야 할 점은 제일 위에 있는 language와 그 밑의 language는 서로 다른 변수라는 것이다.
                                 // 그리고 lang의 목록은 people이 중심이므로 languages에 있는 Benjamin은 목록에 들어가지 않는다.

            foreach (var item in nameToLangList)     // 전체
                Console.WriteLine(item);             // 출력
        }
    }
}

// 111.LINQ_Join에서 제공하는 기능은 두 자료구조의 공통된 부분만 반환한다.
// people에 있는 Bacon, Freud, Nietzsche는 MainLanguage에 없으므로 제외한다.
// 이를 내부 조인(Inner Join)이라고 한다.
// 하지만 MainLanguage에 없어도 people에 있기 때문에 모든 목록을 작성하고 싶은 경우가 있다.
// 이럴 때는 MainLanguage에는 없는 필드가 있기 때문에 없는 필드는 비우고 반환받아서 만들면 된다.
// 이를 외부 조인(Outer Join)이라고 한다.
// SQL에는 외부조인을 표현하기 위한 구문이 존재하지만 LINQ에는 없지만 그에 준하는 기능을 제공한다.
// DefaultIfEmpty를 이용하여 후처리를 더 하는 것이다.