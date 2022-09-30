using Linq_DEMO;
using System.Linq;

//----------------------------------------------------

int[] array1 = { 234, 432, 1, 35, 634, 325, 98, 2114 };



//array1.Where(x => x < 100)
//    .OrderByDescending(x => x)
//    .Take(2)
//    .ToList()
//    .ForEach(x => Console.WriteLine(x));

//------------------------------------------
//array1.Where(x => x < 100).ToList().ForEach(x => Console.WriteLine(x));


//IEnumerable<int> myNewCollection = array1.Where(x => x < 100);




//foreach (int num in myNewCollection)
//{
//    Console.WriteLine(num);
//}
//-------------------------------------------------

string[] dogs = 
{ 
    "Lassy", 
    "Air bud", 
    "Old Yeller", 
    "Beethoven", "Scooby", 
    "Winn Dixie", 
    "Marley", 
    "Snoopy", 
    "Benji", 
    "Shilo" 
};

dogs
    .OrderBy(x => x.Length)
    .ThenBy(x => x)
    .ToList()
    .ForEach(x => Console.WriteLine(x));



//-------------------------------------------------

var rng = new Random();//rng.Next(1, 100) -- switch for the one in enum range 


Enumerable.Range(0, 50)
    .Select(x => new Employee()
    {
        EmployeeID = x,
        FirstName = "John",
        LastName = "Smith",

    })
    .OrderByDescending(x => x.EmployeeID) //start you can swith for in the beginning var employees
    .ToList()
    .ForEach(x =>
    {
        Console.WriteLine(x.EmployeeID);
        Console.WriteLine(x.FirstName);
        Console.WriteLine(x.LastName);
    }); // with the foreach on the bottom


//foreach (var employee in employees)
//{
//    Console.WriteLine(employee.EmployeeID);
//    Console.WriteLine(employee.FirstName);
//    Console.WriteLine(employee.LastName);
//    Console.WriteLine();
//}

//---------------------------------------------
