using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ruler.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult CreateProduct() {
            return View();
        }

        public ActionResult CreateProductGroup() {
            return View();
        }
    }
}