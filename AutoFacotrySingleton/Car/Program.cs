using System;
using AutoFacotrySingleton.Factory;

namespace AutoFacotrySingleton.Car
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteCar car = new ConcreteCar();
            IFacotry factory;
            factory = new ModelSFacotry();
            car.SetFactory(factory);
            car.InitCarElements();
            car.ShowAssemblingCarParts();
        }
    }
}
