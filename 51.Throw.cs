using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Throw
    {
        private static void HasProblem()
        {
            string txt = null;

            Console.WriteLine(txt.ToUpper());
        }

        public static void Main()
        {
            string txt = Console.ReadLine();

            if( txt != "123")
            {
                ApplicationException ex = new ApplicationException("틀린 암호");    // 예외용 객체를 생성해
                throw ex;                                                           // 예외를 던진다.
            }

            try
            {
                HasProblem();           // 일부러 예외를 만들어보자
            }
            //catch (System.Exception ex)   // 인스턴스를 던지면
            //{
            //    throw ex;                 // 실행되다 예외가 발생한 위치만 알려주고
            //}
            catch (System.Exception)        // 객체를 던지면
            {
                throw;                      // 실행되다 예외가 발생한 위치와 실제 예외가 발생한 위치까지 알려준다.
            }                               // 예외를 발생할거면 이 방법을 사용하자
        }
    }
}