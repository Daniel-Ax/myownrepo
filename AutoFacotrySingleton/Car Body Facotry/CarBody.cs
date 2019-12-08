using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacotrySingleton.Car_Body_Facotry
{
    public abstract class CarBody
    {
        public abstract void CreateHood();
        public abstract void CreateFenders();
        public abstract void CreateSunRoof();
    }
}
