using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Engine_Factory
{
    public class ModelSEngine:Engine
    {
        public ModelSEngine()
        { 
            
        }

        public override void CreateAirFiller()
        {
            Console.WriteLine("Created Model-S Air filler");
        }

        public override void CreateGenerator()
        {
            Console.WriteLine("Created Model-S Generator");
        }

        public override void CreateOilFiller()
        {
            Console.WriteLine("Created Model-S Oil filler");
        }
    }
}
