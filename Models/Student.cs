using System;
using System.ComponentModel.DataAnnotations;

namespace DEMOMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        public string StudentClass { get; set; }
        
    }
}