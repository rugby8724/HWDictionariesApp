
Dictionary<int, string> employees = new Dictionary<int, string>();

employees[100] = "Bob";
employees[101] = "Tad";
employees[102] = "Tim";
employees[103] = "Billy";

Console.WriteLine("Hello, to look up an employee enter a number between 100 and 103");
string employeeIdText = Console.ReadLine();

if (int.TryParse(employeeIdText, out int employeeID) && employeeID >= 100 && employeeID <= 103)
{
    Console.WriteLine($"Employee {employeeID} is {employees[employeeID]}");
}
else
{
    Console.WriteLine($"There is no employee with an id of {employeeIdText}");
}



