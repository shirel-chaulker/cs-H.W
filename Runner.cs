using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _16112022
{
    internal class Runner
    {
        Item[] arr2 = new Item[10];
        public void run()
        {
            Student ofek = new Student("1");
            ofek.address = "akko";
            ofek.name = "ofek";
            ofek.save();
            ofek.load();

            Item[] arr = new Item[2];
            arr[0] = new Drink(1, "blue");
            arr[1] = new Food(2, "5");
            arr[0].Name = "cola";
            arr[0].Price = "8";
            arr[1].Name = "pizza";
            arr[1].Price = "10";

           
            for (int i = 0; i < 10; i++)
            {
                if(i<5)
                {
                    Console.WriteLine("please enter id");
                    string temp = Console.ReadLine();
                    int result= int.Parse(temp);
                    Console.WriteLine("please enter a LiquidColor");
                    arr2[i] = new Drink(result, Console.ReadLine());
                    arr2[i].Name=Console.ReadLine();    
                    arr2[i].Price = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("please enter id");
                    string temp = Console.ReadLine();
                    int result = int.Parse(temp);
                    Console.WriteLine("please enter a Weight");
                    arr2[i] = new Food(result, Console.ReadLine());
                    arr2[i].Name = Console.ReadLine();
                    arr2[i].Price = Console.ReadLine();
                }
                
            }




        }

        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr2[i].Name);
                Console.WriteLine(arr2[i].Id);
            }
        }


        public void item100()
        {
            Item[] arr3 = new Item[100];

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                if(rand.Next(2)==1)
                {
                    Console.WriteLine("please enter id");
                    string temp = Console.ReadLine();
                    int result = int.Parse(temp);
                    Console.WriteLine("please enter a LiquidColor");
                    arr3[i] = new Drink(result, Console.ReadLine());
                    arr3[i].Name = Console.ReadLine();
                    arr3[i].Price = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("please enter id");
                    string temp = Console.ReadLine();
                    int result = int.Parse(temp);
                    Console.WriteLine("please enter a Weight");
                    arr3[i] = new Food(result, Console.ReadLine());
                    arr3[i].Name = Console.ReadLine();
                    arr3[i].Price = Console.ReadLine();
                }
            }
            for (int i = 0; i < 100; i++)
            {
               
                if (arr3[i] is Drink)
                {
                    Drink banana = (Drink)arr3[i];
                    Console.WriteLine(banana.Name);
                    Console.WriteLine(banana.Id);
                    Console.WriteLine(banana.Price);
                    Console.WriteLine(banana.LiquidColor);
                }
                else if (arr3[i] is Food)
                {
                    Food burger = (Food)arr3[i];
                    Console.WriteLine(burger.Name);
                    Console.WriteLine(burger.Id);
                    Console.WriteLine(burger.Price);
                    Console.WriteLine(burger.Weight);
                }
            }
        }
    }
}
