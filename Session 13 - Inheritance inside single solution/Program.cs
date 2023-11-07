using Session_13___Inheritance_inside_single_solution.Models;


Employee marge = new Employee { 
    Id = 1, 
    EmployeeId = 10,
    FirstName = "Marge",
    LastName = "Simpson",
    Address = "Terrance Avenue",
    City = "Springfield",
    PhoneNumber = 12345678,
    SalaryLevel = 10,
    Title = "Worker"
};

Employee homer = new Employee { 
    Id = 2,
    EmployeeId = 2,
    FirstName = "Homer",
    LastName = "Simpson",
    Address = "Terrance Avenue",
    City = "Springfield",
    PhoneNumber = 12345678,
    SalaryLevel = 10,
    Title = "Worker"
};


// Opgave 1 - override ToString()
Console.WriteLine(marge.ToString());


// Opgave 2 - override Equals()
if (marge.Equals(homer))
{
    Console.WriteLine("Employees are identical");
} else if(!(marge.Equals(homer)))
{
    Console.WriteLine("Employees are not-equals");
}



