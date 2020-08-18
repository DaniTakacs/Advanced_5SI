using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll";

            // Load a specific Assembly
            Assembly assembly = Assembly.LoadFile(path);
            ShowAssemblyInfo(assembly);

            // Get our Assembly
            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssemblyInfo(ourAssembly);
        }
        
        static void ShowAssemblyInfo(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName);
            Console.WriteLine("From GAC? {0} ", assembly.GlobalAssemblyCache);
            Console.WriteLine("Path: {0}", assembly.Location);
            Console.WriteLine("Version: {0}", assembly.ImageRuntimeVersion);

            foreach (var module in assembly.Modules)
            {
                Console.WriteLine("Module: {0}", module);
            }

            Console.WriteLine();
        }
    }
}