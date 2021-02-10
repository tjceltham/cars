using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Vehcile
    {
        private string driver;
        private int amountDoors;
        private Boolean drive;
        private string reg;
   
       public Vehcile(string d, int aD)
        {
            driver = d;
            amountDoors = aD;
            drive= true;
        }

        public int getDoors()
        {
            return amountDoors;
        }

        public void setDoors(int d)
        {
            amountDoors = d;
        }

        public void SlightAccident()
        {
            Console.WriteLine("ohh dear ");
            drive = false;

        }
        public void repair()
        {
            drive = true;
        }


    }
}
