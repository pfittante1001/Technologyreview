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
        public int memSize { get; set; }
        public int HardDrSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Manufacture { get; set; }
        public string CustReview { get; set; }
        public DateTime ReviewDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}