using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    public class Manager : Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double rate) : base (first, last, em, bd, rate)
        {

        }

        //Adding some Manager functionality

        public void AttendManagementMeeting()
        {
            NumberofHoursWorked += 10;
            Console.WriteLine($"{FirstName} {LastName} is now attending a long meeting that could have been an email!!!");
        }
        public override void GiveBouns()
        {
            if (NumberofHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recived a management bonus of Rs.500 !");
            }
            else
                Console.WriteLine($"Manager {FirstName} {LastName} recived a management bonus of Rs.250 !");
        }

        
    }
}
