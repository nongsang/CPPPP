using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;         // 스레드를 사용하려면 추가해야 한다.

namespace CPPPP
{
    class Anonymous_Method
    {
        static void Print()
        {
            Console.WriteLine("바보");
        }

        public static void Main()
        {
            //Thread th = new Thread();     // 그냥 인스턴스를 생성할 수 없고 생성과 동시에 실행할 메소드를 전달해야 한다.
            Thread th1 = new Thread(Print);  // 생성하면서 실행할 메소드의 이름을 전달해준다.

            th1.Start();        // th1 스레드 시작

            Thread th2 = new Thread(
                delegate (object obj)           // 정말 죽어도 1번만 쓸 메소드라면 delegate로 익명 메소드를 사용하면 편리하다.
                {                               // 매개변수의 자료형까지 정의 해줘야 한다.
                    Console.WriteLine("바보");
                });

            th2.Start();        // th2 스레드 시작

            th1.Join();         // th1과 th2에게 Join으로 나머지 스레드들이 전부 작업을 완료할 때까지 기다리라고 명령한다.
            th2.Join();         // 그렇지 않으면 Main()을 실행하는 스레드가 먼저 끝나는 경우 오류가 발생할 수 있다.
                                // 스레드는 따로 설명한다.
        }
    }
}