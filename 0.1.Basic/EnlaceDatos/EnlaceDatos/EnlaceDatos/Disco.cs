using System;
using System.ComponentModel;

namespace EnlaceDatos
{
    public class Disco : NotificationObject
    {
        string titulo;
        public string Titulo { 
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
                OnPropertyChanged();
            }
        }

        string banda;
        public string Banda
        {
            get
            {
                return banda;
            }
            set
            {
                banda = value;
                OnPropertyChanged();
            }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
                OnPropertyChanged();
            }
        }

        private DateTime fechaLanzamiento;

        public DateTime FechaLanzamiento
        {
            get { return fechaLanzamiento; }
            set 
            { 
                fechaLanzamiento = value;
                OnPropertyChanged();
            }
        }


        public override string ToString()
        {
            return $"{Titulo} {Banda} - {Genero}";
        }
    }
}
