using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.IOC;
using Shoes.Servicios.Interface;
using Shoes.Shared;
using System.Numerics;

namespace Shoes.Consola
{
    internal class Program

    {
        private static IServiceProvider? serviceProvider;

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
                Console.WriteLine("5. ");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("10. Listado de marcas");
                Console.WriteLine("11. Ingresar una marca nueva");
                Console.WriteLine("12. Borrar una marca");
                Console.WriteLine("13. Editar una marca");
                Console.WriteLine("14. ");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("20. Listado de generos");
                Console.WriteLine("21. Ingreso de un nuevo genero");
                Console.WriteLine("22. Eliminar genero");
                Console.WriteLine("23. Editar genero");
                Console.WriteLine("24. ");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("30. Listado de deportes");
                Console.WriteLine("31. Ingresar un nuevo deporte");
                Console.WriteLine("32. Borrar un deporte");
                Console.WriteLine("33. Editar deporte");
                Console.WriteLine("34. ");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("40. Listado de zapatos");
                Console.WriteLine("41. Ingresar un nuevo zapato");
                Console.WriteLine("42. Borrar un zapato");
                Console.WriteLine("43. Editar un zapato");
                Console.WriteLine("44. ");

                Console.WriteLine("x. Salir");

                Console.Write("Por favor, seleccione una opción: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        ListadoColores();
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
                        ListadoDeMarcas();
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
                        break;
                    case "15":
                        break;
                    case "16":
                        break;


                    case "20":
                        Console.Clear();
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


                    case "30":
                        Console.Clear();
                        ListadoDeSport();
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



                    case "40":
                        Console.Clear();
                        ListShoes();
                        ConsoleExtensions.EsperaEnter();
                        break;
                    case "41":
                        Console.Clear();
                        NuevoShoe();
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

        private static void EditarShoe()
        {
            var serviceColor = serviceProvider?.GetService<IColorsService>();
            var serviceBrand = serviceProvider?.GetService<IBrandsService>();
            var serviceSport = serviceProvider?.GetService<ISportsService>();
            var serviceGenre = serviceProvider?.GetService<IGenresService>();
            var serviceShoe = serviceProvider?.GetService<IShoesService>();

            ListShoes();
            var listaSh = serviceShoe?.GetLista().Select(x => x.ShoeId.ToString()).ToList();
            var shoeId = ConsoleExtensions.GetValidOptions("Seleccione el id de la marca: ", listaSh);

            var shoe = serviceShoe?.GetShoePorId(Convert.ToInt32(shoeId));

            if (shoe == null)
            {
                Console.WriteLine("El registro ingresado no existe.");
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

            if (shoeId is not null)
            {
                shoe.ColorId = Convert.ToInt32(colorId);
                shoe.ColorN = serviceColor?.GetColorPorId(shoe.ColorId);
            }
            else
            {

            }
            

            ListadoDeGeneros();
            var listaGenre = serviceGenre?.GetLista().Select(x => x.GenreId.ToString()).ToList();
            var genreId = ConsoleExtensions.GetValidOptions("Seleccione el id del genero (N para ingresar uno nuevo): ", listaGenre);
            if (genreId is not null)
            {
                shoe.GenreId = Convert.ToInt32(genreId);
                shoe.Genre = serviceGenre?.GetGenrePorId(shoe.GenreId);
            }
            else
            {
                
            }

            ListadoDeSport();
            var listaSport = serviceSport?.GetLista().Select(x => x.SportiD.ToString()).ToList();
            var sportId = ConsoleExtensions.GetValidOptions("Seleccione el id del deporte (N para ingresar uno nuevo):", listaSport);
            if (sportId == "N")
            {
                var sporN = ConsoleExtensions.ReadString("Ingrese el nombre del nuevo deporte: ");
                shoe.Sport = new Sport { SportName = sporN };
            }
            else
            {
                shoe.SportId = Convert.ToInt32(sportId);
                shoe.Sport = serviceSport?.GetSportPorId(shoe.SportId);
            }

            ListadoDeMarcas();
            var listaBr = serviceBrand?.GetLista().Select(x => x.BrandId.ToString()).ToList();
            var brandId = ConsoleExtensions.GetValidOptions("Seleccione el id de la marca (N para ingresar una nueva): ", listaBr);
            if (brandId == "N")
            {
                var tipoDescripcion = ConsoleExtensions.ReadString("Ingrese el nombre de la nueva marca:");
                shoe.Brand = new Brand { BrandName = tipoDescripcion };
            }
            else
            {
                shoe.BrandId = Convert.ToInt32(brandId);
                shoe.Brand = serviceBrand?.GetBrandPorId(shoe.BrandId);
            }

            // Guardar los cambios
            try
            {
                serviceShoe.Guardar(shoe);
                Console.WriteLine("Zapato actualizado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el zapato: {ex.Message}");
            }

            Thread.Sleep(2000);
        }

        private static void BorrarShoe()
        {
            var servicio = serviceProvider?.GetService<IShoesService>();
            Console.Clear();
            Console.WriteLine("Ingreso zapato a borrar");
            ListShoes();
            var listaS = servicio?
                    .GetLista()
                    .Select(x => x.ShoeId.ToString()).ToList();
            var shoeId = ConsoleExtensions
                .GetValidOptions("Ingrese el ID del zapato que desea borrar:", listaS);


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

        private static void NuevoShoe()
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
            var listaCol = serviceColor?
                .GetLista()
                .Select(x => x.ColorId.ToString()).ToList();
            var colorId = ConsoleExtensions
                .GetValidOptions("Seleccione el id del color (N para ingresar uno nuevo):", listaCol);
            if (colorId == "N")
            {
                colorId = "0";
                Console.WriteLine("I");
                var colorNombre = ConsoleExtensions.ReadString("Ingrese el nombre del nuevo color:");

                color = new Color()
                {
                    ColorId = 0,
                    ColorName = colorNombre
                };

            }
            else
            {
                color = serviceColor?
                    .GetColorPorId(Convert.ToInt32(colorId));

            }

            ////////////////////////////////////////////////////////////////////////////////




            ListadoDeGeneros();
            var listaGenre = serviceGenre?.GetLista().Select(x => x.GenreId.ToString()).ToList();
            var genreId = ConsoleExtensions .GetValidOptions("Seleccione el id del genero (N para ingresar uno nuevo): ", listaGenre);
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
                genre = serviceGenre? .GetGenrePorId(Convert.ToInt32(genreId));

            }

            ////////////////////////////////////////////////////////////////////////////////


            ListadoDeSport();
            var listaSport = serviceSport?
                .GetLista()
                .Select(x => x.SportiD.ToString()).ToList();
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
                Description= descripcion,
                Price= precio,
                ColorId = Convert.ToInt32(colorId),
                GenreId = Convert.ToInt32(genreId),
                SportId = Convert.ToInt32(sportId),
                BrandId = Convert.ToInt32(brandId),
                ColorN = color,
                Genre = genre,
                Sport = sport,
                Brand = brand,
                
            };
            if (serviceShoe != null)
            {
                if (!serviceShoe.Existe(shoe))
                {
                    serviceShoe.Guardar(shoe);
                    Console.WriteLine("Registro agregado.");
                }
                else
                {
                    Console.WriteLine("Registro duplicado.");
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
            var service=serviceProvider.GetService<IShoesService>();
            var lista=service.GetListaDto();
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
            var genreN = ConsoleExtensions.ReadString("Ingrese el genero borrar:");
            try
            {
                var servicio = serviceProvider?.GetService<IGenresService>();
                Genre genre = servicio?.GetGenrePorNombre(genreN);
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
            var lista = servicio.GetLista();
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
            var sportN = ConsoleExtensions.ReadString("Ingrese el nombre del deporte a borrar:");
            try
            {
                var servicio = serviceProvider?.GetService<ISportsService>();
                var sport = servicio?.GetSportPorNombre(sportN);
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
            var lista = servicio.GetLista();
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
            Console.WriteLine("Borar marca");
            var brandN = ConsoleExtensions.ReadString("Ingrese el nombre de la marca a borra:");
            try
            {
                var servicio = serviceProvider?.GetService<IBrandsService>();
                var brand = servicio?.GetBrandPorNombre(brandN);
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
            var lista = servicio.GetLista();
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
            Console.WriteLine("Ingreso de color a borrar");
            var colorNombre = ConsoleExtensions.ReadString("Ingrese el nombre del color:");
            try
            {
                var servicio = serviceProvider?.GetService<IColorsService>();
                var color = servicio?.GetColorPorNombre(colorNombre);
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
            Thread.Sleep(5000);
        }

        private static void ListadoColores()
        {
            Console.WriteLine("Listado de colores");

            var servicio = serviceProvider?.GetService<IColorsService>();
            var lista = servicio.GetLista();
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
