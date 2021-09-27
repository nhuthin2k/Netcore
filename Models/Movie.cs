using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Require(ErrorMessage="title is require.")]
        [MaxLenght (15)]
        [MinLenght(3)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}