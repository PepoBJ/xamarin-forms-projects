﻿using System.Collections.ObjectModel;

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


        public Datos()
        {
            Discos = new ObservableCollection<Disco>();

            Discos.Add(new Disco { Titulo = "Help!", Banda = "The Beatles" });
            Discos.Add(new Disco { Titulo = "Revolver", Banda = "The Beatles" });
            Discos.Add(new Disco { Titulo = "Let it be", Banda = "The Beatles" });


        }
    }
}
