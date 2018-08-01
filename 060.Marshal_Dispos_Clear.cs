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

    public void Dispose(bool disposing)     // 매개변수를 집어넣어준다.
    {
        if (disposed == false)              // 메모리 처리가 되지 않았으면
        {
            Marshal.FreeCoTaskMem(pBuffer); // pBuffer가 가리키는 가비지 컬렉터가 관리하지 않는 메모리를 해제하고
            disposed = true;                // 메모리가 해제됐음을 알린다.
        }

        if (disposing == false)
        {
            // disposing이 false려면 Dispose()가 명시적으로 호출되는 경우다.
            // SuppressFinalize(this)는 종료 큐에서 자신을 가리키는 레퍼런스를 제거해 가비지 컬렉터의 부담을 줄인다.
            GC.SuppressFinalize(this);
        }
    }

    public void Dispose()       // Dispose를 오버로딩 해줬다.
    {
        Dispose(false);         // Dispose()를 호출하는 경우는 Dispose()를 명시적으로 호출하는 경우다.
    }

    ~UnmanagedMemoryManager()   // 종료자
    {
        Dispose(true);          // Dispose에 true를 전달
                                // Dispose는 true를 받으면 아무 작업도 안하고 탈출한다.
    }
}

namespace CPPPP
{
    class Marshal_Finalizer_Clear
    {
        static void Main(string[] args)
        {
            while (true)     // 무한으로
            {
                UnmanagedMemoryManager m = new UnmanagedMemoryManager();    // GC에 관리되지 않는 메모리를 생성한다.

                m = null;       // m을 null로 해서 생성된 메모리에 접근할 수 없게 한다.
                GC.Collect();   // 이미 종료 큐에 생성된 레퍼런스를 제거했으므로 가비지 컬렉션을 하면 별도의 작업없이 객체를 삭제할 수 있다.

                // Process는 자원에 대한 측정기능을 제공한다.
                // 현재 사용하는 자원 중에
                // 메모리 사이즈를 측정한다.
                Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
            }
        }
    }
}

// 기존의 소멸자를 호출하여 객체를 제거하는 방법은 OutOfMemoryException을 발생하지 않지만 성능에 문제가 있었다.
// 우선 소멸자가 어떻게 처리되는지를 알아야 한다.

// 1. 소멸자가 정의된 객체는 생성자가 불릴 때 관리 힙(Managed Heap)에 객체를 생성하고,
//    종료 큐(Finalizers Queue)에 레퍼런스를 만들어서 생성된 객체를 가리키게 한다.
//
// 2. 이후 관리 힙이 꽉 차서 가비지 컬렉션이 필요할 때,
//    소멸자가 없는 객체는 사용중이 아니라면 가비지로 인식하고 삭제한다.
//
// 3. 소멸자가 정의 된 객체를 가리키던, 종료 큐에 있던 레퍼런스는 F-Reachable 큐로 이동한다.
//
// 4. GC는 미리 스레드를 생성해 놓고 F-Reachable 큐에 있던 레퍼런스를 삭제한다.
//    이 스레드는 F-Reachable 큐에 레퍼런스가 들어올 때마다 삭제한다.
//    정확히는 Finalize() 메소드를 호출한다.
//
// 5. F-Reachable 큐에 있던 레퍼런스가 모두 삭제되면 다음 가비지 컬렉션에서 객체를 삭제한다.

// 이 모든 작업이 소멸자가 정의되어 있는 객체에 대한 삭제연산이다.
// 소멸자가 정의된 객체를 삭제하려면 가비지 컬렉션이 2번 발생해야 한다.
// 때문에 특별한 이유가 없다면 소멸자를 추가하지 않는 것이 좋다.

// 그렇다면 종료 큐에서 부터 레퍼런스를 제거하면 그냥 삭제를 할 수 있다는 뜻이 아닌가?
// GC.SuppressFinalize() 메소드는 이를 위해서 존재한다.
// 소멸자가 호출되도 Dispose에서는 아무 작업을 하지 않고, 오직 Dispose()가 명시적으로 호출이 될 때 객체를 삭제한다.
// 자주 사용되는 패턴이므로 나중에 비관리 자원을 해제해야 할 상황이 생긴다면 Marshal, FreeCoTaskMem 부분만 교체해서 사용하면 된다.