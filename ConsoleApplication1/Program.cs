using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm ConsoleApplication1 say: hello!");


            ClassDemo classDemo = new ClassDemo();
            classDemo.ClassDemoSay();

            Console.ReadLine();
        }
    }
}
