using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class CustomerAddressModel
{
    public int CustomerId { get; set; }

    public int AddressId { get; set; }

    public int? StatusId { get; set; }

    public virtual AddressModel Address { get; set; } = null!;

    public virtual CustomerModel Customer { get; set; } = null!;
}
