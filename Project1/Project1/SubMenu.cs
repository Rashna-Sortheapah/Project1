using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

        class SubMenu : MainMenu
        {
            public void Experience()
            {
                int company = int.Parse(Console.ReadLine());

                bool goback = false;

                switch (company)
                {
                    case 1:
                        Console.WriteLine("Ceridian HCM is an American provider of human resources software and services with employees in the USA, Canada, Europe, Australia and Mauritius.");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu1 = new MainMenu();
                        mymenu1.Menuoption();
                        break;

                    case 2:
                        Console.WriteLine("Accenture plc is an Irish-American professional services company based in Dublin, specializing in information technology services and consulting.");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu2 = new MainMenu();
                        mymenu2.Menuoption();
                    break;

                    default:
                        goback = true;
                        MainMenu mymenu3 = new MainMenu();
                        mymenu3.Menuoption();
                        return;

                }
            }

            public void Education()
            {
                int year = int.Parse(Console.ReadLine());

                bool goback = false;

                switch (year)
                {
                    case 1:
                        Console.WriteLine("Mathematics for computing");
                        Console.WriteLine("Web design and development");
                        Console.WriteLine("Communication Skills");
                        Console.WriteLine("Programming and data structures");
                        Console.WriteLine("Database system and administration");
                        Console.WriteLine("Business computing");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu1 = new MainMenu();
                        mymenu1.Menuoption();
                    break;

                    case 2:
                        Console.WriteLine("Principle of software development");
                        Console.WriteLine("Internet technologies and web services");
                        Console.WriteLine("Networking principles");
                        Console.WriteLine("Enterprise System");
                        Console.WriteLine("Software Modelling and design");
                        Console.WriteLine("Multimedia authoring and development");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to return to main menu");
                        Console.ReadLine();
                        MainMenu mymenu2 = new MainMenu();
                        mymenu2.Menuoption();
                        break;

                    default:
                        goback = true;
                        MainMenu mymenu3 = new MainMenu();
                        mymenu3.Menuoption();
                        return;

                }
            }
        }
}
