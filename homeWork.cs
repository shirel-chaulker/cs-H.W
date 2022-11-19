using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16112022
{
    internal class Item
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            private set { _Id = value; }
        }

        public string Name { get; set; }
        public string Price { get; set; }

        public Item(int aId)
        {
            _Id = aId;
        }
       
    }

    internal class Drink :  Item
    {
        public string LiquidColor { get; set; }
        public Drink(int Id, string liquidColor) : base(Id) 
        {
            LiquidColor = liquidColor;
        }
        
        
    }

     internal class Food : Item
    {
        public int Weight { get; set; }

        public Food(int Id, string weight) : base(Id) 
        {
            Weight= Weight;
        }
       
    }

    

}
