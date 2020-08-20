using MenuBuilder;
using Shayetet6.Menu;
using System;

namespace Shayetet6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#################################");
            Console.WriteLine("THIS IS A BUG IN MY MenuBuilder!");
            Console.WriteLine("#################################");
            CreateMenu menu = new CreateMenu();
            menu.MenuHandle.RunMenu.Run();
        }
    }
}
