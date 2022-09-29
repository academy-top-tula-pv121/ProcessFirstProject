using System.Diagnostics;

namespace ProcessFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = Process.GetCurrentProcess();

            Console.WriteLine(process.ProcessName);
            Console.WriteLine(process.MachineName);
            Console.WriteLine(process.Handle);
            Console.WriteLine(process.Id);

            Console.WriteLine(process.PagedMemorySize64);
            Console.WriteLine(process.VirtualMemorySize64);
            Console.WriteLine("\n---------------\n");
            Console.WriteLine(Thread.CurrentThread);
            Console.WriteLine("\n---------------\n");
            foreach (ProcessThread thread in process.Threads)
                Console.WriteLine(thread.Id);


            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "notepad.exe";
            startInfo.Arguments = "D:\\RPO\\Максим Ефимов\\rpo\\ПВ121\\file10.txt";

            Process.Start(startInfo);


            //var moduleMain = process.MainModule;
            //Console.WriteLine(moduleMain.ModuleName);
            //Console.WriteLine("\n---------------\n");
            //var modules = process.Modules;
            //foreach(ProcessModule module in modules)
            //    Console.WriteLine(module.ModuleName);
            //Console.WriteLine("\n---------------\n");
            //Console.WriteLine("\n---------------\n");

            //foreach(Process proc in Process.GetProcesses())
            //    Console.WriteLine(proc.ProcessName);

            Console.ReadKey();

        }
    }
}