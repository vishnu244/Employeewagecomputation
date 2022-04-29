// See https://aka.ms/new-console-template for more information


using Employeewage;

Console.WriteLine("Welcome to Employee Wage computation program!");
Console.WriteLine("\n");

//WageCalculation wage = new();

//wage.EmployeeWage("BridgeLabs", 20, 20, 100);
//wage.EmployeeWage("Amazon", 30, 20, 120);

WageCalculation Amazon = new WageCalculation("Amazon", 20, 5, 100);
Amazon.computewage();
WageCalculation BridgeLabs = new WageCalculation("Bridge Labs", 25, 5, 120);
BridgeLabs.computewage();


