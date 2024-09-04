using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Management.models
{
    public class Admin : Person
    {
        private int AdminRole;
        private string RoleName;
        private string Messege;

        private int OfficeNo;
        public void TakeAdminsInfo()
        {
            Console.WriteLine($"==========Taking Admin's Common Information===========");
            Console.Write($"Enter your ID: ");
            ID = Console.ReadLine();
            Console.Write($"Enter your First Name: ");
            FirstName = Console.ReadLine();
            Console.Write($"Enter your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write($"Enter your Email: ");
            Email = Console.ReadLine();
            Console.Write($"Enter your Phone Number: ");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine($"==============Taking Specific Informatin for the Admin===========");
            GetRoleDetails();
            OfficeLocationDetails();
        }
        public override void PrintInfo()
        {
            CommonInfo("Admin JOB Confirmation");
            Console.WriteLine($"Selected Role: {RoleName}");
            Console.WriteLine($"Office Location: {Messege}");
        }

        private void OfficeLocationDetails()
        {
            Console.WriteLine($"Here is our PRIVATE SERVER Room Details:");
            Console.WriteLine($"*-------------------------------------*");
            Console.WriteLine($"| 1. Dhaka Zone, Room 2, Bulding 4    |");
            Console.WriteLine($"| 2. Dhaka Zone, Room 3, Bulding 1    |");
            Console.WriteLine($"| 3. Mirpur Zone, Room 3, Bulding 1   |");
            Console.WriteLine($"| 4. Cummila Zone, Room 2, Building 12|");
            Console.WriteLine($"================================");
            Console.Write($"Where do you want to work? (ex: 1, 2, 3, 4): ");
            OfficeNo = int.Parse(Console.ReadLine());

            Messege = OfficeNo switch
            {
                1 => "Thank you for choosing Dhaka Zone, Room 2, Bulding 4. Welcome Your new Office.",
                2 => "Thank you for choosing Dhaka Zone, Room 3, Bulding 1. Welcome Your new Office.",
                3 => "Thank you for choosing Mirpur Zone, Room 3, Bulding 1. Welcome Your new Office.",
                4 => "Thank you for choosing Cummila Zone, Room 2, Building 12. Welcome Your new Office.",
                _ => "Error: Invalid Choice."
            };

        }
        private void GetRoleDetails()
        {
            Console.WriteLine($"Our Software have Two (2) Roles for the \"Admin\"");
            Console.WriteLine($"***********Role Details************");
            Console.WriteLine($"1. Register: Manages the Registration Of the Students.");
            Console.WriteLine($"-----Salary: $340.33");
            Console.WriteLine($"2. Course Coordinatior: Helps the Teachers on classes.");
            Console.WriteLine($"-----Salary: $540.33");
            Console.WriteLine($"==========================");
            Console.Write($"In which Role do you want to Apply? (1 or 2): ");
            AdminRole = int.Parse(Console.ReadLine());
            RoleName = AdminRole == 1 ? "Register" : "Course Coordinatior";
        }
    }
}