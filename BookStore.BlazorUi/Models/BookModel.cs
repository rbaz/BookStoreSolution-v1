namespace BookStore.BlazorUi.Models
{
    public class BookModel
    {
        public int BookId { get; set; }

        public string? Title { get; set; }

        public string? Isbn13 { get; set; }

        public int? LanguageId { get; set; }

        public int? NumPages { get; set; }

        public DateTime? PublicationDate { get; set; }

        public int? PublisherId { get; set; }

        //public virtual BookLanguage? Language { get; set; }

        public virtual ICollection<OrderLineModel>? OrderLines { get; set; }

        //public virtual Publisher? Publisher { get; set; }

        //public virtual ICollection<Author> Authors { get; set; }
    }
}
