﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Entity
{
   public  class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

