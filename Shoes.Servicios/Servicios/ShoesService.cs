using Shoes.Datos;
using Shoes.Datos.Interfaces;
using Shoes.Entidades;
using Shoes.Entidades.Dto;
using Shoes.Entidades.Enums;
using Shoes.Servicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Servicios.Servicios
{
    public class ShoesService : IShoesService
    {
        private readonly IShoesRepository repository;
        private readonly IUnitOfWork _unitOfWork;

		public ShoesService(IShoesRepository _repository, IUnitOfWork unitOfWork)
        {
             repository = _repository;
            _unitOfWork = unitOfWork;
        }
        public void Borrar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                repository.Borrar(shoe);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
				_unitOfWork?.Rollback();
				throw;
            }

        }

        public bool Existe(Shoe shoe)
        {
            return repository.Existe(shoe);
        }

        public int GetCantidad(Func<Shoe, bool>? filtro = null)
        {
            return repository.GetCantidad(filtro);
        }

        public List<Shoe> GetLista()
        {
            return repository.GetLista();
        }

        public IEnumerable<object> GetListaAnonima()
        {
            throw new NotImplementedException();
        }

        public List<ShoeListDto> GetListaDto()
        {
            return repository.GetListaDto();
        }

		public List<ShoeListDto> GetListaPaginadaOrdenadaFiltrada(int page, int pageSize, Orden? orden = null, Brand? brandFiltro = null, Color? colorFiltro = null, Genre? genreFiltro = null, Sport? sportFiltro = null)
		{
			return repository.GetListaPaginadaOrdenadaFiltrada(page, pageSize,
			   orden, brandFiltro, colorFiltro, genreFiltro, sportFiltro);
		}

		public Shoe? GetShoePorId(int shoeId)
        {
            return repository.GetShoePorId(shoeId);
        }

        public void Guardar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
				if (shoe.ShoeId == 0)
				{
					repository.Agregar(shoe);
				}
				else
				{
					repository.Editar(shoe);
				}
				_unitOfWork.Commit();
			}
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
            
        }
    }
}
