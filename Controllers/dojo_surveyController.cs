
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace FirstWeb.Controllers
{
    public class dojo_surveyController: Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        [HttpPost]
        [Route("result")]
        public IActionResult result(string name, string location, string programlang, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.programlang = programlang;
            ViewBag.comment = comment;  
            return View("result");
        }
    }


}