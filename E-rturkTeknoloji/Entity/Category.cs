using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_rturkTeknoloji.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(maximumLength:20,ErrorMessage = "Name must be maximum 20 characters")]
        public string Name { get; set; }
        [StringLength(maximumLength: 250, ErrorMessage = "Description must be maximum 250 characters")]
        public string Description { get; set; }

        public List<Product> products { get; set; }
    }
}