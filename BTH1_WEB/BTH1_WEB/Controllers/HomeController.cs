using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTH1_WEB.Models;

namespace BTH1_WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Expression model)
        {
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(Expression model, string command)
        {
            // kiểm chứng
            if (ModelState.IsValid)
            {
                switch (command)
                {
                    case "+": model.Result = model.Number1 + model.Number2; break;
                    case "-": model.Result = model.Number1 - model.Number2; break;
                    case "x": model.Result = model.Number1 * model.Number2; break;
                    case "/":
                        if (model.Number2 != 0)
                        {
                            model.Result = model.Number1 / model.Number2;
                            model.Error = "";
                        }
                        else
                            model.Error = "Lỗi chia 0";
                        break;
                }
                //return View();
                //return RedirectToAction("Index", model);
            }
            return View(model);

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}