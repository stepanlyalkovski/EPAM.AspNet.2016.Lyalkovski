using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JsonService.Controllers
{
    public class ServiceController : Controller
    {
        public JsonResult Index()
        {
            var user = new {name = "Ivan", Age = 20};
            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}
