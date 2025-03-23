namespace netcore_sample_repository_pattern.Model
{
    // Entity
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? StockCode { get; set; }
    }
}
