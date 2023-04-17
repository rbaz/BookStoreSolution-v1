using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace bookStore.Application.Models;

public partial class OrderLineModel
{
    public int LineId { get; set; }

    public int? OrderId { get; set; }

    public int? BookId { get; set; }

    public decimal? Price { get; set; }
    [JsonIgnore]
    public virtual BookModel? Book { get; set; }
    [JsonIgnore]
    public virtual CustOrderModel? Order { get; set; }
}
