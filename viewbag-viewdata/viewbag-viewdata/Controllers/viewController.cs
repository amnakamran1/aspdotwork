using Microsoft.AspNetCore.Mvc;
using viewbag_viewdata.Models;

namespace viewbag_viewdata.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult view()
        {
            ViewBag.message = "Data come from view bag";
            ViewData["messages2"] = "Data come from view data";
            ViewBag.CurrentDate = DateTime.Now.ToString();
            ViewData["CurrentDate"] = DateTime.Now.ToLongDateString();

            string[] games = { "Cricket", "Football", "Hockey", "Baskitball" };
            ViewBag.games1 = games;
            ViewData["games2"] = games;

            Student Amna = new Student();
            Amna.StdId = 1;
            Amna.StdName = "Amna kamran";
            Amna.StdAddress = "Sector 5d";
            ViewBag.Amnak = Amna;
            ViewData["AmnaKamran"]=Amna;


            return View();
        }
    }
}
