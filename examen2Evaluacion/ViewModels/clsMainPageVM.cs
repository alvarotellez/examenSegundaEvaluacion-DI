using examen2Evaluacion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2Evaluacion.ViewModels
{
    public class clsMainPageVM : INotifyPropertyChanged
    {

        public clsPersonaje _personajeSeleccionado;
        public ObservableCollection<clsPersonaje> listaPersonajes { get; set; }
        //Hacerlo igual que en la app de contactos con un invoke en el OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public clsMainPageVM()
        {
            listaPersonajes = new ObservableCollection<clsPersonaje>();

            //En este metodo obtendremos el listado de los personajes
            listarPersonajes();
        }

        /// <summary>
        /// Metodo para saber el personaje que ha seleccionado el usuario
        /// </summary>
        public clsPersonaje personajeSeleccionado
        {
            get
            {
                return _personajeSeleccionado;
            }
            set
            {
                _personajeSeleccionado = value;
                OnPropertyChanged("personajeSeleccionado");
            }
        }
        /// <summary>
        /// Listado de los personajes
        /// </summary>
        public async void listarPersonajes()
        {
            clsConexion personajes = new clsConexion();
            listaPersonajes = await personajes.getPersonajes();
            //Obtenemos el personajeSeleccionado que hay en la posicion 0 de la lista
            personajeSeleccionado = listaPersonajes[0];
            OnPropertyChanged("listaPersonajes");
        }
        /// <summary>
        /// Property changed para saber los datos del personaje que ha seleccionado el usuario
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
