using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Computer
    {
        protected bool powerOn = true;     // protected로 선언됬다.
        public void Boot() { Console.WriteLine("부팅"); }
        public void Shutdown() { Console.WriteLine("종료"); }
        public void Reset() { Console.WriteLine("리셋"); }
    }

    sealed class Monitor        // 의도적으로 상속하는 것을 막는 방법
    {
        protected bool powerOn = true;
        public void Display() { Console.WriteLine("출력"); }
    }

    class Notebook : Computer// , Monitor  // Computor 클래스 상속, 다중 상속 불가 
    {
        bool fingerScan = false;
        public bool HasFingerScanDevice() { return fingerScan; }

        public void CloseLid()
        {
            if (true == powerOn)     // protected로 선언된 powerOn 변수에 접근
                Shutdown();     // Notebook에서 추가된 메서드 내에서 Computer의 메서드 호출
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Boot();    // Notebook 인스턴스에서 부모의 메서드를 호출
            notebook.CloseLid();
        }
    }
}

// 11행
// 필드를 protected로 선언하였다.
// Computer 클래스 내에서 값의 변경이 가능하고, 상속받은 클래스에서 접근이 가능하다.
// 반대로 말하자면 Computer 클래스도 아니고, 상속은 클래스도 아니라면 접근이 불가능하다.
// C++에서도 정의가 되어있다.
// 하지만 보안은 위한다면 private나 public만 쓰자.

// 17 ~ 21행
// 모니터를 나타내는 클래스다.
// C++에서 가능했던 다중상속이 C#에서도 가능한지 실험해보기 위해 정의해주었다.
// sealed을 앞에 선언했을 경우 의도적으로 상속을 막는 역할을 한다.

// 23행
// C#에서 상속하는 방법이다.
// C++에서는 상속할 클래스와 상속 권한을 동시에 전달한다.
// Notebook : protected Computer처럼
// C#에서는 상속할 클래스만 전달하면 필드와 메소드의 권한을 자동으로 계산한다.
// 또한 C++에서 가능했던 다중 상속은 불가능하다.
// 다중 상속은 순수가상클래스의 상속이 아니면 가독성이 현저히 떨어지는 방식이므로 C#에서는 삭제하였다.

// 30행
// protected로 선언된 powerOn를 상속받은 Notebook이 사용할 수 있다.
// 상속받지 않은 Inheritance 클래스에서는 powerOn 필드에 접근할 수 없다.

// 31, 40행
// public으로 선언된 메소드에는 어디서든 그냥 호출할 수 있다.