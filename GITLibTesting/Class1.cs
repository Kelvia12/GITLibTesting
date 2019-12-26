using System;

namespace GITLibTesting
{
    public class Class1
    {
        Printer p = new Printer();

        // private String testmessage = "This is a test print";
        private readonly String testmessage = p.PrintTest("This is a test print");
        public void print()
        {


            Console.WriteLine(testmessage);

        }
    }
}
