using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalay { get; set; }
        public Department Department { get; set; }
        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalay, Department department)
        {
            Name = name;
            Level = level;
            BaseSalay = baseSalay;
            Department = department;
        }

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalay;
            foreach (HoursContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
