using System;
using AutoFacotrySingleton.Car_Body_Facotry;

namespace AutoFacotrySingleton.Car_Body_Facotry
{
    public class RoadsterCarBody : CarBody
    {
        public override void CreateFenders()
        {
            Console.WriteLine("Created Roadster Fenders");
        }

        public override void CreateHood()
        {
            Console.WriteLine("Crated Roadster Hood");
        }

        public override void CreateSunRoof()
        {
            Console.WriteLine("Created Roadster Sunroof");
        }
    }
}
