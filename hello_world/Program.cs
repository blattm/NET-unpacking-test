// See https://aka.ms/new-console-template for more information
using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        foreach (string item in args)
        {
            Console.WriteLine(item);
        }
        // Console.ReadLine();
    }
}
