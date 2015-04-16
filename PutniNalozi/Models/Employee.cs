using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PutniNalozi.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "Ime")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Prezime")]
        [Required]
        public string LastName { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}