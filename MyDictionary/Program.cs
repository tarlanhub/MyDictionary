using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customers = new MyDictionary<int, string>();

            customers.Add(1, "Amy");
            customers.Add(2, "2.Amy");
            customers.Add(3, "3.Amy");

            customers.Control(1);
            customers.Control(2);
            customers.Control(3);
        }
    }
}
