using System;
using HF2.Model;

namespace HF2
{
    class Field
    {
       static int[,] field = new int[8, 8];

        private MachinePlayer machinePlayer = new MachinePlayer(field);
        public MachinePlayer GetMachinePlayer() => machinePlayer;

        private UserPlayer userPlayer = new UserPlayer(field);
        public UserPlayer GetUserPlayer() => userPlayer;
         
        public void Initialize()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if ((row % 2 == 0 && column % 2 == 1) || (row % 2 == 1 && column % 2 == 0))
                    {
                        if (row < 3)
                            field[row, column] = 2;
                        if (row > 4)
                            field[row, column] = 1;
                    }
                }
            }
        }

        public void Print()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    Console.Write(field[row, column]);
                }
                Console.WriteLine("");
            }
        }

        public bool GameOver()
        {
            return true;
        }
    }
}
