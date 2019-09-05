using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenPrimerParcial
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> Lista { get; set; }

        public Playlist()
        {
            Titulo = "Nueva Playlist";
            Descripcion = "Sin descripcion";
            Lista = new List<Pelicula>();
        }

        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Lista = new List<Pelicula>();
        }
        
    }
}
