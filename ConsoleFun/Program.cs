using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            foreach (string s in Directory.EnumerateFiles("../../images/"))
            {
                Console.WriteLine(s);
                Process p = new Process();
                
                    
                //p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                p.StartInfo.Arguments = "notepad";
                p.Start();
            }
            Console.ReadLine(); // Just to keep the console from disappearing.
        }
    }
}
