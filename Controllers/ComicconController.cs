using Microsoft.AspNetCore.Mvc;
using Seg3.Models;

namespace Seg3.Controllers
{
    public class ComicConController : Controller
    {
        // GET: /ComicCon/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /ComicCon/Index
        [HttpPost]
        public IActionResult Index(AsistenteComicCon asistente)
        {
            if (ModelState.IsValid)
            {
                // Procesamiento de información mediante C# enfocado en la temática Comic-Con
                string cosplayTexto = asistente.ParticipaCosplay ? "¡Genial! Estás inscrito en el concurso de Cosplay." : "Asistente general sin concurso de Cosplay.";
                
                asistente.MensajeConfirmacion = $"¡Registro exitoso para la Comic-Con, {asistente.Nombre}! Tu entrada tipo **{asistente.TipoEntrada}** ha sido procesada. {cosplayTexto}";

                return View("Resultado", asistente);
            }

            return View(asistente);
        }

        // GET: /ComicCon/Resultado
        [HttpGet]
        public IActionResult Resultado(AsistenteComicCon asistente)
        {
            return View(asistente);
        }
    }
}