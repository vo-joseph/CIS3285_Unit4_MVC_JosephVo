using Microsoft.AspNetCore.Mvc;

namespace Unit4_MVC_JosephVo.Controllers
{
    public class HelloController : Controller
    {
        // GET: HelloController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MNController
        public ActionResult MN()
        {
            return View();
        }

        // GET: WIController
        public ActionResult WI()
        {
            return View();
        }
    }
}
