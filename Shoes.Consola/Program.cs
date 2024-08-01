using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.Entidades.Dto;
using Shoes.IOC;
using Shoes.Servicios.Interface;
using Shoes.Shared;

namespace Shoes.Consola
{
	internal class Program

	{
		private static IServiceProvider? serviceProvider;
		static int pageSize = 15;
		static void Main(string[] args)
		{
			serviceProvider = DI.ConfigurarServicio();

			bool exit = false;
			while (!exit)
			{
				Console.Clear();
				Console.WriteLine("Menú Principal:");

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("1. Listado de colores");
				Console.WriteLine("2. Ingresar un nuevo color");
				Console.WriteLine("3. Borrar un color");
				Console.WriteLine("4. Editar un color");

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("10. Listado de marcas");
				Console.WriteLine("11. Ingresar una marca nueva");
				Console.WriteLine("12. Borrar una marca");
				Console.WriteLine("13. Editar una marca");
				Console.WriteLine("14. Zapatillas agrupadas por genero");

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("20. Listado de generos");
				Console.WriteLine("21. Ingreso de un nuevo genero");
				Console.WriteLine("22. Eliminar genero");
				Console.WriteLine("23. Editar genero");
				Console.WriteLine("24. Zapatillas agrupadas por genero");

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("30. Listado de deportes");
				Console.WriteLine("31. Ingresar un nuevo deporte");
				Console.WriteLine("32. Borrar un deporte");
				Console.WriteLine("33. Editar deporte");

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("40. Listado de zapatillas");
				Console.WriteLine("41. Ingresar una nueva zapatillas");
				Console.WriteLine("42. Borrar un zapatilla");
				Console.WriteLine("43. Editar un zapatilla");
				Console.WriteLine("44. Agregar talles a un artiiculo");
				Console.WriteLine("45. Agregar zapatillas con talle");
				Console.WriteLine("46. Ver talles por articulo");
				Console.WriteLine("47. Agregar talles-stock");

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("50. Listado de talles");
				Console.WriteLine("51. Ingresar un nuevo talle");
				Console.WriteLine("52. Borrar un talle");
				Console.WriteLine("53. Editar un talle");
				Console.WriteLine("54. Ver zapatillas por talle");

				Console.WriteLine("x. Salir");

				Console.Write("Por favor, seleccione una opción: ");
				string? input = Console.ReadLine();

				switch (input)
				{
					case "1":
						Console.Clear();
						//ListadoColores();
						ListColorPag();
						ConsoleExtensions.EsperaEnter();
						break;
					case "2":
						Console.Clear();
						NuevoColor();
						ConsoleExtensions.EsperaEnter();
						break;
					case "3":
						Console.Clear();
						BorrarColor();
						ConsoleExtensions.EsperaEnter();
						break;
					case "4":
						Console.Clear();
						EditarColor();
						ConsoleExtensions.EsperaEnter();
						break;
					case "5":
						break;


					case "10":
						Console.Clear();
						ListBrandsPag();
						//ListadoDeMarcas();
						ConsoleExtensions.EsperaEnter();
						break;
					case "11":
						Console.Clear();
						NuevaMarca();
						ConsoleExtensions.EsperaEnter();
						break;
					case "12":
						Console.Clear();
						BorrarMarca();
						ConsoleExtensions.EsperaEnter();
						break;
					case "13":
						Console.Clear();
						EditarMarca();
						ConsoleExtensions.EsperaEnter();
						break;
					case "14":
						Console.Clear();
						AgruparPorMarca();
						ConsoleExtensions.EsperaEnter();
						break;


					case "20":
						Console.Clear();
						//ListGenrePag();
						ListadoDeGeneros();
						ConsoleExtensions.EsperaEnter();
						break;
					case "21":
						Console.Clear();
						NuevoGenero();
						ConsoleExtensions.EsperaEnter();
						break;
					case "22":
						Console.Clear();
						BorrarGenero();
						ConsoleExtensions.EsperaEnter();
						break;
					case "23":
						Console.Clear();
						EditarGenero();
						ConsoleExtensions.EsperaEnter();
						break;
					case "24":
						Console.Clear();
						AgruparPorGenero();
						ConsoleExtensions.EsperaEnter();
						break;


					case "30":
						Console.Clear();
						ListSportPag();
						//ListadoDeSport();
						ConsoleExtensions.EsperaEnter();
						break;
					case "31":
						Console.Clear();
						NuevoSport();
						ConsoleExtensions.EsperaEnter();
						break;
					case "32":
						Console.Clear();
						BorrarSport();
						ConsoleExtensions.EsperaEnter();
						break;
					case "33":
						Console.Clear();
						EditarSport();
						ConsoleExtensions.EsperaEnter();
						break;
					case "34":
						break;
					case "35":


						break;
					case "40":
						Console.Clear();
						//ListShoes();
						ListaShoesPaginada();
						ConsoleExtensions.EsperaEnter();
						break;
					case "41":
						Console.Clear();
						AgregarShoe();
						ConsoleExtensions.EsperaEnter();
						break;
					case "42":
						Console.Clear();
						BorrarShoe();
						ConsoleExtensions.EsperaEnter();
						break;
					case "43":
						Console.Clear();
						EditarShoe();
						ConsoleExtensions.EsperaEnter();
						break;
					case "44":
						Console.Clear();
						AsignarSizeShoe();
						ConsoleExtensions.EsperaEnter();
						break;
					case "45":
						Console.Clear();
						NuevoShoeNuevoSize();
						ConsoleExtensions.EsperaEnter();
						break;
					case "46":
						Console.Clear();
						VerTallesXShoe();
						ConsoleExtensions.EsperaEnter();
						break;
					case "47":
						Console.Clear();
						AgregarTalles();
						ConsoleExtensions.EsperaEnter();
						break;


					case "50":
						Console.Clear();
						//ListSize();
						ListSizePag();
						ConsoleExtensions.EsperaEnter();
						break;
					case "51":
						Console.Clear();
						AgregarSize();
						ConsoleExtensions.EsperaEnter();
						break;
					case "52":
						Console.Clear();
						BorrarSize();
						ConsoleExtensions.EsperaEnter();
						break;
					case "53":
						Console.Clear();
						EditarSize();
						ConsoleExtensions.EsperaEnter();
						break;
					case "54":
						Console.Clear();
						ListShoeXSize();
						ConsoleExtensions.EsperaEnter();
						break;
					case "x":
						exit = true;
						Console.WriteLine("Saliendo del programa...");
						break;
					default:
						Console.WriteLine(" Por favor, seleccione una opción válida.");
						break;
				}

				Console.WriteLine();
			}
		}

		private static void AgregarTalles()
		{
			var shoeService = serviceProvider?.GetService<IShoesService>();
			var sizeService = serviceProvider?.GetService<ISizeService>();

			if (shoeService == null || sizeService == null)
			{
				Console.WriteLine("Servicios no disponibles.");
				return;
			}

			var listShoe = shoeService.GetLista();
			if (listShoe.Count > 0)
			{
				ListaShoesPaginada();
				var opcionesShoes = ConsoleExtensions.GetValidOptions("Seleccione un articulo:", listShoe.Select(x => x.ShoeId.ToString()).ToList());

				var shoeSeleccionado = shoeService.GetShoePorId(Convert.ToInt32(opcionesShoes));

				if (shoeSeleccionado != null)
				{
					Console.WriteLine("Articulo seleccionado:");
					Console.WriteLine($"ID: {shoeSeleccionado.ShoeId}");
					Console.WriteLine($"Modelo: {shoeSeleccionado.Model}");
					Console.WriteLine();

					var tallesExistentes = shoeService.GetSizePorShoes(shoeSeleccionado.ShoeId);
					if (tallesExistentes != null && tallesExistentes.Count > 0)
					{
						Console.WriteLine("Talles existententes:");
						List<SizeDetailDto>? sizes = shoeService?.GetSizeDetalle(Convert.ToInt32(opcionesShoes));
						if (sizes == null || sizes.Count == 0)
						{
							Console.WriteLine($"No hay talles para el articulo: {shoeSeleccionado.Model}");
						}
						else
						{
							var tabla = new ConsoleTable("Talle", "Cantidad");
							foreach (var sizeDetail in sizes)
							{
								tabla.AddRow(sizeDetail.SizeN, sizeDetail.Quantity);
							}
							tabla.Options.EnableCount = false;
							tabla.Write();
						}

					}
					else
					{
						Console.WriteLine("El articulo no tiene talles asignados.");
					}

					var listaTalles = sizeService.GetLista();
					Console.WriteLine("Lista de talles:");
					MostrarListaSize(listaTalles);
					var opcion = ConsoleExtensions.GetValidOptions("Seleccione el ID del talle:", listaTalles.Select(x => x.SizeId.ToString()).ToList());




					var talleSeleccionado = listaTalles.FirstOrDefault(x => x.SizeId.ToString() == opcion);



					if (talleSeleccionado != null)
					{
						var existingSizeDetail = tallesExistentes?.FirstOrDefault(x => x.SizeId == talleSeleccionado.SizeId);
						if (existingSizeDetail != null)
						{
							var respuesta = ConsoleExtensions.GetRespuestSiNo("El articulo ya cuenta con el talle seleccionado, ¿desea agregar stock? (SI/NO): ");
							if (respuesta == "SI")
							{
								shoeService.AgregarStock(shoeSeleccionado.ShoeId, talleSeleccionado.SizeId, 1);
								Console.WriteLine("Stock actualizado.");
							}
							else
							{
								Console.WriteLine("Operacion cancelada.");
							}
							
						}
						else
						{
							shoeService.AsignarSizeAShoe(shoeSeleccionado, talleSeleccionado);
							Console.WriteLine("Talle agregado correctamente.");
						}
					}
					
				}
				else
				{
					Console.WriteLine("El articulo seleccionado no existe.");
				}
			}
			else
			{
				Console.WriteLine("No se encontraron articulos disponibles.");
			}
		}

		private static void VerTallesXShoe()
		{
			var servicio = serviceProvider?.GetService<ISizeService>();
			var serviceShoe = serviceProvider?.GetService<IShoesService>();
			Console.Clear();
			Console.WriteLine("Zapattillas por talle");
			ListaShoesPaginada();
			var listaChar = serviceShoe?.GetLista().Select(x => x.ShoeId.ToString()).ToList();

			var shoeId = ConsoleExtensions.GetValidOptions("Seleccione el ID del articulo:", listaChar);
			Shoe shoe = serviceShoe.GetShoePorId(Convert.ToInt32(shoeId));
			if (shoe is null)
			{
				Console.WriteLine("El articulo no existe");
				ConsoleExtensions.EsperaEnter();
				return;
			}
			Console.Clear();

			Console.WriteLine($"Articulo: {shoe.Model}");
			List<SizeDetailDto>? sizes = serviceShoe?.GetSizeDetalle(shoe.ShoeId);
			if (sizes == null || sizes.Count == 0)
			{
				Console.WriteLine($"No hay talles para el articulo: {shoe.Model}");
			}
			else
			{
				var tabla = new ConsoleTable("Talle", "Cantidad");
				foreach (var sizeDetail in sizes)
				{
					tabla.AddRow(sizeDetail.SizeN, sizeDetail.Quantity);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
			}

			

		}

		private static void AgruparPorMarca()
		{
			var shoeService = serviceProvider?.GetService<IShoesService>();
			var brandService = serviceProvider?.GetService<IBrandsService>();
			if (shoeService == null)
			{
				Console.WriteLine("Servicio no disponible.");
				return;
			}

			var agrupacioness = shoeService.GetShoesXBrands();

			foreach (var grupo in agrupacioness)
			{
				Console.Clear();
				Console.WriteLine($"Marca: {brandService?.GetBrandPorId(grupo.Key).BrandName}");
				foreach (var shoe in grupo)
				{
					Console.WriteLine($"  . Zapatos: {shoe.Model}, Descripcion: {shoe.Description}, Precio: {shoe.Price}");
				}
				Console.WriteLine($"Cantidad: {grupo.Count()}");
				Console.WriteLine($"Precio promedio:{grupo.Average(s => s.Price)}");
				ConsoleExtensions.EsperaEnter();
			}
			Console.WriteLine("Fin");
		}

		private static void AgruparPorGenero()
		{
			var shoeService = serviceProvider?.GetService<IShoesService>();
			var genreService = serviceProvider?.GetService<IGenresService>();
			if (shoeService == null)
			{
				Console.WriteLine("Servicio no disponible.");
				return;
			}

			var agrupacioness = shoeService.GetShoesXGenre();

			foreach (var grupo in agrupacioness)
			{
				Console.Clear();
				Console.WriteLine($"Genero: {genreService?.GetGenrePorId(grupo.Key).GnereName}");
				foreach (var shoe in grupo)
				{
					Console.WriteLine($"  . Zapatos: {shoe.Model}, Descripcion: {shoe.Description}, Precio: {shoe.Price}");
				}
				Console.WriteLine($"Cantidad: {grupo.Count()}");
				Console.WriteLine($"Precio promedio:{grupo.Average(s => s.Price)}");
				ConsoleExtensions.EsperaEnter();
			}
			Console.WriteLine("Fin");
		}
		private static void NuevoShoeNuevoSize()
		{
			var shoeService = serviceProvider?.GetService<IShoesService>();
			var sizeService = serviceProvider?.GetService<ISizeService>();

			if (shoeService == null || sizeService == null)
			{
				Console.WriteLine("Servicios no disponibles.");
				return;
			}

			Shoe shoe = CrearShoe();

			ListSize();
			var listaChar = sizeService.GetLista().Select(x => x.SizeId.ToString()).ToList();
			var sizeId = ConsoleExtensions.GetValidOptions("Ingrese el ID de un talle  (N para nuevo):", listaChar);

			if (sizeId == "N")
			{
				var nombreSize = ConsoleExtensions.ReadDecimal("Nuevo talle, nro:");

				Size newSize = new Size
				{
					SizeNumber = nombreSize,
				};


				var ss = new ShoeSize
				{
					ShoeN = shoe,
					SizeN = newSize,
					QuantityInStock = 1,
				};
				shoe.ShoesSizes.Add(ss);
				shoeService.GuardarConTalle(shoe, newSize);
				Console.WriteLine("Articulo y talles agregado correctamente");
			}
			else
			{
				int sizeInt = Convert.ToInt32(sizeId);
				Size? sizeExistente = sizeService.GetSizePorId(sizeInt);
				if (sizeExistente != null)
				{
					var ss = new ShoeSize
					{
						ShoeN = shoe,
						SizeN = sizeExistente,
						QuantityInStock = 1
					};
					shoe.ShoesSizes.Add(ss);

					shoeService.GuardarConTalle(shoe, sizeExistente);
					Console.WriteLine("Articulos y talle agregado correctamente!");
				}
				else
				{
					Console.WriteLine("Talle no encontrado.");
				}
			}
		}

		private static void EditarSize()
		{
			Console.Clear();
			Console.WriteLine("Editar talle");
			ListSize();
			var sizeId = ConsoleExtensions.ReadInt("Ingrese el id del talle a editar: ");
			try
			{
				var servicio = serviceProvider?.GetService<ISizeService>();
				var size = servicio?.GetSizePorId(sizeId);
				if (size != null)
				{
					Console.WriteLine($"Talle: {size.SizeNumber}");
					var sizeN = ConsoleExtensions.ReadDecimal("Ingrese el nuevo talle: ", 20, 55);
					size.SizeNumber = sizeN;
					if (servicio != null)
					{
						if (!servicio.Existe(size))
						{
							servicio.Guardar(size);
							Console.WriteLine("Talle editado.");

						}
						else
						{
							Console.WriteLine("Talle duplicado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible.");
					}
				}
				else
				{
					Console.WriteLine("El talle ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
		}

		private static void BorrarSize()
		{
			Console.Clear();
			Console.WriteLine("Borrar talle");
			ListSize();
			var sizeId = ConsoleExtensions.ReadInt("Ingrese el ID del talle a borrar:");
			try
			{
				var servicio = serviceProvider?.GetService<ISizeService>();
				Size? size = servicio?.GetSizePorId(sizeId);
				if (size != null)
				{
					if (servicio != null)
					{
						if (!servicio.EstaRelacionado(size))
						{
							servicio.Borrar(size);
							Console.WriteLine("Registro borrado.");

						}
						else
						{
							Console.WriteLine("Baja denegada. El genero esta relacionado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible");
					}
				}
				else
				{
					Console.WriteLine("El talle seleccionado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
		}

		private static void AgregarSize()
		{
			Console.Clear();
			Console.WriteLine("Talles");
			var sizeN = ConsoleExtensions.ReadDecimal("Ingrese el nuevo genero: ", 20, 55);

			Size size = new Size()
			{
				SizeNumber = sizeN
			};

			try
			{
				var servicio = serviceProvider?.GetService<ISizeService>();
				if (servicio != null)
				{
					if (!servicio.Existe(size))
					{
						servicio.Guardar(size);
						Console.WriteLine("Registro agregado");

					}
					else
					{
						Console.WriteLine("El talle ingresado ya existe.");
					}

				}
				else { Console.WriteLine("Servicio no disponible."); }
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
		}


		private static void AsignarSizeShoe()
		{
			var shoeService = serviceProvider?.GetService<IShoesService>();
			var sizeService = serviceProvider?.GetService<ISizeService>();

			if (shoeService == null || sizeService == null)
			{
				Console.WriteLine("Servicios no disponibles.");
				return;
			}

			var shoeWithoutSize = shoeService.ShoesSinTalle();
			if (shoeWithoutSize.Count > 0)
			{
				MostrarListaShoes(shoeWithoutSize);
				var opcionsShoes = ConsoleExtensions.GetValidOptions("Seleccione una articulo:", shoeWithoutSize.Select(x => x.ShoeId.ToString()).ToList());

				var shoeSinTalle = shoeService.GetShoePorId(Convert.ToInt32(opcionsShoes));

				if (shoeSinTalle != null)
				{
					Console.WriteLine("Articulo sin talle encontrado:");
					Console.WriteLine($"ID: {shoeSinTalle.ShoeId}");
					Console.WriteLine($"Modelo: {shoeSinTalle.Model}");
					Console.WriteLine();

					var listaTalles = sizeService.GetLista();

					Console.WriteLine("Lista de talles:");
					MostrarListaSize(listaTalles);
					var opcion = ConsoleExtensions.GetValidOptions("Seleccione un talle (N para ingresar uno nuevo):", listaTalles.Select(x => x.SizeId.ToString()).ToList());

					if (opcion == "N")
					{
						var nombreSize = ConsoleExtensions.ReadDecimal("Nuevo talle, nro:");

						Size newSize = new Size
						{
							SizeNumber = nombreSize,

						};

						shoeService.AsignarSizeAShoe(shoeSinTalle, newSize);
					}
					else
					{
						var talleSeleccionado = listaTalles.FirstOrDefault(x => x.SizeId.ToString() == opcion);

						shoeService.AsignarSizeAShoe(shoeSinTalle, talleSeleccionado);
						Console.WriteLine("Talle agregado correctamente.");
					}
				}
				else
				{
					Console.WriteLine("No se encontraron articulos sin talle.");
				}

			}
			else
			{
				Console.WriteLine("No se encontraron articulos sin talle.");
			}

		}

		private static void ListShoeXSize()
		{
			var servicio = serviceProvider?.GetService<ISizeService>();
			Console.Clear();
			Console.WriteLine("Zapattillas por talle");
			ListSize();
			var listaChar = servicio?.GetLista().Select(x => x.SizeId.ToString()).ToList();

			var sizeId = ConsoleExtensions.GetValidOptions("Seleccione el ID del talle:", listaChar);
			Size size = servicio.GetSizePorIDxShoe(Convert.ToInt32(sizeId), true);
			if (size is null)
			{
				Console.WriteLine("El talle no existe");
				ConsoleExtensions.EsperaEnter();
				return;
			}
			Console.Clear();
			Console.WriteLine($"Talle: {size.SizeNumber}");
			var tabla = new ConsoleTable("ID", "Modelo", "Descrpcion", "Color", "Genero", "Marca", "Deporte", "Precio");
			if (size.ShoesSizes != null)
			{
				if (size.ShoesSizes.Count == 0)
				{
					Console.WriteLine($"No hay articulos con el talle: {size.SizeNumber}");
				}
				else
				{
					foreach (var item in size.ShoesSizes)
					{
						tabla.AddRow(item.ShoeN.ShoeId,
							item.ShoeN.Model,
							item.ShoeN.Description,
							item.ShoeN.ColorN,
							item.ShoeN.Genre,
							item.ShoeN.Brand,
							item.ShoeN.Sport,
							item.ShoeN.Price);

					}
					tabla.Options.EnableCount = false;
					tabla.Write();
				}


			}

		}
		private static void ListSize()
		{
			var service = serviceProvider?.GetService<ISizeService>();
			var lista = service?.GetLista();
			var tabla = new ConsoleTable("ID", "Size");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.SizeId, item.SizeNumber);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
			}
		}

		private static void ListBrandsPag()
		{
			var servicio = serviceProvider?.GetService<IBrandsService>();
			pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 5, 10);
			var recordCount = servicio?.GetCantidad() ?? 0;
			var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

			for (int page = 1; page < pageCount + 1; page++)
			{
				Console.Clear();
				Console.WriteLine("Listado paginado.");
				Console.WriteLine($"Página: {page}");
				var listaPaginada = servicio?.GetListaPaginada(page, pageSize);
				MostrarListaBrand(listaPaginada);

			}
			Console.WriteLine("Fin del listado");
		}

		private static void MostrarListaBrand(List<Brand>? lista)
		{
			var tabla = new ConsoleTable("ID", "Marca");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.BrandId, item.BrandName);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
				ConsoleExtensions.EsperaEnter();
			}
		}

		private static void ListColorPag()
		{
			var servicio = serviceProvider?.GetService<IColorsService>();
			pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 5, 10);
			var recordCount = servicio?.GetCantidad() ?? 0;
			var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

			for (int page = 1; page < pageCount + 1; page++)
			{
				Console.Clear();
				Console.WriteLine("Listado paginado.");
				Console.WriteLine($"Página: {page}");
				var lista = servicio?.GetListaPaginada(page, pageSize);
				MostrarListaColor(lista);

			}

		}

		private static void MostrarListaColor(List<Color>? lista)
		{
			var tabla = new ConsoleTable("ID", "Color");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.ColorId, item.ColorName);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
				ConsoleExtensions.EsperaEnter();
			}
			Console.WriteLine("Fin del listado");
		}

		private static void ListGenrePag()
		{
			var servicio = serviceProvider?.GetService<IGenresService>();
			pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 1, 2);
			var recordCount = servicio?.GetCantidad() ?? 0;
			var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

			for (int page = 1; page < pageCount + 1; page++)
			{
				Console.Clear();
				Console.WriteLine("Listado paginado.");
				Console.WriteLine($"Página: {page}");
				var listaPaginada = servicio?.GetListaPaginada(page, pageSize);
				MostrarListaGenre(listaPaginada);

			}
			Console.WriteLine("Fin del listado");
		}

		private static void MostrarListaGenre(List<Genre>? lista)
		{
			var tabla = new ConsoleTable("ID", "Genero");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.GenreId, item.GnereName);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
				ConsoleExtensions.EsperaEnter();
			}
		}

		private static void MostrarListaSport(List<Sport>? lista)
		{
			var tabla = new ConsoleTable("ID", "Deporte");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.SportiD, item.SportName);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
				ConsoleExtensions.EsperaEnter();
			}
		}

		private static void MostrarListaSize(List<Size>? lista)
		{
			var tabla = new ConsoleTable("ID", "Talle");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.SizeId, item.SizeNumber);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
			}
		}
		private static void ListSportPag()
		{
			var servicio = serviceProvider?.GetService<ISportsService>();
			pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 5, 10);
			var recordCount = servicio?.GetCantidad() ?? 0;
			var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

			for (int page = 1; page < pageCount + 1; page++)
			{
				Console.Clear();
				Console.WriteLine("Listado paginado.");
				Console.WriteLine($"Página: {page}");
				var listaPaginada = servicio?.GetListaPaginada(page, pageSize);
				MostrarListaSport(listaPaginada);
			}

			Console.WriteLine("Fin del listado");
		}
		private static void ListSizePag()
		{
			var servicio = serviceProvider?.GetService<ISizeService>();
			pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 10, 20);
			var recordCount = servicio?.GetCantidad() ?? 0;
			var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

			for (int page = 1; page < pageCount + 1; page++)
			{
				Console.Clear();
				Console.WriteLine("Listado paginado.");
				Console.WriteLine($"Página: {page}");
				var listaPaginada = servicio?.GetListaPaginada(page, pageSize);
				MostrarListaSize(listaPaginada);

				ConsoleExtensions.EsperaEnter();

			}
			Console.WriteLine("Fin del listado");
		}

		private static void ListaShoesPaginada()
		{
			Console.Clear();
			var servicio = serviceProvider?.GetService<IShoesService>();
			pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 10, 20);
			var recordCount = servicio?.GetCantidad() ?? 0;
			var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

			for (int page = 0; page < pageCount; page++)
			{
				Console.Clear();
				Console.WriteLine("Listado Paginado");
				Console.WriteLine($"Página: {page + 1}");
				var listaPaginada = servicio?.GetListaPaginadaOrdenadaFiltrada(page, pageSize);
				MostrarListaShoes(listaPaginada);
				ConsoleExtensions.EsperaEnter();
			}
			Console.WriteLine("Fin del listado");
		}

		private static void MostrarListaShoes(List<ShoeListDto>? lista)
		{
			var tabla = new ConsoleTable("ID", "Modelo", "Descrpcion", "Color", "Genero", "Marca", "Deporte", "Precio");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.ShoeId, item.Model, item.Description, item.ColorN, item.Genre, item.Brand, item.Sport, item.Price);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
			}
		}

		private static int CalcularCantidadPaginas(int cantidadRegistros, int cantidadPorPagina)
		{
			if (cantidadRegistros < cantidadPorPagina)
			{
				return 1;
			}
			else if (cantidadRegistros % cantidadPorPagina == 0)
			{
				return cantidadRegistros / cantidadPorPagina;
			}
			else
			{
				return cantidadRegistros / cantidadPorPagina + 1;
			}
		}

		private static void EditarShoe()
		{
			var serviceColor = serviceProvider?.GetService<IColorsService>();
			var serviceBrand = serviceProvider?.GetService<IBrandsService>();
			var serviceSport = serviceProvider?.GetService<ISportsService>();
			var serviceGenre = serviceProvider?.GetService<IGenresService>();
			var serviceShoe = serviceProvider?.GetService<IShoesService>();
			var serviceSize = serviceProvider?.GetService<ISizeService>();

			ListaShoesPaginada();
			var shoeId = ConsoleExtensions.ReadInt("Ingrese el ID del articulo a editar:");
			var shoe = serviceShoe?.GetShoePorId(shoeId);

			if (shoe == null)
			{
				Console.WriteLine("Articulo no encontrada.");
				return;
			}

			Console.WriteLine($"Modelo: {shoe.Model}");
			Console.WriteLine($"Descripcion: {shoe.Description}");
			Console.WriteLine($"Color: {shoe.ColorN?.ColorName}");
			Console.WriteLine($"Deporte: {shoe.Sport?.SportName}");
			Console.WriteLine($"Marca: {shoe.Brand?.BrandName}");
			Console.WriteLine($"Genero: {shoe.Genre?.GnereName}");
			Console.WriteLine($"Precio: {shoe.Price}");

			shoe.Model = ConsoleExtensions.ReadString("Ingrese el nuevo modelo:");
			shoe.Description = ConsoleExtensions.ReadString("Ingrese la nueva descripción:");
			shoe.Price = ConsoleExtensions.ReadDecimal("Ingrese el nuevo precio:");


			ListadoColores();
			var listaCol = serviceColor?.GetLista().Select(x => x.ColorId.ToString()).ToList();
			var colorId = ConsoleExtensions.GetValidOptions("Seleccione el id del color :", listaCol);

			shoe.ColorId = Convert.ToInt32(colorId);
			shoe.ColorN = serviceColor?.GetColorPorId(shoe.ColorId);


			ListadoDeGeneros();
			var listaGenre = serviceGenre?.GetLista().Select(x => x.GenreId.ToString()).ToList();
			var genreId = ConsoleExtensions.GetValidOptions("Seleccione el id del genero: ", listaGenre);

			shoe.GenreId = Convert.ToInt32(genreId);
			shoe.Genre = serviceGenre?.GetGenrePorId(shoe.GenreId);

			ListadoDeSport();
			var listaSport = serviceSport?.GetLista().Select(x => x.SportiD.ToString()).ToList();
			var sportId = ConsoleExtensions.GetValidOptions("Seleccione el id del deporte:", listaSport);

			shoe.SportId = Convert.ToInt32(sportId);
			shoe.Sport = serviceSport?.GetSportPorId(shoe.SportId);


			ListadoDeMarcas();
			var listaBr = serviceBrand?.GetLista().Select(x => x.BrandId.ToString()).ToList();
			var brandId = ConsoleExtensions.GetValidOptions("Seleccione el id de la marca (N para ingresar una nueva): ", listaBr);

			shoe.BrandId = Convert.ToInt32(brandId);
			shoe.Brand = serviceBrand?.GetBrandPorId(shoe.BrandId);


			ListSize();
			var sizeId = ConsoleExtensions.ReadInt("Ingrese el ID del nuevo talle (0 para no agregar):");
			var size = serviceSize?.GetSizePorId(sizeId);

			try
			{
				if (sizeId == 0)
				{
					serviceShoe?.Editar(shoe, null);
					return;
				}
				else
				{
					serviceShoe?.Editar(shoe, sizeId);

				}

			}

			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}

			Console.WriteLine("Articulo actualizado.");
			Thread.Sleep(2000);
		}

		private static void BorrarShoe()
		{
			var servicio = serviceProvider?.GetService<IShoesService>();
			Console.Clear();
			Console.WriteLine("Ingreso zapato a borrar");
			ListShoes();
			var listaS = servicio?.GetLista().Select(x => x.ShoeId.ToString()).ToList();
			var shoeId = ConsoleExtensions.GetValidOptions("Ingrese el ID del zapato que desea borrar:", listaS);


			try
			{
				var shoe = servicio?.GetShoePorId(Convert.ToInt32(shoeId));
				if (shoe != null)
				{
					if (servicio != null)
					{

						servicio.Borrar(shoe);
						Console.WriteLine("Registro borrado.");

					}

					else
					{
						throw new Exception("Servicio no disponible");
					}
				}
				else
				{
					Console.WriteLine("Registro inexistente.");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(5000);
		}

		private static Shoe CrearShoe()
		{
			Console.Clear();
			var serviceColor = serviceProvider?.GetService<IColorsService>();
			var serviceBrand = serviceProvider?.GetService<IBrandsService>();
			var serviceSport = serviceProvider?.GetService<ISportsService>();
			var serviceGenre = serviceProvider?.GetService<IGenresService>();
			var serviceShoe = serviceProvider?.GetService<IShoesService>();

			Color? color;
			Brand? brand;
			Sport? sport;
			Genre? genre;

			Console.WriteLine("Agregar zapato");
			var model = ConsoleExtensions.ReadString("Modelo: ");
			var descripcion = ConsoleExtensions.ReadString("Descripcion: ");



			ListadoColores();
			var listaCol = serviceColor?.GetLista().Select(x => x.ColorId.ToString()).ToList();

			var colorId = ConsoleExtensions.GetValidOptions("Seleccione el id del color (N para ingresar uno nuevo):", listaCol);
			if (colorId == "N")
			{
				colorId = "0";
				Console.WriteLine("");
				var colorNombre = ConsoleExtensions.ReadString("Ingrese el nombre del nuevo color:");

				color = new Color()
				{
					ColorId = 0,
					ColorName = colorNombre
				};

			}
			else
			{
				color = serviceColor?.GetColorPorId(Convert.ToInt32(colorId));

			}

			////////////////////////////////////////////////////////////////////////////////




			ListadoDeGeneros();
			var listaGenre = serviceGenre?.GetLista().Select(x => x.GenreId.ToString()).ToList();
			var genreId = ConsoleExtensions.GetValidOptions("Seleccione el id del genero (N para ingresar uno nuevo): ", listaGenre);

			if (genreId == "N")
			{
				genreId = "0";
				Console.WriteLine("");
				var genreN = ConsoleExtensions.ReadString("Ingrese el nuevo genero: ");

				genre = new Genre()
				{
					GenreId = 0,
					GnereName = genreN
				};

			}
			else
			{
				genre = serviceGenre?.GetGenrePorId(Convert.ToInt32(genreId));
				Console.WriteLine("Género nuevo agregado.");

			}

			////////////////////////////////////////////////////////////////////////////////


			ListadoDeSport();
			var listaSport = serviceSport?.GetLista().Select(x => x.SportiD.ToString()).ToList();
			var sportId = ConsoleExtensions
				.GetValidOptions("Seleccione el id del deporte (N para ingresar uno nuevo):", listaSport);
			if (sportId == "N")
			{
				sportId = "0";
				Console.WriteLine("");
				var sporN = ConsoleExtensions.ReadString("Ingrese el nombre del nuevo deporte: ");


				sport = new Sport()
				{
					SportiD = 0,
					SportName = sporN
				};

			}
			else
			{
				sport = serviceSport?
					.GetSportPorId(Convert.ToInt32(sportId));

			}

			////////////////////////////////////////////////////////////////////////////////

			ListadoDeMarcas();
			var listaBr = serviceBrand?.GetLista()
				.Select(x => x.BrandId.ToString()).ToList();
			var brandId = ConsoleExtensions.GetValidOptions("Seleccione el id de la marca (N para ingresar una nueva): ",
				listaBr);

			if (brandId == "N")
			{
				brandId = "0";
				Console.WriteLine("");
				var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese el nombre de la nueva marca:");

				brand = new Brand()
				{
					BrandId = 0,
					BrandName = tipoDescripcion
				};

			}
			else
			{
				brand = serviceBrand?
					.GetBrandPorId(Convert.ToInt32(brandId));
			}



			var precio = ConsoleExtensions.ReadDecimal("Ingrese el precio: ");

			var shoe = new Shoe()
			{
				Model = model,
				Description = descripcion,
				Price = precio,
				ColorId = Convert.ToInt32(colorId),
				GenreId = Convert.ToInt32(genreId),
				SportId = Convert.ToInt32(sportId),
				BrandId = Convert.ToInt32(brandId),
				ColorN = color,
				Genre = genre,
				Sport = sport,
				Brand = brand,

			};
			return shoe;
		}

		private static void AgregarShoe()
		{
			Console.Clear();
			var servicioShoe = serviceProvider?.GetService<IShoesService>();
			var shoe = CrearShoe();
			if (servicioShoe != null)
			{
				if (!servicioShoe.Existe(shoe))
				{
					servicioShoe.Guardar(shoe);
					Console.WriteLine("Articulo agregado");
				}
				else
				{
					Console.WriteLine("Articulo duplicado");
				}
			}
			else
			{
				Console.WriteLine("Error: El servicio es nulo.");
			}
			Thread.Sleep(2000);

		}
		private static void ListShoes()
		{
			var service = serviceProvider?.GetService<IShoesService>();
			var lista = service?.GetListaDto();
			var tabla = new ConsoleTable("ID", "Model", "Descripcion", "Precio", "Color", "Genero", "Sport", "Marca");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.ShoeId, item.Model, item.Description, item.Price, item.ColorN, item.Genre, item.Sport, item.Brand);
				}
				tabla.Options.EnableCount = false;
				tabla.Write();
			}
		}

		private static void EditarGenero()
		{
			Console.Clear();
			Console.WriteLine("Editar genero");
			var genreEdit = ConsoleExtensions.ReadString("Ingrese el genero a editar: ");
			try
			{
				var servicio = serviceProvider?.GetService<IGenresService>();
				var genre = servicio?.GetGenrePorNombre(genreEdit);
				if (genre != null)
				{
					Console.WriteLine($"Genero: {genre.GnereName}");
					var genreN = ConsoleExtensions.ReadString("Ingrese el nuevo genero: ");
					genre.GnereName = genreN;
					if (servicio != null)
					{
						if (!servicio.Existe(genre))
						{
							servicio.Guardar(genre);
							Console.WriteLine("Genero editado.");

						}
						else
						{
							Console.WriteLine("Genero duplicado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible.");
					}
				}
				else
				{
					Console.WriteLine("El genero ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void BorrarGenero()
		{
			Console.Clear();
			Console.WriteLine("Borrar genero");
			ListadoDeGeneros();
			var genreN = ConsoleExtensions.ReadString("Ingrese el genero borrar:");
			try
			{
				var servicio = serviceProvider?.GetService<IGenresService>();
				Genre? genre = servicio?.GetGenrePorNombre(genreN);
				if (genre != null)
				{
					if (servicio != null)
					{
						if (!servicio.EstaRelacionado(genre))
						{
							servicio.Borrar(genre);
							Console.WriteLine("Registro borrado.");

						}
						else
						{
							Console.WriteLine("Baja denegada. El genero esta relacionado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible");
					}
				}
				else
				{
					Console.WriteLine("El genero ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void NuevoGenero()
		{
			Console.Clear();
			Console.WriteLine("Nuevo genero");
			var genreN = ConsoleExtensions.ReadString("Ingrese el nuevo genero: ");

			Genre genre = new Genre()
			{
				GnereName = genreN
			};

			try
			{
				var servicio = serviceProvider?.GetService<IGenresService>();
				if (servicio != null)
				{
					if (!servicio.Existe(genre))
					{
						servicio.Guardar(genre);
						Console.WriteLine("Registro agregado");

					}
					else
					{
						Console.WriteLine("El genero ya existe.");
					}

				}
				else { Console.WriteLine("Servicio no disponible."); }
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void ListadoDeGeneros()
		{
			Console.WriteLine("Listado de genero");

			var servicio = serviceProvider?.GetService<IGenresService>();
			var lista = servicio?.GetLista();
			var tabla = new ConsoleTable("ID", "Genero");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.GenreId, item.GnereName);
				}

			}
			tabla.Options.EnableCount = false;
			tabla.Write();
		}


		private static void EditarSport()
		{
			Console.Clear();
			Console.WriteLine("Editar deporte");
			var sportEdit = ConsoleExtensions.ReadString("Ingrese el deporte a editar: ");
			try
			{
				var servicio = serviceProvider?.GetService<ISportsService>();
				var sport = servicio?.GetSportPorNombre(sportEdit);
				if (sport != null)
				{
					Console.WriteLine($"Deporte: {sport.SportName}");
					var sportN = ConsoleExtensions.ReadString("Ingrese el nombre del nuevo deporte: ");
					sport.SportName = sportN;
					if (servicio != null)
					{
						if (!servicio.Existe(sport))
						{
							servicio.Guardar(sport);
							Console.WriteLine("Deporte editado.");

						}
						else
						{
							Console.WriteLine("Deporte duplicado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible.");
					}
				}
				else
				{
					Console.WriteLine("El deporte ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void BorrarSport()
		{
			Console.Clear();
			Console.WriteLine("Borrar Deporte");
			ListadoDeSport();
			var sportId = ConsoleExtensions.ReadInt("Ingrese el ID del deporte a borrar:");
			try
			{
				var servicio = serviceProvider?.GetService<ISportsService>();
				var sport = servicio?.GetSportPorId(sportId);
				if (sport != null)
				{
					if (servicio != null)
					{
						if (!servicio.EstaRelacionado(sport))
						{
							servicio.Borrar(sport);
							Console.WriteLine("Registro borrado.");

						}
						else
						{
							Console.WriteLine("Baja denegada. El deporte esta relacionado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible");
					}
				}
				else
				{
					Console.WriteLine("El deporte ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void NuevoSport()
		{
			Console.Clear();
			Console.WriteLine("Nuevo deporte");
			var sportN = ConsoleExtensions.ReadString("Ingrese el nuevo deporte: ");

			Sport sport = new Sport()
			{
				SportName = sportN
			};

			try
			{
				var servicio = serviceProvider?.GetService<ISportsService>();
				if (servicio != null)
				{
					if (!servicio.Existe(sport))
					{
						servicio.Guardar(sport);
						Console.WriteLine("Registro agregado");

					}
					else
					{
						Console.WriteLine("El deporte ya existe.");
					}

				}
				else { Console.WriteLine("Servicio no disponible"); }
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void ListadoDeSport()
		{
			Console.WriteLine("Listado de deportes");

			var servicio = serviceProvider?.GetService<ISportsService>();
			var lista = servicio?.GetLista();
			var tabla = new ConsoleTable("ID", "Deporte");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.SportiD, item.SportName);
				}

			}
			tabla.Options.EnableCount = false;
			tabla.Write();
		}


		private static void EditarMarca()
		{
			Console.Clear();
			Console.WriteLine("Editar marca");
			var brandN = ConsoleExtensions.ReadString("Ingrese la marca a editar: ");
			try
			{
				var servicio = serviceProvider?.GetService<IBrandsService>();
				var brand = servicio?.GetBrandPorNombre(brandN);
				if (brand != null)
				{
					Console.WriteLine($"Marca: {brand.BrandName}");
					var nuevaMarca = ConsoleExtensions.ReadString("Ingrese el nombre de la nueva marca: ");
					brand.BrandName = nuevaMarca;
					if (servicio != null)
					{
						if (!servicio.Existe(brand))
						{
							servicio.Guardar(brand);
							Console.WriteLine("Marca editada.");

						}
						else
						{
							Console.WriteLine("Marca duplicada.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible.");
					}
				}
				else
				{
					Console.WriteLine("La marca no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void BorrarMarca()
		{
			Console.Clear();
			Console.WriteLine("Borrar marca");
			ListadoDeMarcas();
			var brandId = ConsoleExtensions.ReadInt("Ingrese el ID de la marca a borra:");
			try
			{
				var servicio = serviceProvider?.GetService<IBrandsService>();
				var brand = servicio?.GetBrandPorId(brandId);
				if (brand != null)
				{
					if (servicio != null)
					{
						if (!servicio.EstaRelacionado(brand))
						{
							servicio.Borrar(brand);
							Console.WriteLine("Registro borrado.");

						}
						else
						{
							Console.WriteLine("Baja denegada. La marca esta relacionado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible");
					}
				}
				else
				{
					Console.WriteLine("La marca ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void NuevaMarca()
		{
			Console.Clear();
			Console.WriteLine("Nueva marca");
			var brandN = ConsoleExtensions.ReadString("Ingrese una marca nueva:");

			Brand brand = new Brand()
			{
				BrandName = brandN
			};

			try
			{
				var servicio = serviceProvider?.GetService<IBrandsService>();
				if (servicio != null)
				{
					if (!servicio.Existe(brand))
					{
						servicio.Guardar(brand);
						Console.WriteLine("Registro agregado");

					}
					else
					{
						Console.WriteLine("La marca ingresada ya existe.");
					}

				}
				else { Console.WriteLine("Servicio no disponible"); }
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void ListadoDeMarcas()
		{
			Console.WriteLine("Listado de marcas");

			var servicio = serviceProvider?.GetService<IBrandsService>();
			var lista = servicio?.GetLista();
			var tabla = new ConsoleTable("ID", "Marca");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.BrandId, item.BrandName);
				}

			}
			tabla.Options.EnableCount = false;
			tabla.Write();
		}

		private static void EditarColor()
		{
			Console.Clear();
			Console.WriteLine("Editar colores");
			var colorNombre = ConsoleExtensions.ReadString("Ingrese el color a editar: ");
			try
			{
				var servicio = serviceProvider?.GetService<IColorsService>();
				var color = servicio?.GetColorPorNombre(colorNombre);
				if (color != null)
				{
					Console.WriteLine($"Color: {color.ColorName}");
					var nuevoColorNombre = ConsoleExtensions.ReadString("Ingrese el nombre del nuevo color: ");
					color.ColorName = nuevoColorNombre;
					if (servicio != null)
					{
						if (!servicio.Existe(color))
						{
							servicio.Guardar(color);
							Console.WriteLine("Color editado.");

						}
						else
						{
							Console.WriteLine("Color duplicado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible.");
					}
				}
				else
				{
					Console.WriteLine("El color no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(5000);
		}

		private static void BorrarColor()
		{
			Console.Clear();
			Console.WriteLine("Borrar Color");
			ListadoColores();
			var colorId = ConsoleExtensions.ReadInt("Ingrese el ID del color:");
			try
			{
				var servicio = serviceProvider?.GetService<IColorsService>();
				var color = servicio?.GetColorPorId(colorId);
				if (color != null)
				{
					if (servicio != null)
					{
						if (!servicio.EstaRelacionado(color))
						{
							servicio.Borrar(color);
							Console.WriteLine("Registro borrado.");

						}
						else
						{
							Console.WriteLine("Baja denegada. El color esta relacionado.");
						}

					}
					else
					{
						throw new Exception("Servicio no disponible");
					}
				}
				else
				{
					Console.WriteLine("El color ingresado no existe");
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void NuevoColor()
		{
			Console.Clear();
			Console.WriteLine("Ingreso de nuevo color");
			var colorName = ConsoleExtensions.ReadString("Ingrese el color:");

			Color color = new Color()
			{
				ColorName = colorName
			};

			try
			{
				var servicio = serviceProvider?.GetService<IColorsService>();
				if (servicio != null)
				{
					if (!servicio.Existe(color))
					{
						servicio.Guardar(color);
						Console.WriteLine("Color agregado.");

					}
					else
					{
						Console.WriteLine("Color existente");
					}

				}
				else { Console.WriteLine("Servicio no disponible"); }
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message); ;
			}
			Thread.Sleep(2000);
		}

		private static void ListadoColores()
		{
			Console.WriteLine("Listado de colores");

			var servicio = serviceProvider?.GetService<IColorsService>();
			var lista = servicio?.GetLista();
			var tabla = new ConsoleTable("ID", "Color");
			if (lista != null)
			{
				foreach (var item in lista)
				{
					tabla.AddRow(item.ColorId, item.ColorName);
				}

			}
			tabla.Options.EnableCount = false;
			tabla.Write();
		}
	}
}
