using System;
using Develop02.Classes;
class Program
{





    static void Main(string[] args)
    {
        Menu menu = new Menu();
        List<string> list = menu.startUp();
        menu.menu(list);
    }
}