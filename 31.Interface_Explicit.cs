using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IObjectToSTring { }   // ToString()을 오버라이딩할 클래스에 상속시킨다.

class Computer { }  // ToString()을 오버라이딩하지 않으므로 인터페이스를 상속하지 않는다.

class Notebook : IObjectToSTring        // ToString을 오버라이딩했다는 의미로 인터페이스를 상속
{
    public override string ToString()   // 오버라이딩
    {
        return "Notebook : " + nameof(Notebook);
    }
}

namespace CPPPP
{
    class Interface_Explicit
    {
        static void Display(object obj)
        {
            if (obj is IObjectToSTring)     // 인터페이스를 상속받았는지 확인
                Console.WriteLine(obj.ToString());
        }

        public static void Main()
        {
            Display(new Computer());    // 인터페이스를 상속받지 않았으므로 아무것도 안한다.
            Display(new Notebook());    // 인터페이스를 상속받았으므로 정의된 메소드를 실행한다.
        }
    }
}

// 7행
// ToString()을 오버라이딩한다는 의미로 아무것도 정의한한 인터페이스를 선언했다.
// 이름에서부터 ToString이 있다.
// 앞으로 이름을 보고 구별하면 된다.

// 9행
// 인터페이스를 상속받지 않은 일반 클래스다.

// 11 ~ 17행
// ToString()을 오버로딩한다는 의미로 인터페이스를 상속받았다.

// 23 ~ 27행
// 오브젝트형으로 받아서 인터페이스를 상속받았는지 확인하는 메소드를 정의해주었다.

// 31행
// Computer는 인터페이스를 상속받지 않았으므로 실행이 되지 않는다.

// 32행
// Notebook은 인터페이스를 상속받았으므로 실행이 된다.