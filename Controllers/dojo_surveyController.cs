
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dojo_survey.Models;
namespace dojo_survey.Controllers
{
    public class dojo_surveyController: Controller
    {
        [HttpGet("")]
   
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("result")]
    
        public IActionResult Result(Survey list)
        {
            return View("Result", list);
        }

        
        [HttpPost]
        [Route("process")]
        public IActionResult PostSurvey(Survey Survey)
        {
            Survey YourSurvey = Survey;

            return View("Result", Survey);
        }
        
    
        
        [HttpGet("result")]
        public IActionResult result(Survey survey)
        {
            return View(survey);
        }
    }


}