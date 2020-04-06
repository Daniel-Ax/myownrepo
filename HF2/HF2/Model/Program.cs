using System;

namespace HF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field();
            field.Initialize();
            bool userMoved;

            while (field.GameOver())
            {
                field.Print();
                userMoved = false;

                while (!userMoved)
                {
                    #region read in
                    Console.WriteLine("Enter X1 coordinate");
                    int XCoor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Y1 coordinate");
                    int YCoor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter X2 coordinate");
                    int X2Coor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Y2 coordinate");
                    int Y2Coor = Convert.ToInt32(Console.ReadLine());
                    #endregion

                    if (field.GetUserPlayer().UserMove(XCoor, YCoor, X2Coor, Y2Coor))
                        userMoved = true;
                }

                field.Print();
                field.GetMachinePlayer().MachineTurn();
            }
        }
    }
}
