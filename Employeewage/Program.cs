// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Employee Wage computation program!");

int empwageperhrs = 20;
int emphrs;
Random CheckempAttandance = new Random();
int ispresent = CheckempAttandance.Next(0, 2);
Console.WriteLine(ispresent);
if (ispresent == 1)
{
    Console.WriteLine("Employee is present!");
    emphrs = 8;

}

else
{
    Console.WriteLine("Employee is Absent!");
    emphrs = 0;

}
int Salary = emphrs * empwageperhrs;
Console.WriteLine("Employee Salary = " + Salary);