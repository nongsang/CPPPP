using System;
using System.Collections.Generic;
using System.Linq;                  // LINQ를 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class LINQ_OrderBy
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
                new Person { Name = "Nietzsche", Age = 23, Address = "Germany" },
            };

            var addrGroup = from person in people           // person이란 레퍼런스로 people 집단 중에서 원소 하나씩 지정하는데
                            where person.Age > 30           // Age가 30초과인 원소들만을
                            group person by person.Address; // person이 가리키는 원소들을 Address로 묶는다.
                                                            // group by는 select가 불가능하다.
                                                            // where로 조건을 주려면 group 앞에서 먼저 조건을 줄 것.
            foreach (var itemGroup in addrGroup)
            {
                Console.WriteLine(string.Format("[{0}]", itemGroup.Key));   // 무엇을 기준으로 묶었는지에 대한 키를 출력한다.

                foreach (var item in itemGroup)     // 전체
                    Console.WriteLine(item);        // 출력

                Console.WriteLine();
            }
        }
    }
}