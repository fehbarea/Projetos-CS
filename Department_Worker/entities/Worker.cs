using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FuncDepart.entities.enuns;

namespace FuncDepart.entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; private set; } = new List<HourContract>();

        public Worker()
        {

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum =  BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if(contract.Date.Year == year && contract.Date.Month == month ){
                   
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}