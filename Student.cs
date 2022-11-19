using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace _16112022
{
    internal class Student
    {
        private string Id { get; set; }
        public string _name;

        public string name
        {
            get { return _name; }

            set
            {
                if (value.Length < 15)
                    _name = value;
                else
                {
                    _name = value.Substring(0, 15);
                }
            }
        }

        public string address { get; set; }

        public Student(string id_)
        {
            Id = id_;
        }


        public void save()
        {
            string[] str = new string[3];
            str[0] = Id;
            str[1] = _name;
            str[2] = address;


            File.WriteAllLines(this.Id + ".txt", str);
        }
            
       
            
             public void load ()
            {
                string[] str1;
                if (File.Exists(this.Id + ".txt"))
                {
                    str1 = File.ReadAllLines(this.Id + ".txt");
                }
                else
                {
                    Console.WriteLine("the file not open");
                }

            }


    }
}
