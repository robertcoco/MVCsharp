using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCsharp.Models;

namespace MVCsharp.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index()
        {
            var Escuela = new Escuela();
            Escuela.Name = "Escuela Angel Abad";
            Escuela.CreationDate = "2011-10-9";
            Escuela.Id = Guid.NewGuid();
            return View(Escuela);
        }
    }
}
