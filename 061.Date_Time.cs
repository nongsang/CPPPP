using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPPPP
{
    class Date_Time
    {
        public static void Main()
        {
            DateTime now = DateTime.Now;    // 현재 지역의 현재 시간을 측정한다.
            Console.WriteLine(now);

            DateTime ChildrenDay = new DateTime(DateTime.Now.Year, 5, 5);   // 시간을 측정하는 시간의 년도와, 월, 일을 정해서 저장할 수 있다.
            Console.WriteLine(ChildrenDay);

            DateTime today = DateTime.Now;  // 값형식이기 때문에 new로 안넣어도 된다.
            Console.WriteLine(today + " : " + today.Kind);  // Local이므로 지역 시간대를 반영
                                                            // kind로 시간의 형식 알 수 있다.

            DateTime utcToday = DateTime.UtcNow;    // 협정 세계시를 기준으로 시간을 측정
            Console.WriteLine(utcToday + " : " + utcToday.Kind);    // Utc이므로 협정 세계시로 시간을 반영

            DateTime worldCup2002 = new DateTime(2002, 5, 31);      // 일일히 값을 넣으려면 new로 해야한다.
            Console.WriteLine(worldCup2002 + " : " + worldCup2002.Kind);    // 그냥 날자를 쓴것이므로 시간 형식이 정해지지 않았다.

            worldCup2002 = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Local);  // 시간 형식을 Local로 정의를 한다.
            Console.WriteLine(worldCup2002 + " : " + worldCup2002.Kind);
        }
    }
}