using CodingTest.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodingTest.Controllers
{
    public class AjaxController : Controller
    {
        public AjaxController(IViewRenderService viewRenderService)
        {
            _viewRenderService = viewRenderService;
        }

        private readonly IViewRenderService _viewRenderService;
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Data()
        {          
            var partialView  = PartialView();
            var result = await _viewRenderService.RenderToStringAsync("Ajax/Data", null);
            return Json(result);
        }
    }
}