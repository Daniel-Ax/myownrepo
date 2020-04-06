using System;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Engine_Factory;

namespace AutoFacotrySingleton.Chassis_Factory
{
    public class RoadsterChassis:Chassis
    {
        public override void CreatingNeedleBeam()
        {
            Console.WriteLine("Created Roadster Needle-beam");
        }

        public override void CreatingRockingArm()
        {
            Console.WriteLine("Created Roadster Rocking-arm");
        }

        public override void CreatingShockAbsorber()
        {
            Console.WriteLine("Created Roadster Absorber");
        }
    }
}
