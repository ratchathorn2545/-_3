using System;
using System.Collections.Generic;
namespace No._3_63120501064
{
    class Flower
    {
        public string name;
        public List<string> Flowerlist = new List<string>();

        public Flower(string flowername)
        {
            name = flowername;
        }
    }

    class Cart
    {
        public List<string> cart = new List<string>();

        public void AddToCart(string name)
        {
            cart.Add(name);
        }

        public void showcart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string decide;
            string selectflower;
            do
            {
                Console.WriteLine("Select Number For Buy Flower :");
                Console.WriteLine("1 Rose");
                Console.WriteLine("2 Lotus");
                Flower nameflower1 = new Flower("Rose");
                Flower nameflower2 = new Flower("Lotus");

                selectflower = Console.ReadLine();
                if (selectflower == "1")
                {
                    Console.WriteLine("Added" + nameflower1.name);
                }
                else if (selectflower == "2")
                {
                    Console.WriteLine("Add" + nameflower2.name);
                }
                else
                {
                    Console.WriteLine("Not Added To Cart. Found Select Number Of Flower");
                }
                Console.WriteLine("You Can Stop This Progress ? Exit For >>Exit<< Progress And Press Any Key For Continute");
                decide = Console.ReadLine();
                Cart cart = new Cart();
                if (decide == "Exit")
                {
                    Console.Write("Current My Cart");
                    cart.showcart();
                }
            } while (decide != "Exit");
        }
    }
}

