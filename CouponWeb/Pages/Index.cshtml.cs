using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CouponWeb.WebSite.Services;
using CouponWeb.WebSite.Models;


namespace CouponWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public PromoCodeService _promoCodeService;

        public IEnumerable<PromoCode> promoCodes {get; private set;}
        public IndexModel(ILogger<IndexModel> logger,PromoCodeService promoCodeService)
        {
            _logger = logger;
            _promoCodeService=promoCodeService;
        }

        public void OnGet()
        {
            promoCodes=_promoCodeService.GetPromoCodes();

        }
    }
}
