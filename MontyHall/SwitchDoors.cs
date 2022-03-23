using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public static class SwitchDoors
    {
        public static int Wins = 0;
        public static int Losses = 0;


        public static void Play()
        {
            int reps = Program.reps;

            for (int i = 0; i < reps; ++i)
            {
                //int count = 0;
                List<bool> doors = new List<bool>();
                int pick;
                bool firstCorrect = false;
                Random rand = new Random();
                int random = rand.Next(1, 1000);

                for (int j = random - 3; j < random; ++j)
                {
                    if (j % 3 == 0)
                        doors.Add(true);
                    else
                        doors.Add(false);

                    //count++;
                }

                random = rand.Next(1, 1000);
                pick = random % 3;

                if (doors[pick] == true)
                    firstCorrect = true;


                int otherFalse = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (!doors[j] && j != pick)
                        otherFalse = j;
                }

                doors.Remove(doors[otherFalse]);
                for (int x = 0; x < 2; x++)
                {
                    if (!doors[x] && !firstCorrect)
                        pick = x;
                    else if (doors[x] && firstCorrect)
                        pick = x;
                }

                if (pick == 0)
                    pick = 1;
                else
                    pick = 0;


                if (doors[pick])
                    Wins++;
                else
                    Losses++;
            }
        }
    }
}
