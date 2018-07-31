using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Platter { }   // 하드디스크의 플래터를 정의
class Head { }      // 하드디스크의 헤드를 정의

public class HardDisk1
{
    Platter[] platters;     // 여러 플래터가 있음을 나타낸다.
    Head head;              // 헤드도 있다.
}

public class HardDisk2
{
    class Platter { }       // 차라리 클래스 안에 클래스를 정의하면?
    class Head { }          // 자동으로 private선언되어서 더 낫지 않을까?

    Platter[] platters;     // 여러 플래터가 있음을 나타낸다.
    Head head;              // 헤드도 있다.
}


namespace CPPPP
{
    class Nested_Class
    {
        static void Main(string[] args)
        {
            //HardDisk1.Head head = new HardDisk1.Head();   // HardDisk 안에 Head가 private이므로 호출불가
            //HardDisk2.Head head = new HardDisk2.Head();   // 이것도 마찬가지
        }
    }
}

// 7 ~ 14행
// 만약에 하드디스크를 정의한다고 가정해보자.
// 하드디스크는 플래터와 헤드가 존재하며, 여러개의 플래터에 헤드가 데이터를 기록하는 방식을 사용한다.
// 플래터와 헤드는 각각의 기능을 가지고 있으면서 하드디스크라는 클래스에 종속된다.
// 나름 괜찮게 표현했을 수 있으나 Head와 Platter를 외부에 정의했으므로 헤드와 플래터를 다른 곳에서 수정할 수 있다.
// 다른 방법이 없나?

// 16 ~ 23행
// 헤드와 플래터가 클래스 내부에서 정의되었으므로 하드디스크에 종속됨을 표현할 수 있다.
// class 내부에 class는 접근 제한자를 선언하지 않으면 private으로 선언이 된다.
// 다른 멤버는 internal로 선언된다.

// 32 ~ 33행
// class 내부에 class를 정의했기 때문에 private이므로 접근이 불가능하다.
// 사용하고 싶으면 public으로 선언하면 된다.