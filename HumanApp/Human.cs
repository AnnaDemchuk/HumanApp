using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
    public class Human
    {
        public string Name;
        public int Hungry;
        public int Thirst;

        public int Apple;
        public int AppleCost = 4;
        public int Water;
        public int WaterCost = 2;

        public int EatApple;
        public int DrinkWater;
        public int Money;

        public void Eat()
        {
            Console.WriteLine($"{Name} am going to eat");

            if ((Hungry - EatApple) >= 0 && (Apple - EatApple) >= 0 && Hungry > 0)
            {
                Hungry -= EatApple;
                Apple -= EatApple;
                Console.WriteLine($"{Name} ate\n");
            }

            else if (Hungry == 0)
            {
                Console.WriteLine($"{Name} is am not hungry\n");
            }
            else
            {
                Console.WriteLine($"{Name} dosen't have enough Apple");
                Console.WriteLine($"{Name} must buy Apple\n");
            }
        }
        public void Drink()
        {
            Console.WriteLine($"{Name} am going to drink");

            if (Thirst - DrinkWater >= 0 && Water - DrinkWater >= 0 && Thirst > 0)
            {
                Thirst -= DrinkWater;
                Water -= DrinkWater;
                Console.WriteLine($"{Name} drank\n");
            }
            else if (Thirst == 0)
            {
                Console.WriteLine($"{Name} doesn't want to drink\n");
            }
            else
            {
                Console.WriteLine($"{Name} dosen't have enough Water");
                Console.WriteLine($"I must buy Water\n");
            }
        }

        public void ShowParametrs()
        {
            Console.WriteLine($"Name  : {Name}");
            Console.WriteLine($"Hungry: {Hungry}");
            Console.WriteLine($"Apple : {Apple}");
            Console.WriteLine($"AppleCost: {AppleCost}");
            Console.WriteLine($"EatApple : {EatApple}");

            Console.WriteLine($"Thirst: {Thirst}");
            Console.WriteLine($"Water : {Water}");

            Console.WriteLine($"WaterCost : {WaterCost}");
            Console.WriteLine($"DrinkWater: {DrinkWater}");

            Console.WriteLine($"Money: {Money}\n");
        }

        public void Buy(string what, int amount)
        {
            Console.WriteLine($"{Name} is going to market");

            if (what == "apple")
            {
                if (AppleCost * amount <= Money)
                {
                    Apple += amount;
                    Money -= AppleCost * amount;
                    Console.WriteLine($"{Name} buy: {amount} {what}, spend money: {AppleCost * amount}\n ");
                }
                else
                {
                    Console.WriteLine($"you don't have enough money to buy {what}\n");
                }
            }
            else if (what == "water")
            {
                if (WaterCost * amount <= Money)
                {

                    Water += amount;
                    Money -= WaterCost * amount;
                }
                else
                {
                    Console.WriteLine("you don't have enough money to buy\n");
                }
            }
            else
            {
                Console.WriteLine("Not apple and water\n");
            }
        }


        // Мы покупаем у кого-то
        public void Buy(string what, int amount, Human person)
        {
            Console.WriteLine($"{Name} is going to buy {person.Name}");
            if (what == "apple")
            {
                if (person.Apple >= amount)
                {
                    if (AppleCost * amount <= Money)
                    {
                        Apple += amount;
                        Money -= AppleCost * amount;
                        person.Money += AppleCost * amount;
                        person.Apple -= amount;
                        Console.WriteLine($"{Name} buy: {amount} {what}, spend money: {AppleCost * amount}\n ");
                    }
                    else
                    {
                        Console.WriteLine("you don't have enough money to buy");
                    }
                }
                else
                {
                    Console.WriteLine($"Seller don't have enough {what}");
                }

            }
            else if (what == "water")
            {
                if (person.Water >= amount)
                {
                    if (WaterCost * amount <= Money)
                    {
                        Water += amount;
                        Money -= WaterCost * amount;
                        person.Money += WaterCost * amount;
                        person.Water -= amount;
                        Console.WriteLine($"{Name} buy: {amount} {what}, spend money: {AppleCost * amount}\n ");
                    }
                    else
                    {
                        Console.WriteLine("you don't have enough money to buy");
                    }
                }
                else
                {
                    Console.WriteLine($"Seller don't have enough {what}");
                }
            }
            else
            {
                Console.WriteLine("Not apple and water");
            }
        }
      
        public void Sell(string what, int amount)
        {
            Console.WriteLine($"{Name} sell to market");
            if (what == "apple")
            {
                if (Apple <= amount)
                {
                    Apple -= amount;
                    Money += AppleCost * amount;
                    Console.WriteLine($"{Name} sell: {amount} {what}, earn money: {AppleCost * amount}\n ");
                }
                else
                {
                    Console.WriteLine($"You don't have enough {what} to sell");
                }
            }
            if (what == "water")
            {
                if (Water <= amount)
                {

                    Water -= amount;
                    Money += WaterCost * amount;
                    Console.WriteLine($"{Name} sell: {amount} {what}, earn money: {AppleCost * amount}\n ");
                }
                else
                {
                    Console.WriteLine($"You don't have enough {what} to sell");
                }
            }
            else
            {
                Console.WriteLine("Not apple and water");
            }
        }

        // Мы продаем  кому-то
        public void Sell(string what, int amount, Human person)
        {
            Console.WriteLine($"{Name} is going to sell {person.Name}");
            if (what == "apple")
            {
                if (Apple >= amount)
                {
                    if (AppleCost * amount <= person.Money)
                    {
                        Apple -= amount;
                        Money += AppleCost * amount;
                        person.Money -= AppleCost * amount;
                        person.Apple += amount;
                        Console.WriteLine($"{Name} sell: {amount} {what}, earn money: {AppleCost * amount}\n ");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money to buy");
                    }
                }
                else
                {
                    Console.WriteLine($"I don't have enough {what}");
                }
            }
         else if (what == "water")
            {
                if (Water >= amount)
                {
                    if (WaterCost * amount <= person.Money)
                    {
                        Water -= amount;
                        Money += WaterCost * amount;
                        person.Money -= WaterCost * amount;
                        person.Water += amount;
                        Console.WriteLine($"{Name} sell: {amount} {what}, earn money: {AppleCost * amount}\n ");
                    }
                    else
                    {
                        Console.WriteLine("you don't have enough money to buy");
                    }
                }
                else
                {
                    Console.WriteLine($"I don't have enough {what}");
                }

            }
            else
            {
                Console.WriteLine("Not apple and water");
            }
        }
    }
}
