using Microsoft.AspNetCore.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStrore  
        public ActionResult Index()
        {
            return View();
        }
    }
}