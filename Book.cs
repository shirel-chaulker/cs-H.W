using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16112022
{
    internal class Book
    {
        private int _Id ;

        public int Id
        {
            get { return _Id; }
             private set { _Id = value; }
        }


        public string Name { get; set; }


         public Book(string aName)
        {
            Name = aName;
            _Id= GenerateNewId();
        }

        private static int counter=0;

       private static int GenerateNewId()
        {

            return ++counter;
            
        }
    }
}
