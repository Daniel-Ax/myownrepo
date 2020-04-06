using System;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Engine_Factory;
using AutoFacotrySingleton.Chassis_Factory;

namespace AutoFacotrySingleton.Factory
{
    public interface IFacotry
    {
        CarBody CreateCarBody();
        Chassis CreateChassis();
        Engine CreateEngine();
    }
}
