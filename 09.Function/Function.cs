using System;
class Program
{
    static void MyFunction(int a, int b=1, int c=3)
    {
        Console.WriteLine("the number is: " + a);
    }   
    static void Main(string[] args)
    {
        MyFunction(a:3);
    }
}