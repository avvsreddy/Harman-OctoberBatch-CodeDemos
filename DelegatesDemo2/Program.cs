using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1
            ProcessManager pMgr = new ProcessManager();
            pMgr.ShowProcessList(p => true);

            // client 2
            //FilterDelegate filter = new FilterDelegate(FilterByName);
            //pMgr.ShowProcessList(filter);

            // client 3
            //pMgr.ShowProcessList(FilterBySize); //100MB


            // Anonymous Delegates
            // Anonymous Methods

            pMgr.ShowProcessList(delegate (Process p)
            {
                return p.WorkingSet64 >= 100 * 1204 * 1024;
            }); //100MB


            // Lambda expression =  light weight syntax for anonymous delegeate
            pMgr.ShowProcessList((Process p) =>
            {
                return p.WorkingSet64 >= 100 * 1204 * 1024;
            }); //100MB

            // Lambda statements
            // Lambda expressions

            pMgr.ShowProcessList((Process p) =>

                p.WorkingSet64 >= 100 * 1204 * 1024
            ); //100MB

            pMgr.ShowProcessList(p => p.WorkingSet64 >= 100 * 1204 * 1024); //100MB


        }

        // client 2
        //public static bool FilterByName(Process p)
        //{
        //    return p.ProcessName.StartsWith("S");
        //}

        // client 3
        public static bool FilterBySize(Process p)
        {
            return p.WorkingSet64 >= 100 * 1204 * 1024;
        }

    }


    public delegate bool FilterDelegate(Process p);


    // backend dev
    public class ProcessManager // OCP
    {
        //public void ShowProcessList()
        //{
        //    foreach (var p in Process.GetProcesses())
        //    {
        //        Console.WriteLine(p.ProcessName);
        //    }
        //}

        //public void ShowProcessList(string sw)
        //{
        //    foreach (var p in Process.GetProcesses())
        //    {
        //        if (p.ProcessName.StartsWith(sw))
        //            Console.WriteLine(p.ProcessName);
        //    }
        //}

        public void ShowProcessList(FilterDelegate filter)
        {
            foreach (var p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}
