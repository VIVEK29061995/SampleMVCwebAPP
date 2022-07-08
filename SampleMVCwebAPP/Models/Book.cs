using System;
using System.ComponentModel.DataAnnotations;

namespace SampleMVCwebAPP.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }



        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }



        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Author is Required")]
        [MaxLength(20)]
        public string AuthorName { get; set; }



        [Display(Name = "Publisher Name")]
        [MaxLength(40)]
        public string Publishername { get; set; }




        [Required(ErrorMessage = "Date is Required")]
        public DateTime DateTime { get; set; }



        [Display(Name = "Price Of Book")]
        [Required(ErrorMessage = "Price is Required")]
        public string price { get; set; }
    }
}
