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
                new Person { Name = "marx", Age = 42, Address = "Germany" },
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
                new MainLanguage { Name = "marx", Language = "C++"}
            };

            var nameToLangList = from person in people  // person이란 레퍼런스로 people 집단의 원소 하나씩 지정하고
                                 // language라는 레퍼런스를 languages 집단의 원소를 하나씩 지정하여
                                 // person이 가리키는 원소의 Name 필드와 language가 가리키는 원소의 Name 필드가 같은 원소들을 묶어서
                                 join language in languages on person.Name equals language.Name
                                 // 익명 타입으로 변환한 문자열로 출력한다.
                                 select new { Name = person.Name, Age = person.Age, Language = language.Language };
                                 // 서로 별개의 자료구조를 연관지어서 같은, 혹은 다른 데이터를 찾는데 쓰일 수 있다.

            foreach (var item in nameToLangList)     // 전체
                Console.WriteLine(item);             // 출력
        }
    }
}