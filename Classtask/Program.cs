using Classtask.metod;
using System;

namespace Classtask
{
    class Program
    {
        static void Main(string[] args)
        {
            User Lemusha = new User("Lemusha");
            Console.WriteLine("Lemusha");
            Console.WriteLine("Password");
            Lemusha.Password = Console.ReadLine();
            
        }
    }
}
