using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            ML.Result result = BL.Usuario.UsuarioGetbyUserName(UserName);

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object;

                if (Password == usuario.Password)
                {
                    return RedirectToAction("GetAll");
                }
                else
                {
                    ViewBag.Message = "Contraseña Incorrecta";
                    return PartialView("Modal");
                }
            }
            else
            {
                ViewBag.Message = "El UserName no existe";
                return PartialView("Modal");
            }
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            ML.SuperDigito superDigito = new ML.SuperDigito();
            ML.Result result = BL.SuperDigito.GetAll();


            if (result.Correct)
            {
                superDigito.SuperDigitos = result.Objects;
                return View(superDigito);
            }
            else
            {
                return View(superDigito);
            }
        }

        [HttpPost]
        public ActionResult GetAll(ML.SuperDigito superDigito)
        {

            ML.Result result = BL.SuperDigito.CalcularSDigito(superDigito);
            
            if (result.Correct)
            {

                return View(superDigito);
            }
            else
            {
                return View(superDigito);
            }
        }
    }
}