using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Engine_Factory
{
    public class ModelYEngine:Engine
    {
        public override void CreateAirFiller()
        {
            Console.WriteLine("Created Model-Y Air filler");
        }

        public override void CreateGenerator()
        {
            Console.WriteLine("Created Model-Y Generator");
        }

        public override void CreateOilFiller()
        {
            Console.WriteLine("Created Model-Y Oil filler");
        }
    }
}
