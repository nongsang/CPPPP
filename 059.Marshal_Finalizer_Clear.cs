using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;               // Process 기능을 사용하기 위해서 추가
using System.Runtime.InteropServices;   // Marshal 기능을 사용하기 위해서 추가

class UnmanagedMemoryManager : IDisposable
{
    IntPtr pBuffer; // int형 포인터라고 생각하자
    bool disposed;  // 생성된 객체가 Dispose가 불려서, 메모리 해제가 끝났는지 확인

    public UnmanagedMemoryManager() // 생성자
    {
        // Marshal은 관리되지 않는 컬렉션, 변환, 할당 등등에 대한 기능을 제공한다.
        pBuffer = Marshal.AllocCoTaskMem(4096 * 1024);  // 의도적으로 4MB 할당
    }

    public void Dispose()
    {
        if (disposed == false)              // 메모리 처리가 되지 않았으면
        {
            Marshal.FreeCoTaskMem(pBuffer); // pBuffer가 가리키는 가비지 컬렉터가 관리하지 않는 메모리를 해제하고
            disposed = true;                // 메모리가 해제됐음을 알린다.
        }
    }

    ~UnmanagedMemoryManager()       // 소멸자
    {
        Dispose();                  // 하는 일은 Dispose를 호출하는 것
    }
}

namespace CPPPP
{
    class Marshal_Finalizer_Clear
    {
        static void Main(string[] args)
        {
            while(true)     // 무한으로
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();    // GC에 관리되지 않는 메모리를 생성한다.

                m = null;       // m을 null로 해서 생성된 메모리에 접근할 수 없게 한다.
                GC.Collect();   // 객체의 소멸자를 정의해주었으므로 가비지컬렉션을 할 때 소멸자가 호출되어서 Dispose가 호출된다.
                                // 따라서 비관리 메모리도 해제된다.

                // Process는 자원에 대한 측정기능을 제공한다.
                // 현재 사용하는 자원 중에
                // 메모리 사이즈를 측정한다.
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64); // OutOfMemoryException은 발생하지 않지만
                                                                                    // 성능문제가 있다.
            }
        }
    }
}