namespace CoolerSDK.Models
{
    public class ProductFootprint
    {
        public List<ProductFootprintItem> items { get; set; }
        public string currency { get; set; }
    }

    public class ProductFootprintItem
    {
        public decimal? price { get; set; }
        public string? sku { get; set; }
        public string? store { get; set; }
        public string? externalId { get; set; }
        public string? manufacturer { get; set; }
        public string? title { get; set; }
        public string? category { get; set; }
        public string? zip { get; set; }
        public bool isUsed { get; set; }
    }
}
