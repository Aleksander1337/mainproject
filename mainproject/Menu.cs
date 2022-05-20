using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainproject
{
    /// <summary>
    /// Tutaj program pokazuje glowne menu i daje mozliwosc wyboru co sie chce zrobic
    /// </summary>
    class Menu
    {
        
        public void Main_menu()
        {
            Log_menu logmenu = new Log_menu();
            Console.Write("Witaj Uzytkowniku \n");
            Console.Write("-----------------------------\n");
            Console.Write("1. Log in|Sign up\n");
            Console.Write("2. Anonymous\n");
            Console.Write("TYPE THE NUMBER: ");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.WriteLine("------------------------------");
                logmenu.LogMenu();
            }
            else if(choice == "2")
            {
                Console.WriteLine("tu bedzie publiczna baza");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadLine();
            
        }
    }
}
