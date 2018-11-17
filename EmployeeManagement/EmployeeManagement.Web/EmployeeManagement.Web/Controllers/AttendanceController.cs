using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emp.Web.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            String msg = "";
            if (DateTime.Now.Hour < 12)
            {
                msg = "Good Morning";
            }
            else if (DateTime.Now.Hour < 17)
            {
                msg = "Good Afternoon";
            }
            else
            {
                msg = "Good Evening";
            }
            ViewBag.Messege = msg;
            return View();
        }

    }
}
