namespace BethanysPieShopHRM.HR
{
    public class Employee
    {

        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;

        private DateTime birthDay;
        public static double taxRate = 0.15;


        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            FirstName = first;     // using getter and setter method name in the whole class this increase the security
            LastName = last;
            Email = em;            
            BirthDay = bd;
            HourlyRate = rate;
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int NumberofHoursWorked
        {
            get { return numberOfHoursWorked; }
            set { numberOfHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
            }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public int PerformWork(int hours)
        {
            numberOfHoursWorked += hours;
            Console.WriteLine($"{firstName} {lastName} is now working !");
            return numberOfHoursWorked;
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working !");
        }

        public double ReceiveWage(out int hoursWorked)
        {
            double wageBeforeTax = numberOfHoursWorked * hourlyRate;
            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;
            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}");
            numberOfHoursWorked = 0;
            hoursWorked = NumberofHoursWorked;
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {firstName} \nLast Name: {lastName} \nEmail: {email}\n BirthDay: {BirthDay.ToShortDateString()}\n");

        }

        public virtual void GiveBouns()
        {
            Console.WriteLine($"{FirstName} {lastName} recived a generic bonus of Rs.100 !");
        }

    }
}
