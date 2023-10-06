
using ClassesDemo;

//Instance of the classroom class so we can use the list it holds as propety
var classroom = new Classroom();

// Instance of a class(use the constructor to actually build an object or instance)
Person taj = new Person();

//Dot Notation to fill the value
taj.Name = "Taj";
taj.Age = 31;
taj.HairColor = "Dark Brown";



//adding this person to our list
classroom.OurClass.Add(taj);

//Console.WriteLine($"This is {taj.Name}, she is {taj.Age}. She has curly {taj.HairColor} hair.");

//Object initializer syntax

var jeremy = new Person()
{
    Name = "Jeremy",
    Age = 30,
    HairColor = "blonde"
    
};

classroom.OurClass.Add(jeremy);

//Using a custom constructor
var cruz = new Person("Cruz",30, "dark brown");

classroom.OurClass.Add(cruz);

classroom.GetDetails();