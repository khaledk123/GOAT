using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Product : BaseEntity
    {
        [Required]
        public string Serial { get; set; }


        [Required]
        public required string Name { get; set; } 

        public string? Description { get; set; } 


        [ForeignKey("Category")]
        [Required]
        public  int CategoryID { get; set; }

        [Required]
        public virtual Category Category { get; set; }  


        [Required]
        public  string ImagePath { get; set; } 
        

        [Required]
        public int Stock { get; set; }  


        [Required]
        public int Price { get; set; }  


        [Required]
        public  string Size { get; set; }  

        public string? Colors { get; set; }  
    }
}
