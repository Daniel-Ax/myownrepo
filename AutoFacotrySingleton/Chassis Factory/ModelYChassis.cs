using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Chassis_Factory
{
    public class ModelYChassis:Chassis
    {
        public override void CreatingNeedleBeam()
        {
            Console.WriteLine("Created Model-Y Needle-Beam");
        }

        public override void CreatingRockingArm()
        {
            Console.WriteLine("Created Model-Y Rocking-Arm");
        }

        public override void CreatingShockAbsorber()
        {
            Console.WriteLine("Created Model-Y Shock absorber");
        }
    }
}
