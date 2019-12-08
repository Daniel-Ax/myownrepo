using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Car_Body_Facotry
{
    public class ModelYCarBody:CarBody
    {
        public override void CreateFenders()
        {
            Console.WriteLine("Created Model-Y Fenders");
        }

        public override void CreateHood()
        {
            Console.WriteLine("Created Model-Y Hood");
        }

        public override void CreateSunRoof()
        {
            Console.WriteLine("Created Model-Y Sunroof");
        }
    }
}
