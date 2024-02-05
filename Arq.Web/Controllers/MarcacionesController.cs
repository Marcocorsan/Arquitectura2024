using Aplicacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Arq.Web.Controllers
{
    public class MarcacionesController : Controller
    {
        private IMarcacionesRepository repositorio;

        public MarcacionesController(IMarcacionesRepository repo)
        {
            repositorio = repo;
        }

        public IActionResult Index()
        {
            return View(repositorio.Marcaciones);
        }
    }
}
