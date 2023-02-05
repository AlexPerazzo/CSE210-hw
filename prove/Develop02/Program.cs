using System;
using Develop02.Classes;
class Program
{

// For the above and beyond I added a start up menu that allows you to load files before you go into the actual program. I feel like this helps with the flow of the program a lot. I also added text to various places to make sure the user knows if they are overwriting files and such.



    static void Main(string[] args)
    {
        Menu menu = new Menu();
        List<string> list = menu.startUp();
        menu.menu(list);
    }
}