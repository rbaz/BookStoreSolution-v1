using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace bookStore.Application.Models;

public partial class CountryModel
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }
    [JsonIgnore]
    public virtual ICollection<AddressModel>? Addresses { get; set; }
}
