using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;      // 식을 표현한 데이터, 식 트리(Expression tree)를 사용하기 위해 추가

namespace CPPPP
{
    class Data_Lambda_Expression
    {
        public static void Main()
        {
            Expression<Func<int, int, int>> exp = (a, b) => a + b;      // 람다 식을 데이터로써 표현한 것일 뿐이다.

            // 람다 식 본체의 루트는 2항 연산자인 + 기호
            BinaryExpression opPlus = exp.Body as BinaryExpression;     // 표현식을 이항 표현식으로 형변환
            Console.WriteLine(opPlus.NodeType);                         // 이항 표현식의 타입은 Add이므로 add 출력

            // 2항 연산자의 좌측 연산자의 표현식
            ParameterExpression left = opPlus.Left as ParameterExpression;  // 이항 표현식을 인자 표현식으로 변환
            Console.WriteLine(left.NodeType + ": " + left.Name);            // 출력 결과: Parameter: a

            // 2항 연산자의 우측 연산자의 표현식
            ParameterExpression right = opPlus.Right as ParameterExpression;// 이항 표현식을 인자 표현식으로 변환
            Console.WriteLine(right.NodeType + ": " + right.Name);          // 출력 결과: Parameter: b

            Func<int, int, int> func = exp.Compile();                   // 그냥 데이터로써 표현식을 쓰지만 컴파일하여 사용할 수 있다.
            Console.WriteLine(func(10, 2));                             // 출력 결과: 12

            ParameterExpression leftExp = Expression.Parameter(typeof(int), "a");   // 왼쪽 인자를 만들고
            ParameterExpression rightExp = Expression.Parameter(typeof(int), "b");  // 오른쪽 인자를 만들어서
            BinaryExpression addExp = Expression.Add(leftExp, rightExp);            // 이항 표현식으로 만든다.

            Expression<Func<int, int, int>> addLamda =                          // 표현식을 새롭게 만드는데
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(    // 람다를 사용한다.
                    addExp, new ParameterExpression[] { leftExp, rightExp }     // 이항 연산자 addExp와 인자 표현식 left와 right를 묶는다.
                    );

            Console.WriteLine(addLamda.ToString());             // 표현식을 출력

            Func<int, int, int> addFunc = addLamda.Compile();   // 표현식을 컴파일하여 사용할 수 있게 저장
            Console.WriteLine(addFunc(10, 2));                  // 출력 결과: 12
        }
    }
}