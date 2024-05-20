namespace Ovning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonalRegister> personalList = new List<PersonalRegister>();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Options: ");
                Console.WriteLine("Option 1. List employees and salary.");
                Console.WriteLine("Options 2. Enter new employee and salary.");
                Console.WriteLine("Option 3. Terminate Program.");
                Console.Write("Enter choise: ");

                string option = Console.ReadLine();

                if (option == "1")
                    ListEmployees(personalList);
                else if (option == "2")
                    AddEmployee();
                else if (option == "3")
                    running = false;
                
            }

            void AddEmployee()
            {
                PersonalRegister personalRegister = new PersonalRegister();

                Console.Write("Enter Name: ");
                personalRegister.Name = Console.ReadLine();
                Console.Write("Enter Salary: ");
                personalRegister.Salery = Convert.ToDouble(Console.ReadLine());

                personalList.Add(personalRegister);
            }

            void ListEmployees(List<PersonalRegister> personal)
            {
                foreach (var item in personal)
                    Console.WriteLine($"Employee name {item.Name} and current salary is {item.Salery}");

                Console.WriteLine("Press Key To Continue:");
                Console.ReadLine();
            }
        }
    }
}
