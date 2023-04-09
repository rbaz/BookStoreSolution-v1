using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class OrderLineModel
{
    public int LineId { get; set; }

    public int? OrderId { get; set; }

    public int? BookId { get; set; }

    public decimal? Price { get; set; }

    public virtual BookModel? Book { get; set; }

    public virtual CustOrderModel? Order { get; set; }
}
