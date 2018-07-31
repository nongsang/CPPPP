using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;               // Process 기능을 사용하기 위해서 추가
using System.Runtime.InteropServices;   // Marshal 기능을 사용하기 위해서 추가

class UnmanagedMemoryManager
{
    IntPtr pBuffer; // int형 포인터라고 생각하자

    public UnmanagedMemoryManager() // 생성자
    {
        // Marshal은 관리되지 않는 컬렉션, 변환, 할당 등등에 대한 기능을 제공한다.
        pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);  // 의도적으로 GC가 관리하지 않는 4MB 할당
    }
}

namespace CPPPP
{
    class Marshal_Out_Of_Memory_Exception
    {
        static void Main(string[] args)
        {
            while(true)     // 무한으로
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();    // GC에 관리되지 않는 메모리를 생성한다.

                m = null;       // m을 null로 해서 생성된 메모리에 접근할 수 없게 한다.
                GC.Collect();   // 가비지 컬렉션을 강제로 수행

                // Process는 자원에 대한 측정기능을 제공한다.
                // 현재 사용하는 자원 중에
                // 메모리 사이즈를 측정한다.
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }   // 무한으로 돌리고, GC가 메모리를 관리해주지도 않으므로 OutOfMemoryException이 발생한다.
        }
    }
}