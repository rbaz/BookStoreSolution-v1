using System;
using System.Collections.Generic;

namespace BookStore.Infrastrcuture.TempModels;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
