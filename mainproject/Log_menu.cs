using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainproject
{
    /// <summary>
    /// Tutaj program pokazuje menu po wybraniu pierwszej i daje mozliwosc wyboru rejestracji oraz zalogowania jako admin lub zwyklu użytkownik
    /// </summary>
    class Log_menu
    {
        public void LogMenu()
        {
            User_Menu usermenu = new User_Menu();
            Admin_Menu adminmenu = new Admin_Menu();
            Register reg = new Register();
            Console.WriteLine("1.Login as User");
            Console.WriteLine("2.Login as Admin");
            Console.WriteLine("3.Sign up");
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.WriteLine("------------------------------");
                usermenu.UserMenu();
            }
            else if (choice2 == "2")
            {
                Console.WriteLine("------------------------------");
                adminmenu.AdminMenu();
            }
            else if (choice2 == "3")
            {
                Console.WriteLine("------------------------------");
                reg.Reg();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadLine();
        }
    }
}
