using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostStar.Common.Util
{
    /// <summary>
    /// 시스템 정보
    /// </summary>
    public class SystemInfo
    {
        static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        /// <summary>
        /// CPU 사용량을 구한다.
        /// </summary>
        /// <returns></returns>
        public static int GetCpuUseRate()
        {
            return (int)cpuCounter.NextValue();
        }

        /// <summary>
        /// Disk 사용률을 구한다.
        /// </summary>
        /// <returns></returns>
        public static int GetDiskUseRate(String driveName)
        {
            int useRate = 0;

            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady == false)
                        continue;

                    if (drive.Name.ToUpper().Equals(driveName) == false)
                        continue;

                    useRate = Convert.ToInt32((drive.TotalSize - drive.TotalFreeSpace) * 100 / drive.TotalSize);
                    break;
                }
            }
            catch
            {
                useRate = 0;
            }

            return useRate;
        }

        /// <summary>
        /// 실행중인 프로세스 목록을 구한다.
        /// </summary>
        /// <returns></returns>
        public static Process[] GetProcessList()
        {
            return Process.GetProcesses();
        }
    }

}
