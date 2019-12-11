using System;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Engine_Factory;

namespace AutoFacotrySingleton.CarBodyFacotry
{
    public class RoadsterCarBody:CarBody
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
