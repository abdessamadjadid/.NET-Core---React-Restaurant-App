using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Customer
    {
        [Key]
        private int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CustomerName { get; set; }
    }
}
