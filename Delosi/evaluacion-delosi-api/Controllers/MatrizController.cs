using Delosi.BL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace evaluacion_delosi_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatrizController : ControllerBase
    {
        private readonly IMatrizServices _matrizServices;

        public MatrizController(IMatrizServices matrizServices) {
            _matrizServices = matrizServices;
        }

        [HttpPost]
        public IActionResult RotarMatriz([FromBody] int[][] request)
        {
            if (request == null || request.Length == 0)
            {
                return BadRequest("Los datos ingresados no son válidos.");
            }

            try
            {
                var response = _matrizServices.RotarMatriz(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
