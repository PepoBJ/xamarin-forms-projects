using System;
using System.Collections.ObjectModel;

namespace EnlaceDatos
{
    public class Datos : NotificationObject
    {
        private ObservableCollection<Disco> discos;

        public ObservableCollection<Disco> Discos
        {
            get { return discos; }
            set 
            { 
                discos = value;
                OnPropertyChanged();
            }
        }

        private Disco discoSeleccionado;

        public Disco DiscoSeleccionado
        {
            get { return discoSeleccionado; }
            set 
            { 
                discoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public MyComand AgregarDiscoCommand { get; set; }

        public Datos()
        {
            Discos = new ObservableCollection<Disco>();

            Discos.Add(new Disco 
            { 
                Titulo = "Help!", 
                Banda = "The Beatles", 
                Genero = "ROCK AND ROLL", 
                FechaLanzamiento = new DateTime(1965, 8, 6),
                Portada = "help.jpg",
                Precio = (decimal) 4.5
            });
            Discos.Add(new Disco 
            { 
                Titulo = "Revolver",
                Banda = "The Beatles",
                Genero = "ROCK AND ROLL",
                FechaLanzamiento = new DateTime(1966, 8, 6),
                Portada = "revolver.jpg",
                Precio = (decimal)5
            });
            Discos.Add(new Disco 
            { 
                Titulo = "Let it be",
                Banda = "The Beatles",
                Genero = "ROCK AND ROLL",
                FechaLanzamiento = new DateTime(1970, 5, 8),
                Portada = "letitbe.jpg",
                Precio = (decimal)6
            });

            AgregarDiscoCommand = new MyComand(AgregarDiscoCommandExecute, AgregarDiscocommandCanExecute);
        }

        private void AgregarDiscoCommandExecute()
        {
            Discos.Add(new Disco { Banda = "Nirvana", Titulo = "Nevermind", Precio = 10, 
                FechaLanzamiento = new DateTime(1991, 4, 4) });

            AgregarDiscoCommand.ReevaluateCanExecute();
        }

        private bool AgregarDiscocommandCanExecute()
        {
            return Discos.Count < 10;
        }
    }
}
