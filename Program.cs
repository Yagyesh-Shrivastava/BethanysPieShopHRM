
using System.Collections.Generic;
namespace BethanysPieShopHRM.HR;
class Program
{
    public static List<Employee> employees = new List<Employee>();
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*****************************");
        Console.WriteLine("$$ Bethnay's Pie Shop Employee App $$");
        Console.WriteLine("*****************************");
        Console.ForegroundColor = ConsoleColor.White;

        string userSelection;

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("************");
            Console.WriteLine("## Select an action ##");
            Console.WriteLine("************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1. Register Employee");
            Console.WriteLine("2. Register work hours for Employees");
            Console.WriteLine("3. Pay Employee");
            Console.WriteLine("9. Quit Application");

            userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":RegisterEmployee();
                    break;

                case "2": RegisterWork();
                    break;

                case "3": PayEmployee();
                    break;

                case "9":
                    break;

                default:
                    Console.WriteLine("Invalid selcection... Try Again!!!!");
                    break;
            }
        }
        while (userSelection != "9");
        Console.WriteLine("Thanks for using the application");
        Console.Read();
               
    }

    private static void RegisterEmployee()
    {
        Console.WriteLine("Creating an Employee");
        Console.Write("Enter the First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter the Last Name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter the Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter the hourly rate: ");
        string hourlyRate = Console.ReadLine();
        double rate  = double.Parse(hourlyRate);

        Employee employee = new Employee(firstName, lastName, email, rate);
        employees.Add(employee);

        Console.WriteLine("Employee Created\n\n");
    }

    private static void RegisterWork()
    {
        Console.WriteLine("Select an Employee");
        for(int i=1; i<=employees.Count; i++)
        {
            Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
        }

        int selection = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of hours worked: ");
        int hours = int.Parse(Console.ReadLine());

        Employee selectedEmployee = employees[selection - 1];
        int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
        Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked" +
            $"{numberOfHoursWorked} hours in total.\n\n");
    }

    private static void PayEmployee()
    {
        Console.WriteLine("Select an Employee");
        for(int i=1; i<=employees.Count; i++)
        {
            Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
        }

        int selection = int.Parse(Console.ReadLine());

        Employee selectedEmployee = employees[selection - 1];
        int hoursWorked;
        double recivedWage = selectedEmployee.ReceiveWage(out hoursWorked);

        Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has recieved a wage of" +
            $"{recivedWage}. The hours worked is reset to {hoursWorked}.\n\n");
    }



}