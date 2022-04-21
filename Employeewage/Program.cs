// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Employee Wage computation program!");

int empwageperhrs = 20;
int emphrs = 0;
Random CheckempAttandance = new Random();
int ispresent = CheckempAttandance.Next(0, 3);
Console.WriteLine(ispresent);



switch (ispresent)
{
    case 1:
        Console.WriteLine("Employee is present!");
        Console.WriteLine("Employee is Full Time");
        emphrs = 8;
        break;
    case 2:
        Console.WriteLine("Employee is present!");
        Console.WriteLine("Employee is Full Time");
        emphrs = 4;
        break;
    case 0:
        Console.WriteLine("Employee is present!");
        Console.WriteLine("Employee is Full Time");
        emphrs = 0;
        break;

}
int Salary = emphrs * empwageperhrs;
Console.WriteLine("Employee Salary = " + Salary);