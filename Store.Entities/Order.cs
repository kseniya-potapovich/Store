﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int userId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
