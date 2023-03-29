using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Health = 100;
        }

        public string Name { get; set; }
        public int  Age { get; set; }
        public int Health { get; set;}

        public string Walking() 
        {
            return "Walking";
        }


    }
}
