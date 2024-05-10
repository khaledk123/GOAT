using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Objects
{
    public class Sale :BaseEntity
    {
        [ForeignKey("Product")]
        [Required]
        public  int ProductId { get; set; }

        [Required]
        public virtual Product Product { get; set; }

        [ForeignKey("Seller")]
        [Required]
        public  int SellerId { get; set; }

        [Required]
        public virtual Seller Seller { get; set; }


        [ForeignKey("Customer")]
        [Required]
        public  int CustomerId { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }

        public int? Discount { get; set; }
        public string? DiscountReason { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string? Note { get; set; }
        public int? RemainingPayment { get; set; }

    }
}
