﻿using System;
using System.Collections.Generic;

namespace bookStore.Domain.Entities;

public partial class CustOrder
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? CustomerId { get; set; }

    public int? ShippingMethodId { get; set; }

    public int? DestAddressId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Address? DestAddress { get; set; }

    public virtual ICollection<OrderHistory> OrderHistories { get; } = new List<OrderHistory>();

    public virtual ICollection<OrderLine> OrderLines { get; } = new List<OrderLine>();

    public virtual ShippingMethod? ShippingMethod { get; set; }
}
