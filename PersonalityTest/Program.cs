using System;

namespace PersonalityTest
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

            if (Usercolor == "punane")

            {
                Console.WriteLine("oled romantiline");
            }
            else if (Usercolor == "sinine")
            {
                Console.WriteLine("oled töökas");
            }
            else if (Usercolor == "roheline")
            {
                Console.WriteLine("oled looduse sõber");
            }
            else
            {
                Console.WriteLine("oled ükssarvik");
            }


        }
    }
}