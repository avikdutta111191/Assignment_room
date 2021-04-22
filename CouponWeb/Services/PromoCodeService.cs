using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CouponWeb.WebSite.Models;
using Microsoft.AspNetCore.Hosting;

namespace CouponWeb.WebSite.Services
{
    public class PromoCodeService
    {
        public PromoCodeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "testData", "promocodeData.json"); }
        }

        public IEnumerable<PromoCode> GetPromoCodes()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<PromoCode[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}