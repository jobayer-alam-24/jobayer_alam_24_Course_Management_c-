namespace Course_Management.models
{
    public class Person
    {
        protected string ID;
        protected string FirstName;
        protected string LastName;
        protected string Email;
        protected string PhoneNumber;

        private string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        protected void CommonInfo(string whoseInfo)
        {
            Console.WriteLine($"========={whoseInfo} Info==========");
            Console.WriteLine($"ID: #{ID}");
            Console.WriteLine($"Username: @{FirstName}");
            Console.WriteLine($"Name: {GetFullName()}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
        protected void PrintEnrollCourse(string[] Courses, int len)
        { 
            for (int i = 0; i < len; i++)
            {
                if (i > 0)
                {
                    Console.Write($", ");
                }
                Console.Write(Courses[i]);
            }
            Console.WriteLine();
        }
        public virtual void PrintInfo()
        {
            CommonInfo("Student");
        }
    }
}