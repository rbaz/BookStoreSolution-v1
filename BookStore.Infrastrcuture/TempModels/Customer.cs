using System;
using System.Collections.Generic;

namespace BookStore.Infrastrcuture.TempModels;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<CustOrder> CustOrders { get; } = new List<CustOrder>();

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; } = new List<CustomerAddress>();
}
