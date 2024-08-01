using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.Servicios.Interface;
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Helpers
{
	public static class ListBoxHelper
	{
		private static IServiceProvider? _serviceProvider;
		public static void CargarDatosListBoxSizes(IServiceProvider? serviceProvider,
			ref CheckedListBox lst)
		{
			_serviceProvider = serviceProvider;
			ISizeService? servicio = _serviceProvider?.GetService<ISizeService>();
			var lista = servicio?.GetLista();
			if (lista != null)
			{

				foreach (var size in lista)
				{
					lst.Items.Add(size);
				}
				lst.DisplayMember = "SizeNumber";
				
				
			}
		}
	}
}
