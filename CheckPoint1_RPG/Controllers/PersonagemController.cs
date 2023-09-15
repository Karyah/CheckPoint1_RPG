using Microsoft.AspNetCore.Mvc;

namespace CheckPoint1_RPG.Controllers
{
    public class PersonagemController : Controller
    {
        [HttpPost]
        public IActionResult Index(string nome, string dataNascimento, string email)
        {
            ViewData["chave"] = "Cadastro de Usuário";
            return View();
        }


    }
}
