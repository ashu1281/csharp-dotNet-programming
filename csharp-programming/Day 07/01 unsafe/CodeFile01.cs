using System.Runtime.InteropServices;

namespace csharp_programming {
    class Program
    {
        [DllImport("utilities.dll")]
        public static extern IntPtr GetSampleData(UInt32 size);

        [DllImport("utilities.dll")]
        public static extern void FreeSampleData(IntPtr pdata);
        public unsafe static void UseSampleData() {
            UInt32 size = 4;
            IntPtr dataPtr = GetSampleData(size);

            int* pdata = (int*)dataPtr.ToPointer();
            for(UInt32 i=0; i<size; i++)
            {
                Console.WriteLine(pdata[i]);
            }

            FreeSampleData(dataPtr);

        }
        public static void Main()
        {
            UseSampleData();
        } 
    }
}
/*
 * It's important to note that unsafe code in C# should be used
 * with caution and only by experienced programmers.
 * The use of unsafe code can introduce security vulnerabilities,
 * memory leaks, and other potential issues that can lead to 
 * application crashes or other unexpected behavior.
 */