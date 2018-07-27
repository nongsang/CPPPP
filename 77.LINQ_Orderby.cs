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

            var ageOver30 = from person in people       // person이란 레퍼런스로 people 집단 중에서 원소 하나씩 지정하는데
                            orderby person.Age ascending// person이 가리키는 원소의 Age의 오름차순으로 정렬, ascending이 없어도 자동 오름차순
                                                        // 내림차순으로 하고 싶으면 decending으로 바꾼다.
                            where person.Age > 30       // 원소의 Age 필드의 값이 30 초과인 원소의
                            select person;              // 원소 전체를 반환

            foreach (var item in ageOver30)     // 전체
                Console.WriteLine(item);        // 출력
        }
    }
}