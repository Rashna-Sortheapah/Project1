using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Introduction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi I'm Rashna Sortheapah, a student at University of Mauritius doing BSc(Hons) Applied Computing.");
            Console.ReadLine();

            MainMenu mymenu = new MainMenu();
            mymenu.Menuoption();
        }
    }
}
