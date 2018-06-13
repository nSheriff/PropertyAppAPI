using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyApp.API.Data
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PictureName { get; set; }
        public string Postcode { get; set; }
        public double Price { get; set; }

        public bool PropertyIsDeleted{ get; set; }

    }
}
