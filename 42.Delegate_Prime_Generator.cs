using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CallbackArg { }   // 콜백의 값을 담는 클래스의 최상위 부모 클래스

class PrimeCallbackArg : CallbackArg    // 소수값을 전달받아 인스턴스를 생성하는 클래스
{
    public int Prime;

    public PrimeCallbackArg(int prime)
    {
        this.Prime = prime;
    }
}

class PrimeGenerator
{
    public delegate void PrimeDelegate(object sender, CallbackArg arg); // 콜백을 위한 델리게이트 정의

    PrimeDelegate callbacks;

    public void AddDelegate(PrimeDelegate callback)     // 델리게이트에 콜백 메소드를 결합
    {
        //Delegate.Combine(callbacks, callback) as PrimeDelegate; // 이렇게만 쓰면 안된다.
        callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate; // 이렇게 델리게이트 대입을 해야 한다.
        //callbacks += callback;    // 이렇게 써도 상관없다.
    }

    public void RemoveDelegate(PrimeDelegate callback)  // 델리게이트에 안쓰는 콜백 메소드를 해지
    {
        //Delegate.Remove(callbacks, callback) as PrimeDelegate;  // 이것도 마찬가지로 이렇게만 쓸 수 없다.
        callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;  // 꼭 델리게이트에 대입하도록
        //callbacks -= callback;    // 이렇게 써도 된다.
    }

    public void Run(int limit)      // 양수를 넣으면 그 수까지 소수를 찾는다.
    {
        for(int i = 2; i <= limit; ++i)
        {
            if (IsPrime(i) == true && callbacks != null)
            {
                // 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                callbacks(this, new PrimeCallbackArg(i));       // 여기서 소수값을 전달받자마자 델리게이트에 연결된 모든 메소드를 실행
            }
        }
    }

    private bool IsPrime(int candidate)     // 소수인지 판별하는 메소드
    {
        if((candidate & 1) == 0)     // 들어온 값이 짝수중에서
            return candidate == 2;  // 2가 맞다면 소수이므로 true를 반환, 아니라면 소수가 아니므로 false

        for (int i = 3; (i * i) <= candidate; i += 2)   // 여기서는 홀수
            if ((candidate % i) == 0) return false;     // 홀수로 나누어 떨어지면 소수가 아니므로 false 반환

        return candidate != 1;  // 1은 소수가 아니므로 소수이려면 1이 아니면 된다.
    }
}

namespace CPPPP
{
    class Delegate_Prime_Generator
    {
        // 콜백으로 등록될 메소드 1
        static void PrintPrime(object sender, CallbackArg arg)  // 소수값을 전부 출력하는 메소드
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        // 콜백으로 등록될 메소드 2
        static void SumPrime(object sender, CallbackArg arg)    // 소수값을 전부 더하는 메소드
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }

        public static void Main()
        {
            PrimeGenerator gen = new PrimeGenerator();  // 소수생성기 인스턴스 생성

            // PrintPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callprint = PrintPrime;    // 소수출력 메소드를 델리게이트로 생성
            gen.AddDelegate(callprint); // 델리게이트로 만든 소수출력 메소드를 소수생성기의 델리게이트와 연결

            // SumPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callsum = SumPrime;        // 소수합 메소드를 델리게이트로 생성
            gen.AddDelegate(callsum);   // 델리게이트로 만든 소수합 메소드를 소수생성기의 델리게이트와 연결

            // 1 ~ 10까지 소수를 구하고,
            gen.Run(10);        // 델리게이트와 연결된 모든 메소드를 동시에 실행
            Console.WriteLine();
            Console.WriteLine(Sum);

            // SumPrime 콜백 메서드를 제거한 후 다시 1 ~ 15까지 소수를 구하는 메서드 호출
            gen.RemoveDelegate(callsum);        // 델리게이트 구독 해지
            gen.Run(15);
        }
    }
}