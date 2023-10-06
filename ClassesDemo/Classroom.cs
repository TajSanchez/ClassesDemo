using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Classroom
    {
        // properties can be of type list or array
        public List<Person> OurClass { get; set; } = new List<Person>();

        // method in a class(non static)
        public void GetDetails()
        {
            //looping through every person in our list property called "OurClass"

            foreach (var person in OurClass)
            {
                //calling method from the Person class variable called "person"
                //"person" takes the place of everything in the "OurClass" list when looping through
                person.Greet();
            }
        }
    }
}
