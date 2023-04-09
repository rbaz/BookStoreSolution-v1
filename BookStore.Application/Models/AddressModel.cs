using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class AddressModel
{
    public int AddressId { get; set; }

    public string? StreetNumber { get; set; }

    public string? StreetName { get; set; }

    public string? City { get; set; }

    public int? CountryId { get; set; }

    public virtual CountryModel? Country { get; set; }

    public virtual ICollection<CustOrderModel> CustOrders { get; } = new List<CustOrderModel>();

    public virtual ICollection<CustomerAddressModel> CustomerAddresses { get; } = new List<CustomerAddressModel>();
}
