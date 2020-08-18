using System;
using System.Reflection;

namespace AssemblyDemo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            Assembly assembly = Assembly.LoadFrom(path);
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(" Type: {0}", type.Name);
                MemberInfo[] members = type.GetMembers(flags);

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine(" {0}: {1}", member.MemberType, member.Name);
                }
            }
        }
    }
}