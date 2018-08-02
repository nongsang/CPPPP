using System;
using System.Collections;
using System.Collections.Generic;       // 제너릭 콜렉션을 사용하려고 추가
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person                            // 콜렉션에 넣을 클래스
{
    public int Age { get; set; }
    public string Name { get; set; }
}

namespace CPPPP
{
    class Collections_Initialization
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();    // 예전에는 콜렉션을 미리 만들어 놓고
            numbers.Add(0);                         // 요소를 넣었어야 했다.
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            List<int> numbers2 = new List<int> { 0, 1, 2, 3, 4 };   // 지금은 콜렉션 생성과 동시에 값을 넣어 초기화할 수 있다.

            List<Person> list = new List<Person>                    // 기본 자료형뿐만 아니라 내가 만든 클래스형도
            {
                new Person { Name = "Ally", Age = 35 },             // 생성과 동시에 값을 할당하고
                new Person { Name = "Luis", Age = 40 },             // 콜렉션에 저장할 수 있다.
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + ": " + item.Age);
            }
        }
    }
}