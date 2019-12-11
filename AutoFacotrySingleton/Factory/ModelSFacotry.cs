using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Engine_Factory;

namespace AutoFacotrySingleton.Factory
{
    class ModelSFacotry : IFacotry
    {
        public CarBody CreateCarBody()
        {
            return new ModellSCarBody();
        }

        public Chassis CreateChassis()
        {
            return new ModelSChassis();
        }

        public Engine CreateEngine()
        {
            return new ModelSEngine();
        }
    }

}