using System;
using AutoFacotrySingleton.Engine_Factory;

namespace AutoFacotrySingleton.Engine_Factory
{
    public class RoadsterEngine:Engine
    {
        public override void CreateAirFiller()
        {
            Console.WriteLine("Created Roadster Air filler");
        }

        public override void CreateGenerator()
        {
            Console.WriteLine("Created Roadster Generator");
        }

        public override void CreateOilFiller()
        {
            Console.WriteLine("Created Roadster Oil filler");
        }
    }
}
