namespace LibraryManagement.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int PublicationYear { get; set; }
        public string Category { get; set; } = string.Empty;

        public string ImagePath { get; set; } = "/images/import.png";
    }
}
