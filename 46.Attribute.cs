using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AuthorAttribute : System.Attribute    // 어트리뷰트는 System.Attribute를 상속받는다.
{                                           // 어트리뷰로 사용할 클래스는 이름 뒤에 Attribute를 붙여서 관습적으로 이름을 짓는다.
    private string name;

    public AuthorAttribute() { }        // 디폴트 생성자

    public AuthorAttribute(string name)
    {
        this.name = name;
    }
}

namespace CPPPP
{
    //[AuthorAttribute("바보")]   // 어트리뷰트를 이용하여 값을 전달할 수 있다. 보통, 어떤 값을 가지고 있는지 알려주는 용도로 사용한다.
    [Author("바보")]          // C#에서는 Attribute라는 단어를 빼도 동작한다.
    //[Author]              // 디폴트 생성자가 있으면 사용가능
    //[Author()]            // [Author]랑 똑같다
    class Attribute
    {
        public static void Main()
        {
            // 주석은 소스코드에만 남아있기 때문에 빌드 후 생성되는 EXE/DLL파일에는 남지 않는다.
            // 이를 해결한게 Attribute다.
            // 어트리뷰트는 지금 당장 사용해도 동작 방식에 관여할 수 없다.
            // 나중에 Reflection을 배울 때 확장하여 사용할 수 있다.
        }
    }
}