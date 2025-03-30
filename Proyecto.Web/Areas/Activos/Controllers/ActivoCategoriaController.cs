using Microsoft.AspNetCore.Mvc;
using Proyecto.Aplicacion.Interfaces;
using Proyecto.Core.DTOs;
using Proyecto.Core.Entidades;
using Proyecto.Web.ViewModels;

namespace Proyecto.Web.Areas.Activos.Controllers
{
    [Area("Activos")]
    public class ActivoCategoriaController : Controller
    {

        private readonly IActivosService _activosService;
        
        public ActivoCategoriaController(IActivosService activosService) 
        { 
            _activosService = activosService;
        }

        public async Task<IActionResult> Index()
        {

            IEnumerable<CategoriaActivosModel> listado = await _activosService.ObtenerListadoCategoriasActivos();
            var viewModel = new ListadoCategoriasActivos
            {
                Categorias = listado,
            };

            return View(viewModel);
        }
        [HttpGet]

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CategoriaActivosModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _activosService.CrearCategoriaAsync(model);
            TempData["SuccessMessage"] = "La categoría ha sido creada exitosamente";
            return RedirectToAction("Index");
            
        }


    }
}
