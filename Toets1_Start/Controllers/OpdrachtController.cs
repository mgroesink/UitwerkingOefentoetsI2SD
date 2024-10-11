using I1SD_Toets1_Start;
using Microsoft.AspNetCore.Mvc;

namespace Toets1_Start.Controllers
{
    public class OpdrachtController : Controller
    {
        public IActionResult Opdracht1()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Opdracht1(int maxnumber)
        {
            ViewBag.MaxNumber = maxnumber;
            try
            {
                var tupels = MyFunctions.GetNumberSequence(maxnumber);
                return View(tupels);
            }
            catch (ArgumentException ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View();
        }

    }
}
