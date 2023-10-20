namespace CoolerSDK.Models
{
    public class ResponsePayload
    {
        public string id { get; set; }
        public string platform { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
        public ResponseItem[] items { get; set; }
    }

    public class ResponseItem
    {
        public string id { get; set; }
        public string statusFootprint { get; set; }
        //public object statusNeutralization { get; set; }
        public string externalId { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
        public DateTime dateFootprinted { get; set; }
        //public object dateNeutralized { get; set; }
        public ResponseSubmission submission { get; set; }
        public ResponseFootprint footprint { get; set; }
    }

    public class ResponseSubmission
    {
        public string id { get; set; }
        public decimal price { get; set; }
        public string currency { get; set; }
        public string manufacturer { get; set; }
        public bool isUsed { get; set; }
        public int quantity { get; set; }
        public DateTime dateCreated { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string store { get; set; }
        public string category { get; set; }
        public string zip { get; set; }
        public string sku { get; set; }
    }

    public class ResponseFootprint
    {
        public string id { get; set; }
        public string method { get; set; }
        public string currency { get; set; }
        public string version { get; set; }
        public decimal carbonFootprint { get; set; }
        public decimal? carbonFootprintCradleToShelf { get; set; }
        public decimal? carbonFootprintRetailOnly { get; set; }
        public decimal? carbonFootprintSavings { get; set; }
        public decimal? carbonFootprintPerDollar { get; set; }
        public string dateCreated { get; set; }
        public string dateUpdated { get; set; }
        public string expiresAt { get; set; }
    }
}
