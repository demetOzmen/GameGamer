using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : Controller
    {
        private ICampaignService _campaignService;
        public CampaignsController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
