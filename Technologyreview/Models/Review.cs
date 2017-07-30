using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Technologyreview.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name ="Memory Size GB:")]
        public int memSize { get; set; }
        [Display(Name = "HardDrive Size GB:")]
        public int HardDrSize { get; set; }
        [Display(Name = "Laptop Make:")]
        public string Make { get; set; }
        [Display(Name = "Laptop Model:")]
        public string Model { get; set; }
        [Display(Name = "Laptop Manufacturer")]
        public string Manufacture { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Enter Your Review")]
        public string CustReview { get; set; }
        [Display(Name = "Todays Date")]
        public DateTime ReviewDate { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Brand")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}