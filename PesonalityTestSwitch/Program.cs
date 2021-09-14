using System;

namespace PesonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajat sisetada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisetab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisetab midagi muud, konsool kuvab "oled üksisarvik";

            Console.WriteLine("Mis on su lemmik värv");
            string Usercolor = Console.ReadLine().ToLower();
            switch (Usercolor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {Usercolor} ükssarvik.");
                    break;


            }
        }
    }
}   