using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Engine_Factory;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Factory;
using AutoFacotrySingleton.SingletonAlert;

namespace AutoFacotrySingleton.Car
{
    public class ConcreteCar
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
            AssembleCars(carb, chas, engi);
        }
        
        public void AssembleCars(CarBody c, Chassis ch,Engine e)
        {
            
            cars.Add(new ConcreteCar(c, ch, e));
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
        public List<ConcreteCar> concreteCars()
        {
            return cars;
        }
        public void Diagnostic(CarBody body,Chassis chassis, Engine engine)
        {
            Console.WriteLine($"Run diagnostic...{body}");
            Console.WriteLine($"Run diagnostic...{chassis}");
            Console.WriteLine($"Run diagnostic...{engine}");
            try
            {
                if (50>new Random().Next(1,100))
                {
                    throw new Exception("Malfunction");
                }
            }
            catch (Exception ex)
            {
                SingletonAlert.SingletonAlert.Instance.alert(ex);
            }
        }

    }
}
