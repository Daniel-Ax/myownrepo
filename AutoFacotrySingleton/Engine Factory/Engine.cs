using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Engine_Factory
{
    public abstract class Engine
    {
        public abstract void CreateOilFiller();
        public abstract void CreateAirFiller();
        public abstract void CreateGenerator();
    }
}
