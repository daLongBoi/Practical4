using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About() 
    {
     
        var formed = new DateTime(2020, 01, 01);
        var days = DateTime.Now.Subtract(formed).Days;
               
        //add Strongly typed values to viewbag
        ViewBag.Formed = formed;
        ViewBag.Days = days;

   return View();

         // render the view
          return View();
     } 

    public IActionResult Privacy()
    {
        return View();
    }

}
