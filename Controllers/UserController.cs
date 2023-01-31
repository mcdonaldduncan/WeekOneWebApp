using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static WeekOneWebApp.QuoteGenerator.QuoteGenerator;

namespace WeekOneWebApp.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Assign ViewBag values and return view
        /// </summary>
        /// <param name="_yearOfBirth"></param>
        /// <param name="_quote"></param>
        /// <param name="_firstName"></param>
        /// <param name="_lastName"></param>
        /// <param name="_age"></param>
        /// <param name="_occupation"></param>
        /// <returns></returns>
        public IActionResult Result(int _yearOfBirth, string _quote, string _firstName, string _lastName, int _age, string _occupation)
        {
            ViewBag.YearOfBirth = _yearOfBirth;
            ViewBag.Quote = _quote;
            ViewBag.FirstName = _firstName;
            ViewBag.LastName = _lastName;
            ViewBag.Age = _age;
            ViewBag.Occupation = _occupation;

            return View();
        }

        /// <summary>
        /// Take form input and calculate aproximate year before redirecting to Result with necessary values
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                int yearOfBirth = -1;
                // TryParse is not really necessary here because the form allows number entry only but I left it in as best practice
                if (Int32.TryParse(collection["Age"], out int age))
                {
                    yearOfBirth = DateTime.Now.Year - age;
                }

                return RedirectToAction(nameof(Result), new {
                    _yearOfBirth = yearOfBirth,
                    _quote = GetRandomQuote(),
                    _firstName = collection["FirstName"],
                    _lastName = collection["LastName"],
                    _age = age,
                    _occupation = collection["Occupation"]
                });
            }
            catch
            {
                return View();
            }
            
        }

    }
}
