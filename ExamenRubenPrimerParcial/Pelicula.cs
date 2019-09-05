using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRubenPrimerParcial
{
    class Pelicula
    {
        public string Titulo { get; set; }
        private int _fecha { get; set;}
        public string Director { get; set;}
        public string Genero { get; set; }
        public string Pais { get; set; }
        public string Sinopsis { get; set; }

        public int Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                if (value >= 1800 && value <= 2019)
                {
                    _fecha= value;
                }
                else
                {
                    throw new Exception("Inserte una fecha correcta");
                }
            }
        }

        private int _duracion { get; set; }
        public int Duracion
        {
            get
            {
                return _duracion;
            }

            set
            {
                if (value > 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("Duracion demasiado corta"); 
                        }
            }
        }

        private double _imdb { get; set; }
        public double Imdb
        {
            get
            {
                return _imdb;
            }
            set
            {
                if(value>= 0 && value <= 10)
                {
                    _imdb = value;
                }
                else
                {
                    throw new Exception("Valor invalido");
                }
            }
        }

        public Pelicula()
        {
            Titulo = "Sin titulo";
            Fecha = 0;
            Director = "Desconocido";
            Genero = "Desconocido";
            Pais = "Desconocido";
            Duracion = 0;
            Imdb = 0;
            Sinopsis = "Desconocido";
        }

        public Pelicula(string titulo, int fecha, string director, string genero, string pais, int duracion, double imdb, string sinopsis)
        {
            Titulo = titulo;
            Fecha = fecha;
            Director = director;
            Genero = genero;
            Pais = pais;
            Duracion = duracion;
            Imdb = imdb;
            Sinopsis = sinopsis;

        }

    }
}
