using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Person
    {
        //Field - a variable inside of a class
        public int money;
        public string clothes;

        //properties 
        public string Name { get; set; } = "Bob";

        public int Age { get; set; } = 20;

        public string HairColor { get; set; } = "blonde";

        //Constructor

        //Default Constructor
        public Person()
        {

        }

        //Custom constructor(if you have a custom constructor, you always need your defualt constructor)
        public Person(string name, int age, string hairColor)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
        }



        //Methods in a class (non static)
        public void Greet()
        {
            Console.WriteLine($"Hello my name is {Name} and I am {Age} years old");
        }
    }

}
