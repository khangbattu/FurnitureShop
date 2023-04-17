﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.dtos
{
    public class CartItemToAddDto
    {
        public string UserName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int ProductId { get; set; }  
        public int Qty { get; set; }    
    }
}
