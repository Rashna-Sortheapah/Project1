using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
        class MainMenu
        {
        public string option { get; set; }

        public void InputOption(string option)
        {
            this.option = option;
        }

            public void Menuoption()
            {
                Console.Clear();
                Console.WriteLine("-----Main Menu-----");
                Console.WriteLine("1) Experience");
                Console.WriteLine("2) Education");
                Console.WriteLine("3) Skills");
                Console.WriteLine("4) Technological Skills");
                Console.WriteLine("5) Contact Details");
                Console.Write("\r\nSelect an option: ");
                this.option = Console.ReadLine();

            switch (this.option)
                {
                    case "1":

                        Console.WriteLine("1. Ceridian Mauritius");
                        Console.WriteLine("2. Accenture Mauritius");
                        Console.Write("\r\nSelect the company option to view more details: ");
                        SubMenu submenu1 = new SubMenu();
                        submenu1.Experience();
                        break;

                    case "2":

                        Console.WriteLine("1. Applied Computing(Year 1)");
                        Console.WriteLine("2. Applied Computing(Year 2)");
                        Console.Write("\r\nSelect the year to view more details: ");
                        SubMenu submenu2 = new SubMenu();
                        submenu2.Education();
                        break;

                    case "3":

                        Console.WriteLine("Personal Skills");
                        Console.WriteLine("1. Communication skills");
                        Console.WriteLine("2. Time Management skills");
                        Console.WriteLine("3. Punctual");
                        Console.WriteLine("4. Teambuilding");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu3 = new MainMenu();
                        mymenu3.Menuoption();
                        break;

                    case "4":

                        Console.WriteLine("Technological Skills");
                        Console.WriteLine("I have acquired skills in Java, HTML, CSS and SQL. I have used software like eclipse, postgresql and Devserver.");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu4 = new MainMenu();
                        mymenu4.Menuoption();
                        break;

                    case "5":

                        Console.WriteLine("Contact Details");
                        Console.WriteLine("Email Address: Rashna.Sortheapah@ceridian.com");
                        Console.WriteLine("Phone Number: 99999999");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu5 = new MainMenu();
                        mymenu5.Menuoption();
                        break;

                    default:
                        MainMenu mymenu1 = new MainMenu();
                        mymenu1.Menuoption();
                        return;

                }
            }
        }
}
