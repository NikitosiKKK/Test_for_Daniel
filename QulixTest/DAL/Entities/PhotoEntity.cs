namespace DAL.Entities
{
    public class PhotoEntity
    {
        public int Id { get; set; }
        public int? AuthorId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public int? Price { get; set; }
        public int? Purchases { get; set; }
        public int? Rating { get; set; }
    }
}
