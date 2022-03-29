using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public long OrderMasterId { get; set; }
        public OrderMaster orderMaster { get; set; }

        public int FoodItemId { get; set; }
        public FoodItem foodItem { get; set; }

        public decimal FoodItemPrice { get; set; }

        public int Quantity { get; set; }

    }
}
