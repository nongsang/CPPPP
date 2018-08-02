using System;
using System.Collections.Generic;
using System.Linq;                  // Where을 사용하려면 추가
using System.Text;
using System.Threading.Tasks;

class Person            // 요소로 사용될 클래스
{
    public int Age;
    public string Name;
}

namespace CPPPP
{
    class Lazy_Evaluation_Select
    {
        public static void Main()
        {
            List<int> list = new List<int> { 3, 1, 4, 5, 2 };

            {
                IEnumerable<double> doubleList = list.Select(elem => (double)elem);         // elem이라는 변수로 가리키는데
                                                                                            // 가리킨 요소들을 double로 형변환하여
                                                                                            // doubleList형에 반환한다.
                                                                                            // Select는 형변환이 중요한게 아니고
                                                                                            // 해당하는 요소를 뽑아서 반환하는 것이다.
                                                                                            // (double)가 있어서 형변환하고 반환하는 것뿐
                Array.ForEach(doubleList.ToArray(), elem => { Console.WriteLine(elem); });  // doubleList를 배열로 바꾸고
                                                                                            // elem이라는 변수가 가리키는 요소는
                                                                                            // 화면에 출력한다.
                                                                                            // 이 모든 것을 배열갯수만큼 반복한다.
            }

            Console.WriteLine();

            IEnumerable<Person> personList = list.Select(                           // Select로 뽑아서 반환하는데 
            elem => new Person { Age = elem, Name = Guid.NewGuid().ToString() });   // Person 클래스에 값을 넣어서 던진다.
                                                                                    // list에 있는 값을 elem이 가져오고 Age에 저장한다.
                                                                                    // Name에는 Guid라는 기능을 사용한다.
                                                                                    // Globally Unique Identifier, 전역 고유 식별자인데,
                                                                                    // 식별자를 위한 유사난수이다.
                                                                                    // 프로그램을 돌릴 때마다 다른 값이 나온다.
                                                                                    // 고유 식별자를 Name에 저장한다.
            Array.ForEach(personList.ToArray(), (elem) => { Console.WriteLine(elem.Name); });   // 식별자만 출력

            Console.WriteLine();

            var itemList = list.Select(elem => new { TypeNo = elem, CreatedDate = DateTime.Now.Ticks });// 익명타입으로 구조체처럼 만들어서
                                                                                                        // 그냥 itemList에 반환할 수 있다.
            Array.ForEach(itemList.ToArray(), elem => { Console.WriteLine(elem.TypeNo); });
        }
    }
}

// FindAll의 지연된 평가 버전은 Where이다.
// 이와같이 ConvertAll의 지연된 평가 버전이 Select다.

// 지연된 평가의 장점은 실제로 데이터가 필요한 순간에만 코드가 CPU에 의해 실행된다는 점이다.
// FindAll, ConvertAll은 List<T>가 반환형이므로 FindAll, ConvertAll이 실행된 후 조건에 맞는 목록를 저장하기 위한 메모리가 필요하다.
// 그리고 List<T>형 변수에 복사 저장한다.
// 메모리 할당과 메모리 복사가 이루어지므로 그만큼 성능이 저하된다.
// Where, Select는 IEnumerable<T>가 반환형이다.
// IEnumerable<T>형 변수에 호출이 되면 무엇을 어떻게 작동할지 알려주기만 하는 것이다.
// 그리고 IEnumerable<T>형 변수가 호출되는 순간부터 자원을 할당받아 일을 하기 시작한다.

// 만약 1만개의 소수를 반환하는 메소드를 구현했다고 가정하자.
// List<T>형을 반환하는 FindAll로 구현하면 500개만 필요하다고 하더라도 1만개를 반환할 때까지 CPU가 실행되야 한다.
// IEnumerable<T>형을 반환하는 지연된 평가를 사용해 결과가 반환된 경우에는 500개까지 데이터만 반환받고 끝낼 수 있다.