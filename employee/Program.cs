using ExercícioAula140.entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercícioAula140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            System.Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                System.Console.WriteLine($"Employee number {i} datas");
                System.Console.Write("Out sourced (y/n) ?");
                char ch = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                System.Console.WriteLine("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Value per hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    System.Console.WriteLine("Addicional Charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hour, valuePerHour, addicionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hour, valuePerHour));
                }
            }

            Console.WriteLine();
            System.Console.WriteLine("Payments: ");

            foreach (var emp in list)
            {
                System.Console.WriteLine(emp.Name + "- $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
