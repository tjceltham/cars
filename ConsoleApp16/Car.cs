using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Car : Vehcile
    {
       
        private string wheel;

        public Car(int a, string driver, string w) : base(driver, a)
        {
            
            wheel = w;
        }
        public void setWheel(string w)
        {
            wheel = w;

        }


    }
}
