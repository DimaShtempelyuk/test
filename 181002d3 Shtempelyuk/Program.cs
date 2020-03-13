using System;

namespace _181002d3_Shtempelyuk
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.Write(" Zadej barvu: ");
            string UserInfoColor = Console.ReadLine();
            Console.WriteLine(" Zadana barva! " + UserInfoColor);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Zadej jmeno: ");
            string UserInfoName = Console.ReadLine();
            Console.WriteLine(" Zadane jmeno! " + UserInfoName );

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Zadej prijmeni: ");
            string UserInfoSecondName = Console.ReadLine();
            Console.WriteLine(" Zadane prijmeni! " + UserInfoSecondName);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($@" Zadané údaje
  Barva {UserInfoColor}
  Jmeno {UserInfoName}
  Prijmeni {UserInfoSecondName}");

            Console.ReadLine();


        }
    }
}
