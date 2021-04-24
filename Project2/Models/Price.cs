using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Price
    {
        

        [Required]
        [Range(0, Double.PositiveInfinity, ErrorMessage = "Please enter a subtotal greater than 0.")]
        [Display(Name = "Subtotal:")]
        public double Subtotal { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a discount between {1} and {2}.")]
        [Display(Name = "Discount percent:")]
        public double DiscountPercent { get; set; }

        [Display(Name = "Discount amount:")]
        public double DiscountAmount { get; set; }

        [Display(Name = "Total:")]
        public double Total { get; set; }

        public void CalculateTotal()
        {
            DiscountAmount = Subtotal * (DiscountPercent / 100);
            Total = Subtotal - DiscountAmount;
        }

        public string GetDiscountAmount()
        {
            return DiscountAmount.ToString("C");
        }

        public string GetTotal()
        {
            return Total.ToString("C");
        }
    }
}
