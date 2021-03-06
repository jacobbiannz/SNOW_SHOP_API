﻿using SNOW.SHOP.API.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNOW.SHOP.API.src.Model
{
    public class Promotion : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Rate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Company  Company { get; set; }

        public Product Product { get; set; }
       
        public ICollection<PromotionOrder> AllPromotionOrders { get; set; }
        public ICollection<PromotionProduct> AllPromotionProducts { get; set; }
    }
}
