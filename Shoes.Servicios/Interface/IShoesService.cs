using Shoes.Entidades;
using Shoes.Entidades.Dto;
using Shoes.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Servicios.Interface
{
    public interface IShoesService
    {
        int GetCantidad(Func<Shoe, bool>? filtro = null);
        void Guardar(Shoe shoe);
        void Borrar(Shoe shoe);
        List<Shoe> GetLista();
        IEnumerable<object> GetListaAnonima();
        bool Existe(Shoe shoe);
        List<ShoeListDto> GetListaDto();
        Shoe? GetShoePorId(int shoeId);
        List<ShoeListDto> GetListaPaginadaOrdenadaFiltrada(int page,
            int pageSize, Orden? orden = null, Brand? brandFiltro = null, Color? colorFiltro = null,
            Genre? genreFiltro = null, Sport? sportFiltro=null);

	}
}
