using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        // Add sales one in ICollerctio SalesRecord List
        public void AddSales(SalesRecord sales)
        {
            Sales.Add(sales);
        }
        // Remove sales one in ICollerctio SalesRecord List
        public void RemoveSales(SalesRecord sales)
        {
            Sales.Remove(sales);
        }
        
        // Total Sales
        public Double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final)
                        .Sum(x => x.Amount);
        }


    }
}
