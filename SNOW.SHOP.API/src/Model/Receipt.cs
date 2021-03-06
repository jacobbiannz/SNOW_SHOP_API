﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNOW.SHOP.API.src.Model
{
    public class Receipt : Entity
    {
        public decimal Amount { get; set; }

        public Order Order { get; set; }

        public PaymentType PaymentType { get; set; }
    }
}
