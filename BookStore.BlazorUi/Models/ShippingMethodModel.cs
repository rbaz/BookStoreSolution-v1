﻿using System;
using System.Collections.Generic;

namespace BookStore.BlazorUi.Models
{
    public partial class ShippingMethodModel
    {
        public int MethodId { get; set; }

        public string? MethodName { get; set; }

        public decimal? Cost { get; set; }

        public virtual ICollection<CustOrderModel>? CustOrders { get; set; }
    }
}