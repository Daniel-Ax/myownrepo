using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Chassis_Factory
{
    public class ModelSChassis : Chassis
    {
        public override void CreatingNeedleBeam()
        {
            Console.WriteLine("Created Model-S Needle-Beam");
        }

        public override void CreatingRockingArm()
        {
            Console.WriteLine("Created Model-S Rocking-Arm");
        }

        public override void CreatingShockAbsorber()
        {
            Console.WriteLine("Create Model-S Shock absorber");
        }
    }
}
