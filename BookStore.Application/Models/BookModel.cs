using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace bookStore.Application.Models;

public partial class BookModel
{
    [JsonIgnore]
    public int BookId { get; set; }
    [JsonIgnore]
    public string? Title { get; set; }
    [JsonIgnore]
    public string? Isbn13 { get; set; }
    [JsonIgnore]
    public int? LanguageId { get; set; }
    [JsonIgnore]
    public int? NumPages { get; set; }
    [JsonIgnore]
    public DateTime? PublicationDate { get; set; }
    [JsonIgnore]
    public int? PublisherId { get; set; }
    [JsonIgnore]
    public virtual BookLanguageModel? Language { get; set; }
    [JsonIgnore]
    public virtual ICollection<OrderLineModel>? OrderLines { get; set; }
    [JsonIgnore]
    public virtual PublisherModel? Publisher { get; set; }
    [JsonIgnore]
    public virtual ICollection<AuthorModel>? Authors { get; set; }
}
