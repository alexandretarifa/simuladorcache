using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {

            Process p = new Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = @"C:\Dev\tdc\playground\PlaygroundSemCache\bin\Debug\PlaygroundSemCache.exe";
            

            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = true;
            p2.StartInfo.FileName = @"C:\Dev\tdc\playground\PlaygroundComCache\bin\Debug\PlaygroundComCache.exe";

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = true;
            p3.StartInfo.FileName = @"C:\Dev\tdc\playground\PlaygroundComCacheRedis\bin\Debug\PlaygroundComCacheRedis.exe";

            p.Start();
            p2.Start();
            p3.Start();
        }
    }
}
