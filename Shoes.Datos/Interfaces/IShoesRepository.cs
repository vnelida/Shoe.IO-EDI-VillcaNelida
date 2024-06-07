using Shoes.Entidades;
using Shoes.Entidades.Dto;
using Shoes.Entidades.Enums;

namespace Shoes.Datos.Interfaces
{
	public interface IShoesRepository
	{
		void Agregar(Shoe shoe);
		void Borrar(Shoe shoe);
		void Editar(Shoe shoe);
		bool Existe(Shoe shoe);
		int GetCantidad(Func<Shoe, bool>? filtro);
		List<Shoe> GetLista();
		List<ShoeListDto> GetListaDto();
		List<ShoeListDto> GetListaPaginadaOrdenadaFiltrada(int page, int pageSize, Orden? orden, Brand? brandFiltro, Color? colorFiltro, Genre? genreFiltro, Sport? sportFiltro);
		Shoe? GetShoePorId(int shoeId);
	}
}
