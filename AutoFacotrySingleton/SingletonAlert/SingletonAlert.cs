using System;
using AutoFacotrySingleton.Car_Body_Facotry;
using AutoFacotrySingleton.Engine_Factory;
using AutoFacotrySingleton.Chassis_Factory;
using AutoFacotrySingleton.Factory;
using AutoFacotrySingleton.Car;

namespace AutoFacotrySingleton.SingletonAlert
{
    public class SingletonAlert
    {
        public static SingletonAlert instance = null;
        public static SingletonAlert Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new SingletonAlert();
                }
                return instance;
            }
            
        }
        public void alert(Exception exception)
        {
            Console.WriteLine("Something went wrong");
        }
    }
}
