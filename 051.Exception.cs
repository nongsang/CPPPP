using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Exeption
    {
        public static void Main()
        {
            int divisor = 0;

            try     // 이 아래에 있는 연산을 시도
            {
                int number = 10 / divisor;
                Console.WriteLine("예외가 발생하지 않으면 실행");
            }

            catch (System.DivideByZeroException)    // 0으로 나누면 실행
            {
                Console.WriteLine("0으로 나누는 예외가 발생하면 실행");
            }

            catch(System.NullReferenceException)    // null값을 참조할 때 실행
            {
                Console.WriteLine("null일 때 연산하면 실행");
            }

            catch (System.Exception)            // 기본 예외
            {
                Console.WriteLine("예외가 발생하면 실행");
            }

            catch                   // 바로 위에 정의한 예외와 같다.
            {                       // 모든 예외 사항은 이 예외문 위에 전부 정의해야 한다.
                Console.WriteLine("예외가 발생하면 실행");
            }
            
            finally                 // 예외가 생겨도 무조건 실행
            {
                Console.WriteLine("언제나 실행");
            }
        }
    }
}