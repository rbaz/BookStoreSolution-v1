using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class CustomerModel
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<CustOrderModel>? CustOrders { get; set; } 

    public virtual ICollection<CustomerAddressModel>? CustomerAddresses { get; set; }
}
