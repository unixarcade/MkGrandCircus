using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlLabFour.Models;

namespace HtmlLabFour.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index(WorkshopModel model)
        {            
            return View(model);
        }
    }
}