using System;
using System.Reflection;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        AssemblyName theName = new AssemblyName();
        theName.Name = "DemoAssembly";
        theName.Version = new Version("1.0.0.0");

        AppDomain domain = AppDomain.CurrentDomain;

        AssemblyBuilder assemBldr = AppDomain.
    }
}