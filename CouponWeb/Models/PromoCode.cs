using System.Text.Json;
using System.Text.Json.Serialization;


namespace CouponWeb.WebSite.Models
{
    public class PromoCode
    {
        public string website { get; set; }
        public string promocode { get; set; }

        public string description { get; set; }

        public string title { get; set; }

        public string Url { get; set; }

         
        [JsonPropertyName("img")]
        public string Image { get; set; } 
        public int amount { get; set; }
        public int maxCount { get; set; }

        public override string ToString() => JsonSerializer.Serialize<PromoCode>(this);
        
    }
}