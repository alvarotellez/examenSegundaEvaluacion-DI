using examen2Evaluacion.Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http.Filters;

namespace examen2Evaluacion.ViewModels
{
    /// <summary>
    /// Clase que se encarga de establecer la conexion con la api, es una especie de manejadora
    /// </summary>
    public class clsConexion
    {
        Uri uri;

        public clsConexion()
        {
            uri = new Uri("http://localhost:2461/api/personajes");
        }

        //Obtenemos los personajes a partir del json
        public async Task<ObservableCollection<clsPersonaje>> getPersonajes()
        {
            //Esta en el ejercicio de la conexion a la api!!!!
            HttpBaseProtocolFilter filtro = new HttpBaseProtocolFilter();
            filtro.CacheControl.ReadBehavior = HttpCacheReadBehavior.MostRecent;
            filtro.CacheControl.WriteBehavior = HttpCacheWriteBehavior.NoCache;

            HttpClient mihttpClient = new HttpClient();

            ObservableCollection<clsPersonaje> listadoPersonajes = new ObservableCollection<clsPersonaje>();


            try
            {
                string respuesta = await mihttpClient.GetStringAsync(uri);
                mihttpClient.Dispose();

                listadoPersonajes = JsonConvert.DeserializeObject<ObservableCollection<clsPersonaje>>(respuesta);

                foreach (clsPersonaje personajeConcreto in listadoPersonajes)
                {
                    personajeConcreto.imagenPrincipal = obtenerFotoPrincipal(personajeConcreto.nombre);
                    personajeConcreto.fotos = obtenerFotos(personajeConcreto.nombre);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return listadoPersonajes;
        }
        /// <summary>
        /// Metodo que obtiene la ruta donde se encuentra la imagen principal del personaje
        /// </summary>
        /// <param name="nombrePersonaje">Nombre del personaje</param>
        /// <returns></returns>
        public string obtenerFotoPrincipal(string nombrePersonaje)
        {          
            Uri u = new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombrePersonaje + ".png", UriKind.RelativeOrAbsolute);
            return u.ToString();
        }

        //Este no es el metodo correcto que hay que usar, pero no se exactamente como usar el de stackoverflow
        //http://stackoverflow.com/questions/2953254/cgetting-all-image-files-in-folder
        /// <summary>
        /// Metodo que nos saca en un arraylist el listado de las fotos de cada personaje
        /// </summary>
        /// <param name="nombre">Nombre del personaje</param>
        /// <returns></returns>
        public ArrayList obtenerFotos(string nombre)
        {

            ArrayList fotos = new ArrayList();
            switch (nombre)
            {
                case "Aatrox":
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "Ahri":
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "Akali":
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "Alistar":
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute)); fotos.Add(new Uri("ms-appx://examen2evaluacion/Imagenes" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_5.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "Amumu":
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "Anivia":
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_5.jpg", UriKind.RelativeOrAbsolute));
                    fotos.Add(new Uri("ms-appx://examen2Evaluacion/Assets/Imagenes" + nombre + "_6.jpg", UriKind.RelativeOrAbsolute));
                    break;

            }
            return fotos;
        }
    }
}
