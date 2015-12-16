using System.Web.Mvc;
using Fillwords.BLL;
using Fillwords.WebApp.ViewModels;

namespace Fillwords.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public const string Name = "Home";

        public const string DefaultAction = "index";
        public const string CheckWordAction = "checkword";

        [HttpGet]
        [ActionName(DefaultAction)]
        public ActionResult Index()
        {
            var model = new GameFieldPage
            {
                GameField = GameFieldManager.Get()
            };

            return View(model);
        }

        [HttpPost]
        [ActionName(CheckWordAction)]
        public JsonResult CheckWord(string word)
        {
            try
            {
                var checkResult = GameFieldManager.CheckWord(word);

                switch (checkResult)
                {
                    case CheckWordResult.Correct:
                        return Json(new
                        {
                            success = true,
                            message = ""
                        });

                    default:
                        return Json(new
                        {
                            success = true,
                            messgae = "Incorrect"
                        });
                }
            }
            catch
            {
                return Json(new
                {
                    success = false,
                    message = "Произошла непредвиденная ошибка"
                });
            }
        }
    }
}