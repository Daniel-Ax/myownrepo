using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Factory
{
    public abstract class Factory
    {
        public abstract void Run(int amount);
        public abstract void CreateCarBody();
        public abstract void CreateChassis();
        public abstract void CreateEngine();
    }
}
