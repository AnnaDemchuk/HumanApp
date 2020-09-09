using System;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vasia vasia = new Vasia();
            Petia petia = new Petia();
            Maria maria = new Maria();
            Alex alex=new Alex();


            //vasia.ShowParametrs();
            //maria.ShowParametrs();
            //maria.Sell("apple", 2, vasia);
            //vasia.ShowParametrs();
            //maria.ShowParametrs();

            //petia.ShowParametrs();
            //petia.Work();
            //petia.ShowParametrs();


            //alex.ShowParametrs();
            //alex.Eat();
            //vasia.ShowParametrs();


            //alex.ShowParametrs();
            //alex.Buy( "water", 2);
            //alex.ShowParametrs();

            alex.ShowParametrs();
            alex.Drink();
            alex.ShowParametrs();

        }
    }
}
