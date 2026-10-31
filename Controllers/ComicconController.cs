using Microsoft.AspNetCore.Mvc;
using Seg3.Models;

namespace Seg3.Controllers
{
    public class ComicConController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AsistenteComicCon asistente)
        {
            if (ModelState.IsValid)
            {
                string cosplayTexto = asistente.ParticipaCosplay ? "¡Genial! Estás inscrito en el concurso de Cosplay." : "Asistente general sin concurso de Cosplay.";
                
                asistente.MensajeConfirmacion = $"¡Registro exitoso para la Comic-Con, {asistente.Nombre}! Tu entrada tipo **{asistente.TipoEntrada}** ha sido procesada. {cosplayTexto}";

                return View("Resultado", asistente);
            }

            return View(asistente);
        }

        [HttpGet]
        public IActionResult Resultado(AsistenteComicCon asistente)
        {
            return View(asistente);
        }
    }
}