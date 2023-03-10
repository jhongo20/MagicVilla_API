using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;
using MagicVilla_API.Datos;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villaLista;
        }

        [HttpGet("id:int")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.villaLista.FirstOrDefault(v => v.Id==id);
        }

    }
}
