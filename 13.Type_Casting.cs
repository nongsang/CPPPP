using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Computer
    {
        protected bool powerOn = false;
        public void Boot() { Console.WriteLine("Boot()"); }
        public void Shutdown() { Console.WriteLine("Shutdown()"); }
        public void Reset() { Console.WriteLine("Resets()"); }
    }

    class Notebook : Computer
    {
        bool fingerScan = false;
        public bool HasFingerScanDevice() { return fingerScan; }

        public void CloseLid()
        {
            if(true == powerOn)
                Shutdown();
        }
    }

    class Netbook : Computer { }

    class DeviceManager
    {
        public void TurnOff(Computer device)    // 부모 클래스를 매개변수로 사용한다.
        {
            device.Shutdown();
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Netbook netbook = new Netbook();

            DeviceManager manager = new DeviceManager();
            manager.TurnOff(notebook);      // 부모클래스 매개변수에 자식클래스를 인자로?
            manager.TurnOff(netbook);       // 이거 참조형식 아니냐?

            Computer[] machines = new Computer[] { new Notebook(), new Netbook() };

            foreach (Computer device in machines)
                manager.TurnOff(device);
        }
    }
}

// 33행
// 부모클래스를 매개변수로 사용한다.
// 나중에 어떻게 사용될까?

// 47, 48행
// 부모객체로 자식객체를 생성한다.
// CPP_Abstraction/39.overriding2.cpp에 나온 참조형식과 같은 내용이다.
// 크게보면 형변환(Type Casting)의 확장으로 생각할 수 있다.

// 50행
// 배열을 초기화하는 방법
// 클래스도 같은 방식으로 배열 초기화가 가능하다.
// 다만 Computer형 배열 변수에 Notebook형, Netbook형으로 저장 가능한 이유는
// 앞서 설명한 참조형식과 형변환에 의해서 활용이 가능해진다.

// 52, 53행
// Computer형 배열 변수을 참조하여 순회하며 모든 객체의 메소드를 호출한다.