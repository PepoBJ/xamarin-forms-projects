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

        public override string ToString()
        {
            return $"{Titulo} {Banda}";
        }
    }
}
