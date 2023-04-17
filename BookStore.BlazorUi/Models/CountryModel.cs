using System;
using System.Collections.Generic;

namespace BookStore.BlazorUi.Models
{
    public partial class CountryModel
    {
        public int CountryId { get; set; }

        public string? CountryName { get; set; }

        public virtual ICollection<AddressModel>? Addresses { get; set; }
    }
}