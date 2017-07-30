using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Technologyreview.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Brand")]
        public int CategoryID { get; set; }
        public string Brand { get; set; }

        public ICollection<Review> Reviews { get; set; }

    }
}