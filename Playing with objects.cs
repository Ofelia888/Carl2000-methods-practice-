// robot lave lektier
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

namespace Metoder
{
    class Robot
    {
        public int battery = 100;
        public bool State = true;

        public void TurnOn()
        {
            State = true;
            Console.WriteLine("carl2000 is online");
        }
        public void TurnOff()
        {
            State = false;
            Console.WriteLine("carl2000 is offline");
        }

        public string Talk()
        {
            // skal starte en option based dialog

            Console.WriteLine("Carl: What would you like to talk about?\n");
            Console.WriteLine("A: Nice weather");
            Console.WriteLine("B: How are you?");
            Console.WriteLine("C: Bye");

            // at få options A, B og C til at give forskellige sætninger baseret på input
            string rspns = (Console.ReadLine());
            string bye = "Talk.exe shutting_down";
            string other = "Invalid input";
            battery -= 10;

            switch (rspns)
                {
                case "A":
                case "a":
                    Console.WriteLine("\nNice weather we're having today\n");
                    Console.WriteLine("Carl: I do not know, is it nice? I do not posses this feeling 'nice', as I am a robot\n");
                    return Talk();

                case "B":
                case "b":
                    Console.WriteLine("\nHow are you doing Carl?\n");
                    Console.WriteLine("Carl: I do not know, as I am a robot and do not possess feelings\n");
                    return Talk();

                    // why won't it return string 'bye' and 'other'????
                case "C":
                case "c":
                    Console.WriteLine("\nBye\n");
                    Console.WriteLine(bye + "\n");
                    Console.WriteLine(battery + "% battery left");
                    return bye;

                default:
                    Console.WriteLine(other);
                    return other;
                }
        }

    }
    class Program 
    {
        static void Main(string[] args)
        {
            Robot carl2000 = new Robot();

            carl2000.TurnOn();

            if (carl2000.State == true)
                Console.WriteLine("State = On");
            else if (carl2000.State == false)
                Console.WriteLine("State = Off");

            Console.WriteLine("Battery: " + carl2000.battery + "%");

            carl2000.Talk();

        }
    }
}
