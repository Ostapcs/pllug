
using System;
using System.Reflection;

namespace pllug
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UserInterface.usrinterface();
        }

        public static int GetPropertyCount(Object obj)
        {
            var myType = obj.GetType();

            var props = myType.GetProperties();
            var NaNcount = 0;
            foreach (var prop in props)
            {
                if (prop.GetValue(obj).ToString() == "NaN")
                {
                    NaNcount++;
                }
            }

            return NaNcount;


        }
        
        
    }
    
    
}
