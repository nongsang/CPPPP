using System;
using System.Collections.Generic;
using System.Linq;                  // LINQ를 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class LINQ_Join
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
                                 select new { Name = person.Name, Age = person.Age, Language = language.Language };
                                 // 그리고 익명타입으로 형변환하여 nameToLangList에 반환한다.

            foreach (var item in nameToLangList)     // 전체
                Console.WriteLine(item);             // 출력
        }
    }
}