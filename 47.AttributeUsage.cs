using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]  // Author 특성의 적용 대상을 클래스와 메소드로 제한한다.
class AuthorAttribute : System.Attribute
{
    private string name;

    public AuthorAttribute() { }

    public AuthorAttribute(string name)
    {
        this.name = name;
    }
}

namespace CPPPP
{
    [type: Author("바보")]    // AttributeUsage로 특성 적용 대상을 제한했기 때문에 앞에 type을 써준다.
    class AttributeUsage
    {
        [method: Author("바보")]  // 이것도 마찬가지 메소드로 AttributeUsage를 메소드로 제한할 때 method를 써준다.
        public static void Main()
        {
            
        }
    }
}