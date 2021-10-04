using System;
using System.ComponentModel.DataAnnotations;

namespace demoMVC.Models
{
    public class student
    {
        [Key]
        public int MaSV { get; set; }
        public string TenSV { get; set; }
    }
}