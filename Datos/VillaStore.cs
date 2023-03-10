using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaLista = new List<VillaDto>
        {
            new VillaDto {Id=1, Nombre="Vista a la Piscina"},
            new VillaDto {Id=2, Nombre="Vista a la Playa"},
            new VillaDto {Id=3, Nombre="Vista a la Terraza"}
        };
    }
}
