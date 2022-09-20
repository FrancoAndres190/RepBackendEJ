using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return Ok("Prueba GetInfo ok");
        }
    }
}
