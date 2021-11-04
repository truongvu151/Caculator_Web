using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTH1_WEB.Models;

namespace BTH1_WEB.Controllers
{
    public class CaculatorController : Controller
    {
        // GET: Caculator
        public ActionResult Index(Expression model)
        {
            return View(model);
        }

        public ActionResult Calculate(Expression model)
        {
            // kiểm chứng
            if (ModelState.IsValid)
            {
                switch (model.Operator)
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
            }
            return RedirectToAction("Index", model);
        }
    }
}