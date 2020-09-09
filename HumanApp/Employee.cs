using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
   public class Employee: Human
    {

        public void Work()
        {
            int salary = 8;
            this.Money += salary;
            Console.WriteLine($"{this.Name} worked and  earned: {salary}\n");
        }
    }
}
