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
    class ModelYFactory : IFacotry
    {
        public CarBody CreateCarBody()
        {
            return new ModelYCarBody();
        }

        public Chassis CreateChassis()
        {
            return new ModelYChassis();
        }

        public Engine CreateEngine()
        {
            return new ModelYEngine();
        }
    }
}
