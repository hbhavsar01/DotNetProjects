﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }
    }
}