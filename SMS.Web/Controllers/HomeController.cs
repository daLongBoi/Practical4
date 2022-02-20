using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.LongTime= DateTime.Now.ToLongDateString();
       var index = new IndexViewModel {
        Message = "ERROR 243 PLEASE RELOAD WEBPAGE"
       };
        return View(index);
    }
    public IActionResult About() 
    {
   var about = new AboutViewModel {
       Title ="About",
       Message = "our mission is to develop grat solutions for education etc ",
       Formed =  new DateTime(2020,01,01) 
   };    
         // render the view
          return View(about);
     } 

    public IActionResult Privacy()
    {
        return View();
    }

}
