using System;

namespace GradingSwitch
{
    namespace SwitchGrading
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Sisesta oma hinne");
                int UserGrade = Convert.ToInt32(Console.ReadLine());

                switch (UserGrade)
                {
                    case 5:
                        Console.WriteLine("suurepärane!");
                        break;
                    case 4:
                        Console.WriteLine("väga hea!");
                        break;
                    case 3:
                        Console.WriteLine("hea!");
                        break;
                    case 2:
                        Console.WriteLine("rahuldav");
                        break;
                    case 1:
                        Console.WriteLine("puudulik");
                        break;
                    default:
                        Console.WriteLine("kordad kursust");
                        break;




                }








            }
        }
    }
}


