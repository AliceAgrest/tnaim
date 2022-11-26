using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // answer 3
        
        int num;
        Console.WriteLine("Enter a numner ");
        num = int.Parse(Console.ReadLine());

        if ((num < 10) && (num > (-10)))
            Console.WriteLine("The number you enter is one digt");
        else
            Console.WriteLine("The number you enter isn't one digt");
        
        // answer 4
        char tav ,a ,z ;
        Console.WriteLine("Enter a charecter ");
        tav = char.Parse(Console.ReadLine());

            tav = (char)(int)tav;
            a = (char)(int)'a';
            z = (char)(int)'z';

        if ((tav >= a) && (tav <= z))
            Console.WriteLine("Your charecter is in the alphbet");
        else
            Console.WriteLine("Your charecter isn't exsit in the alphabet");
        
            Console.ReadLine();
        }
    }
}
