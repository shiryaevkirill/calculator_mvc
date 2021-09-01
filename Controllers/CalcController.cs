using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1b.Models;

namespace task1b.Controllers
{
    public class CalcController : Controller
    {
        static string temp;
        static string num;
        static string action = "";

        public ActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]

        public ActionResult Index(Calc calc, string calcbtn)
        {
            if (num == "error")
            {
                num = "";
                action = "";
                temp = "";
            }
            try
            {
                switch (calcbtn)
                {
                    case "btn-1":
                    case "btn-2":
                    case "btn-3":
                    case "btn-4":
                    case "btn-5":
                    case "btn-6":
                    case "btn-7":
                    case "btn-8":
                    case "btn-9":
                    case "btn-0":
                        num += calcbtn.Substring(4);
                        break;
                    case "btn-point":
                        num += ",";
                        break;
                    case "btn-plus":
                        ActionHelper();
                        action = "+";
                        ActionClear();
                        break;
                    case "btn-minus":
                        ActionHelper();
                        action = "-";
                        ActionClear();
                        break;
                    case "btn-mult":
                        ActionHelper();
                        action = "*";
                        ActionClear();
                        break;
                    case "btn-div":
                        ActionHelper();
                        action = "/";
                        ActionClear();
                        break;
                    case "btn-C":
                        action = "";
                        num = "";
                        temp = "";
                        break;
                    case "btn-eq":
                        if (num == "") { num = temp; }
                        else ActionHelper();
                        break;
                }
            }
            catch
            {
                num = "error";
            }

            calc.number = num;

            return View(calc);
        }

        private void ActionClear()
        {
            temp = num;
            num = "";
        }

        private void ActionHelper()
        {
            if (action != "")
            {
                switch (action)
                {
                    case "+":
                        num = Convert.ToString(Convert.ToDouble(temp) + Convert.ToDouble(num));
                        break;
                    case "-":
                        num = Convert.ToString(Convert.ToDouble(temp) - Convert.ToDouble(num));
                        break;
                    case "*":
                        num = Convert.ToString(Convert.ToDouble(temp) * Convert.ToDouble(num));
                        break;
                    case "/":
                        if (num == "0") num = "error";
                        else num = Convert.ToString(Convert.ToDouble(temp) / Convert.ToDouble(num));
                        break;
                }

                action = "";
                temp = "";
            }
        }

    }
}
