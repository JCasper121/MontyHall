// See https://aka.ms/new-console-template for more information
using MontyHall;

namespace MontyHall
{
    public static class Program
    {
        public static int reps = 2000;

        public static void Main(string[] args)
        {

            SwitchDoors.Play();
            StayDoors.Play();

            Console.WriteLine("Repetitions: {0}", reps);
            Console.WriteLine("Switch doors\tWins: {0}\tLosses: {1}", SwitchDoors.Wins, SwitchDoors.Losses);
            Console.WriteLine("Stay doors\tWins: {0}\t Losses: {1}", StayDoors.Wins, StayDoors.Losses);



           
        }
    }
}

