using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class CountryModel
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<AddressModel> Addresses { get; } = new List<AddressModel>();
}
