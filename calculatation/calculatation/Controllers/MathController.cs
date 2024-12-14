using Microsoft.AspNetCore.Mvc;

namespace calculatation.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection obj)
        {
            try
            {
                int num1 = Convert.ToInt32(obj["txtnum1"]);
                int num2 = Convert.ToInt32(obj["txtnum2"]);
                string operation = obj["operation"];

                string result = string.Empty;

                switch (operation)
                {
                    case "Add":
                        result = $"The sum is {num1 + num2}";
                        break;

                    case "Subtract":
                        result = $"The difference is {num1 - num2}";
                        break;

                    case "Multiply":
                        result = $"The product is {num1 * num2}";
                        break;

                    case "Divide":
                        if (num2 != 0)
                            result = $"The quotient is {num1 / num2}";
                        else
                            result = "Division by zero is not allowed.";
                        break;

                    default:
                        result = "Invalid operation selected.";
                        break;
                }

                ViewBag.data = result;
            }
            catch (Exception ex)
            {
                ViewBag.data = "Error: " + ex.Message;
            }

            return View();
        }

    }
}
