using System;
using System.Collections.Generic;
using System.Linq;                  // LINQ를 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

namespace CPPPP             // 데이터가 많으면 찾기가 힘들다.
{                           // 그래서 DB에서 사용하는 쿼리문을 사용할 수 있는 기능이 LINQ다.
    class Person                    // 사람 데이터를 만든다.
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1} in {2}", Name, Age, Address);
        }
    }

    class LINQ
    {
        public static void Main()
        {
            List<Person> people = new List<Person>          // 각 요소가 Person인 리스트
            {
                new Person { Name = "바보", Age = 19, Address = "Korea" },        // 리스트를 생성하자마자 넣는 방법이다.
                new Person { Name = "멍청이", Age = 25, Address = "Korea" },       // 예전에는 리스트를 먼저 만들어 놓고
                new Person { Name = "Adam", Age = 23, Address = "USA" },          // Add() 메소드를 이용해서
                new Person { Name = "marx", Age = 42, Address = "Germany" },      // 반복해서 넣어줬어야 했다.
                new Person { Name = "Bacon", Age = 63, Address = "Britain" },     // C# 3.0부터 가능한 문장이다.
                new Person { Name = "Freud", Age = 25, Address = "Austria" },
                new Person { Name = "Nietzsche", Age = 23, Address = "Germany" },
            };

            var all1 = from person in people select person;  // LINQ를 사용하였다.
            // SELECT * FROM people 쿼리문이다.
            // people이라는 데이터 더미에서 전부를 찾는다는 뜻이다.
            // *은 전부를 뜻한다.
            // 그러므로 이 LINQ문은
            // foreach(var person in people)
            //    yield return person;
            // 으로 해석이 가능하다.
            // people의 원소를 person이라는 레퍼런스로 모두 돌면서 person 레퍼런스가 가리키는 모든 것을 반환하는 것.
            // 그리고 그 원소들을 all에 저장한다.
            // 여기서 all1은 IEnumerable<person>형이다.

            foreach (var item in all1)       // all에 저장된 값들을
                Console.WriteLine(item);    // 모두 출력

            var all2 = from person in people select person.Name; // person 레퍼런스가 가리키는 원소의 Name부분만 출력할 수 있다.
                                                                 // 여기서 all2는 IEnumerable<string>형이다.

            foreach (var item in all2)      // all2에 이름만 저장되므로
                Console.WriteLine(item);    // 이름만 출력된다.
        }
    }
}