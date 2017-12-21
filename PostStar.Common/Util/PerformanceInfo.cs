using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PostStar.Common.Util
{
    [DllImport("psapi.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetPerformanceInfo([Out] out PerformanceInformation PerformanceInformation, [In] int Size);

    [StructLayout(LayoutKind.Sequential)]
    public struct PerformanceInformation
    {
        public int Size;
        public IntPtr CommitTotal;
        public IntPtr CommitLimit;
        public IntPtr CommitPeak;
        public IntPtr PhysicalTotal;
        public IntPtr PhysicalAvailable;
        public IntPtr SystemCache;
        public IntPtr KernelTotal;
        public IntPtr KernelPaged;
        public IntPtr KernelNonPaged;
        public IntPtr PageSize;
        public int HandlesCount;
        public int ProcessCount;
        public int ThreadCount;
    }

    /// <summary>
    /// 메모리 사용률을 구한다.
    /// </summary>
    /// <returns></returns>
    public static Int64 GetMemoryUseRate()
    {
        PerformanceInformation pi = new PerformanceInformation();
        if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)) == false)
            return 0;

        //// 현재 사용가능 메모리양
        Int64 available = pi.PhysicalAvailable.ToInt64();

        //// 전체메모리양
        Int64 total = pi.PhysicalTotal.ToInt64();

        //// 현재 사용률
        return (total - available) * 100 / total;
    }
}

}
