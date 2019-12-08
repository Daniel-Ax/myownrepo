using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Chassis_Factory
{
    public abstract class Chassis
    {
        public abstract void CreatingRockingArm();
        public abstract void CreatingNeedleBeam();
        public abstract void CreatingShockAbsorber();
    }
}
