using System;
using System.Collections.Generic;

namespace bookStore.Application.Models;

public partial class OrderStatusModel
{
    public int StatusId { get; set; }

    public string? StatusValue { get; set; }

    public virtual ICollection<OrderHistoryModel> OrderHistories { get; set; }
}
