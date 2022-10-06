using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("api/tipocondiciones")]
    [ApiController]
    public class TipoCondicionesController : ControllerBase
    {
        private readonly ITiposCondiciones _ITiposCondiciones;
        public TipoCondicionesController(ITiposCondiciones ITiposCondiciones)
        {
            _ITiposCondiciones = ITiposCondiciones;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposCondiciones>>> Get()
        {
            return await Task.FromResult(_ITiposCondiciones.GetTiposCondiciones());
        }
    }
}
