using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Engine_Factory;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Factory;

namespace AutoFacotrySingleton.Car
{
    class ConcreteCar
    {
        public CarBody carb;
        public Chassis chas;
        public Engine engi;
        public IFacotry factory;
        public List<ConcreteCar> cars = new List<ConcreteCar>();

        public ConcreteCar(CarBody carb, Chassis chas,Engine engi)
        {
            this.carb = carb;
            this.chas = chas;
            this.engi = engi;
        }

        public ConcreteCar()
        {
        }

        public void SetFactory(IFacotry fy)
        {
            factory = fy;
        }

        public void InitCarElements()
        {
            chas = factory.CreateChassis();
            carb = factory.CreateCarBody();
            engi = factory.CreateEngine();
        }
        
        public void AssembleCars()
        {
            cars.Add(new ConcreteCar(carb,chas,engi));
        }

        public void ShowAssemblingCarParts()
        {
            carb.CreateFenders();
            carb.CreateHood();
            carb.CreateSunRoof();
            chas.CreatingNeedleBeam();
            chas.CreatingRockingArm();
            chas.CreatingShockAbsorber();
            engi.CreateAirFiller();
            engi.CreateGenerator();
            engi.CreateOilFiller();
        }

    }
}
