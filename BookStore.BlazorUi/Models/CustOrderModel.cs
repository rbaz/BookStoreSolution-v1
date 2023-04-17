using System;
using System.Collections.Generic;

namespace BookStore.BlazorUi.Models
{
    public partial class CustOrderModel
    {
        public int OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? CustomerId { get; set; }

        public int? ShippingMethodId { get; set; }

        public int? DestAddressId { get; set; }

        public virtual CustomerModel? Customer { get; set; }

        public virtual AddressModel? DestAddress { get; set; }

        public virtual ICollection<OrderHistoryModel>? OrderHistories { get; set; }

        public virtual ICollection<OrderLineModel>? OrderLines { get; set; }

        public virtual ShippingMethodModel? ShippingMethod { get; set; }
    }
}