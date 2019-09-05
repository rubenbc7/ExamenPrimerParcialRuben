using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist Comedias = new Playlist("Comedias divertidas", "Peliculas que te sacarán un pedo de la risa");
            Comedias.Titulo = "Comedias muy divertidas";
            Comedias.Descripcion = "JAJAJJAJAJAJA";
            playlists.Add(Comedias);

            Playlist Accion = new Playlist("Pura Accion", "EXTREMOOOOOOOOOOOOOOOOOO");
            Accion.Descripcion = "Pura pishi accion";
            Accion.Titulo = "EXTREMOMOOOO";
            playlists.Add(Accion);

            Pelicula Pie = new Pelicula("American Pie", 1999, "Quentin Tarantino", "Comedia", "EUA", 96, 9.3, "Un men que quiere perder la virginidad");
            Pelicula Fe = new Pelicula("Fe", 1979, "Lupita dalesio", "Comedia", "Mexico", 110, 9.2, "Lupita pierde la fé buscando un opan");
            Pelicula Rubia = new Pelicula("¿Donde están las rubias?", 2005, "Terry Crewa", "Comedia", "EUA", 85, 9.6, "Dos negros se vuelven rubias");
            Pelicula Vecino = new Pelicula("Buenos vecinos", 2012, "Seth Rogen", "Comedia", "EUA", 83, 7.8, "Muy malos padres que se van de peda con Zac Efron");
            Pelicula Pie2 = new Pelicula("American Pie 2", 2001, "Quentin Tarantino", "Comedia", "EUA", 110, 9.5, "Un men que quería perder la virginidad ahora busca a su amada");
            Pelicula Pie3 = new Pelicula("American Pie 3", 2005, "Quentin Tarantino", "Comedia", "EUA", 103, 8.3, "Un men que quería perder la virginidad ahora se va a casar con su amada");
            Pelicula Pie4 = new Pelicula("American Pie 4", 2011, "Quentin Tarantino", "Comedia", "EUA", 128, 8.9, "Un men que quiere perder la virginidad se junta con sus compas de la prepa");

            Pelicula Ryf = new Pelicula("Rapidos y furiosos", 2000, "Vin gasolinas", "Mucha accion", "Japon", 128, 9.0, "Un pelon y un wero juegan carreritas");
            Pelicula Ryf2 = new Pelicula("+Rapidos y +furiosos", 2002, "Vin gasolinas", "Mucha accion", "Japon", 120, 8.3, "Un negro y un wero juegan carreritas");
            Pelicula Ryf3 = new Pelicula("Rapidos y furiosos reto tokyo", 2005, "Vin gasolinas", "Mucha accion", "Japon", 118, 9.2, "Un chino y otro wero juegan carreritas");
            Pelicula Ryf4 = new Pelicula("Rapidos y furiosos 4", 2008, "Vin gasolinas", "Mucha accion", "Japon", 138, 9.3, "Un pelon y un wero ya no juegan carreritas");
            Pelicula Ryf5 = new Pelicula("Rapidos y furiosos CINCOntrol", 2011, "Vin gasolinas", "Mucha accion", "Japon", 98, 8.6, "Un pelon y un wero juegan carreritas en brasil");
            Pelicula Ryf6 = new Pelicula("Rapidos y furiosos 6", 2013, "Vin gasolinas", "Mucha accion", "Japon", 118, 8.9, "Un pelon y un wero juegan carreritas en Londres");
            Pelicula Ryf7 = new Pelicula("Rapidos y furiosos 7", 2016, "Vin gasolinas", "Mucha accion", "Japon", 158, 9.3, "El wero ya no juega carreras porque se murió T-T");

            Comedias.Lista.Add(Pie);
            Comedias.Lista.Add(Pie2);
            Comedias.Lista.Add(Pie3);
            Comedias.Lista.Add(Pie4);
            Comedias.Lista.Add(Fe);
            Comedias.Lista.Add(Rubia);
            Comedias.Lista.Add(Vecino);

            Accion.Lista.Add(Ryf);
            Accion.Lista.Add(Ryf2);
            Accion.Lista.Add(Ryf3);
            Accion.Lista.Add(Ryf4);
            Accion.Lista.Add(Ryf5);
            Accion.Lista.Add(Ryf6);
            Accion.Lista.Add(Ryf7);

            foreach(Playlist playlist in playlists)
            {
                Console.WriteLine("-Titulo: " + playlist.Titulo);
                Console.WriteLine("-Descripción: " + playlist.Descripcion);
                Console.WriteLine(" ");
                Console.WriteLine(" -Peliculas dentro de la lista: ");
                foreach(Pelicula pelicula in playlist.Lista)
                {
                    Console.WriteLine("   °Nombre de la Película: " + pelicula.Titulo);
                    Console.WriteLine("   °Director: " + pelicula.Director);
                    Console.WriteLine("   °Genero: " + pelicula.Genero);
                    Console.WriteLine("   °Pais: " + pelicula.Pais);
                    Console.WriteLine("   °Sinopsis: " + pelicula.Sinopsis);
                   try { pelicula.Fecha = pelicula.Fecha; Console.WriteLine("   °Fecha: " + pelicula.Fecha); } catch(Exception se) { Console.WriteLine("Fecha invalida"); }
                    try { pelicula.Duracion = pelicula.Duracion; Console.WriteLine("   °Duracion: " + pelicula.Duracion); } catch (Exception se) { Console.WriteLine("Duración invalida"); }
                    try { pelicula.Imdb = pelicula.Imdb; Console.WriteLine("   °Rating en IMDB: " + pelicula.Imdb); } catch (Exception se) { Console.WriteLine("Rating invalido"); }
                    Console.WriteLine(" ");




                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }


            Console.Read();
        }
    }
}
