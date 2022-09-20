using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

        // ramaInt2 - Problema solucionado con merge-git
        //[HttpGet]
        //[Route("GetInfo")]
        //public ActionResult GetInfo()
        //{
            //return Ok("Prueba GetInfo ok");

namespace EjercicioGITBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorController : ControllerBase
    {
        [HttpGet]
        [Route("GetInfo")]

        public ActionResult GetInfo()
        {

            return Ok("Prueba GetInfo Integrante 1 OK");
        }
    }
}
