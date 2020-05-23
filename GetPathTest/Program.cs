using System;
using System.Diagnostics;
using System.IO;

namespace GetPathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists(@".\Results.txt"))
            {
                File.Delete(@".\Results.txt");
            }
            WriteResult("\nEnvironment.GetCommandLineArgs()[0]", Environment.GetCommandLineArgs()[0]);
            WriteResult("\nSystem.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0])", System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]));
            WriteResult("\nDirectory.GetCurrentDirectory()", Directory.GetCurrentDirectory());
            WriteResult("\nEnvironment.CurrentDirectory", Environment.CurrentDirectory);
            WriteResult("\nSystem.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            WriteResult("\nAppDomain.CurrentDomain.BaseDirectory", AppDomain.CurrentDomain.BaseDirectory);
            WriteResult("\nSystem.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));
            WriteResult("\nSystem.AppContext.BaseDirectory", System.AppContext.BaseDirectory);
            WriteResult("\nAppDomain.CurrentDomain.BaseDirectory", AppDomain.CurrentDomain.BaseDirectory);
            WriteResult("\nSystem.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)", System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
        }

        static void WriteResult(string type, string result)
        {
            using (StreamWriter file = new StreamWriter(@".\Results.txt", true))
            {
                file.WriteLine($"{type} result: {result}");
            }
        }
    }
}
