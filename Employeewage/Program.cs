// See https://aka.ms/new-console-template for more information


using Employeewage;


public class wageforeachcompany
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to employee wage program!");
        while (true)
        {
            Console.WriteLine("choose the program to be executed:\n8)wage for multiple companies\n9)total wage for each company\n10)different Empwages for different companies");



            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 8:
                    WageCalculation wage = new WageCalculation();

                    wage.EmployeeWage("BridgeLabs", 20, 20, 100);
                    wage.EmployeeWage("Amazon", 30, 20, 120);

                    break;
                case 9:

                    wageCalculation Amazon = new wageCalculation("Amazon", 20, 5, 100);
                    Amazon.computewage();
                    wageCalculation BridgeLabs = new wageCalculation("Bridge Labs", 25, 5, 120);
                    BridgeLabs.computewage();
                    break;
                case 10:
                    EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                    empWageBuilder.addCompanyEmpWage("Amazon", 20, 5, 100);
                    empWageBuilder.addCompanyEmpWage("Bridge Labs", 25, 5, 120);
                    empWageBuilder.computeEmpWage();
                    break;


            }
        }
    }
}

