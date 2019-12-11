using System;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Engine_Factory;

namespace AutoFacotrySingleton.Factory
{
    public class RoadsterFactroy : IFacotry
    {
        public CarBody CreateCarBody()
        {
            return new RoadsterCarBody();
        }

        public Chassis CreateChassis()
        {
            return new RoadsterChassis();
        }

        public Engine CreateEngine()
        {
            return new RoadsterEngine();
        }
    }
}
