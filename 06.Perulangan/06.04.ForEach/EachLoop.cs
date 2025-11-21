using System;

namespace Jessen;

class Program
{
    static void Main(string[] args)
    {
        int[] cars = { 10, 4, 3, 23 };
        foreach (int car in cars)
        {
            Console.Write(car);
        }

        string[] names = { "Jessen", "Kinan", "Koko" };
        names[1] = "2";
        foreach (string name in names){
            Console.Write(name);
        }
    }
}
