using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
  public  class Petia: Employee
    {
        public Petia()
        {
            this.Name = "Petia";
            this.Hungry = 3;
            this.Thirst = 2;

            this.Apple = 6;
            this.Water = 8;

            this.EatApple = 3;
            this.DrinkWater = 5;
            this.Money = 6;
        }
    }
}
