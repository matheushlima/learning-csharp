using System;
using System.Collections.Generic;
using System.Text;
using Contratos.Entities.Enums;

namespace Contratos.Entities
{
    class Worker
    {
        public string Name{ get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public List<HourContract> Contracts = new List<HourContract>();
        public Department Department;

        public Worker()
        {

        }

        public Worker(string name, double baseSalary, WorkerLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            foreach(HourContract contracts in Contracts)
            {
                if(contracts.Date.Year == year && contracts.Date.Month == month)
                {
                    BaseSalary += contracts.TotalValue();
                }
            }

            return BaseSalary;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Name: " + Name);
            text.AppendLine("Department: " + Department);

            return text.ToString();
        }
    }
}
