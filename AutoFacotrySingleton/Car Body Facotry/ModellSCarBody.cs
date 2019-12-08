using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Car_Body_Facotry
{
    public class ModellSCarBody:CarBody
    {

        public override void CreateHood()
        {
            Console.WriteLine("Created Model-S Hood");
        }

        public override void CreateFenders()
        {
            Console.WriteLine("Created Model-S Fenders");
        }

        public override void CreateSunRoof()
        {
            Console.WriteLine("Created Model-S Sunroof");
        }
    }
}
