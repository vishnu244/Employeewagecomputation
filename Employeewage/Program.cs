// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employeewage computation!");

Console.WriteLine("Welcome to Employee Wage computation program!");

Random Attendancecheck = new Random();
int ispresent = Attendancecheck.Next(0, 2);
Console.WriteLine(ispresent);
if (ispresent == 1)
    Console.WriteLine("Employee is present!");
else
    Console.WriteLine("Employee is Absent");
