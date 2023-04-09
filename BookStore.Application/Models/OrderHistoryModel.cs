using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class OrderHistoryModel
{
    public int HistoryId { get; set; }

    public int? OrderId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? StatusDate { get; set; }

    public virtual CustOrderModel? Order { get; set; }

    public virtual OrderStatusModel? Status { get; set; }
}
