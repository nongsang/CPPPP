using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerText
{
    char[] txtNumber;   // string이 아니라 char배열이므로 값형식이다.

    public IntegerText(int num)
    {
        this.txtNumber = num.ToString().ToCharArray();  // int값을 문자열로 바꾸고, 다시 char형 배열로 변환하여 저장
    }

    public char this[int index]     // 인덱서, 클래스를 배열처럼 값에 접근하고 싶을 때 사용한다.
    {
        get
        {
            return txtNumber[txtNumber.Length - index - 1]; // 1의 자릿수는 몇인가 같은 연산을 하기 위해 맨 뒤에서부터 연산하도록 정의
        }
        set
        {
            txtNumber[txtNumber.Length - index - 1] = value;    // 이것도 마찬가지
        }
    }

    public override string ToString()
    {
        //return txtNumber.ToString();  // 이렇게 하면 안된다.
                                        // ToString()을 오버라이딩하는데, 오버라이딩하는 자기 자신을 부르기 때문에 오류가 발생
        return new string(txtNumber);   // txtNumber가 char배열형이므로 다시 string형으로 값을 반환해야 한다.
    }

    public int ToInt32()
    {
        return Int32.Parse(ToString()); // ToString()으로 문자열로 바뀐 txtNumber를 int형으로 변환하여 반환
    }
}

namespace CPPPP
{
    class Indexer
    {
        public static void Main()
        {
            IntegerText Int = new IntegerText(123456);  // 123456값을 가진 char배열을 생성

            int step = 1;
            for(int i = 0; i < Int.ToString().Length; ++i)      // Int가 가진 값은 char배열이므로 문자열로 변환하여 길이를 전달
            {
                Console.WriteLine(step + "의 자릿수 : " + Int[i]);
                step *= 10;
            }
        }
    }
}