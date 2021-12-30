using INF_URETIMTAKIP_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF_URETIMTAKIP_MVC.Controllers
{
    public class UretimController : Controller
    {
        // GET: Uretim
        private INF_URETIMTAKIP_Manager infUrttkp_Manager = new INF_URETIMTAKIP_Manager();
        public ActionResult Index()
        {
            var liste=infUrttkp_Manager.isList();
            return View(liste);
        }
    }
}