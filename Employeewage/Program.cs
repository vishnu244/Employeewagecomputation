// See https://aka.ms/new-console-template for more information


using Employeewage;

Console.WriteLine("Welcome to Employee Wage computation program!");

WageCalculation wage = new();

wage.EmployeeWage("BridgeLabs", 20, 20, 100);
wage.EmployeeWage("Amazon", 30, 20, 120);

 