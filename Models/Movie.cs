using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;



namespace demoMVC.Models
{
    public class Movie
    {
        [Key]
         public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "nvarchar(18, 2)")]
    public decimal Price { get; set; }
    public string Genre { get; set; }

    public string Rating { get; set; }
    //abc@xyz.com
    [EmailAddress]
    public string   Email {get;set;}
    }
}