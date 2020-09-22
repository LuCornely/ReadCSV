using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadCSV.Data;
using ReadCSV.Models;

namespace ReadCSV.Controllers
{
    public class LoginController : Controller
    {
        private readonly CadastroContext db;

        public LoginController(CadastroContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Acesso cadastros)
        {
            var user = db.Cadastros.Where(x => x.Login == cadastros.Login && x.Password == cadastros.Password).FirstOrDefault();

            if (user == null)
            {
                //usuário não identificado
                ViewData["msgUsuario"] = "usuario nao identificado";
            }
            else
            {
                var usuariobanco = user;

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
 
        
    }
}
