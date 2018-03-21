using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class Product
    {
        [Key]

        // Atributo de la tabla 
        public int ProductID { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        // Foreing Key
        public string UserId { get; set; }

        // Objeto del usuario 
        public virtual ApplicationUser User { get; set; }
    }
}