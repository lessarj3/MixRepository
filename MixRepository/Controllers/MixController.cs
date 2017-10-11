using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations; /*This loads the validation features*/

namespace MixRepository.Controllers
{
    public class MixController : Controller
    {
        // GET: Mix
        public ActionResult Index()
        {
            return View();
        }

    }
}