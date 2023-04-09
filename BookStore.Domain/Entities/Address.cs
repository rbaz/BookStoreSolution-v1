using System;
using System.Collections.Generic;

namespace bookStore.Domain.Entities;

public partial class Address
{
    public int AddressId { get; set; }

    public string? StreetNumber { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public int? CountryId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<CustOrder> CustOrders { get; } = new List<CustOrder>();

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; } = new List<CustomerAddress>();
}
