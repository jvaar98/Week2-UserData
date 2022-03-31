using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18 siis programm kuvab konsoolis
            //"oled liiga noor, et juhiluba saada";
            //kui kasutaja on vanem, kui 18 siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhiluba saada"
            //kui kasutaja on 18 siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taodelda."
            Console.WriteLine("Palun, ütle oma sünniaasta?.");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearOfBirth;
            if(userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");

            }
            else if(userAge >18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taodelda.");

            }
        }
    }
}
