using System;
using FuncDepart.entities.enuns;
using FuncDepart.entities;
using System.Globalization;

namespace FuncDepart {

    class program {
        static void Main(string[] args) {
            System.Console.WriteLine("Enter department's name: ");
            string depName = Console.ReadLine();
            System.Console.WriteLine("Enter worker data: ");
            System.Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Level : Junior / MidLevel / Senior ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);
             
            Department depart = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, depart);

            System.Console.Write(" how many contracts to this worker");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){

                System.Console.WriteLine($"Enter {i} contract data:");
                System.Console.WriteLine("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                System.Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine("Durantion (hour)");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            String monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine("Nmae: "+worker.Name);
            System.Console.WriteLine("Department: " + worker.Department);
            System.Console.WriteLine("Income for "+ monthAndYear +": " + worker.Income(year,month));
        }
    }
}