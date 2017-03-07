using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2Evaluacion.Model
{
    public class clsPersonaje
    {
        /// <summary>
        /// Consutructor por defecto
        /// </summary>
        public clsPersonaje()
        {
            this.nombre = "";
            this.alias = "";
            this.vida = 0;
            this.regeneracion = 0;
            this.danno = 0;
            this.armadura = 0;
            this.velAtaque = 0;
            this.resistencia = 0;
            this.velMovimiento = 0;
        }
        /// <summary>
        /// Constructor de personaje
        /// </summary>
        /// <param name="nombre">Nombre del personaje</param>
        /// <param name="alias">Alias del personaje</param>
        /// <param name="vida">Vida del personaje</param>
        /// <param name="regeneracion">Regeneracion del personaje</param>
        /// <param name="danno">Danno del personaje</param>
        /// <param name="armadura">Armadura del personaje</param>
        /// <param name="velAtaque">Velocidad del ataque del personaje</param>
        /// <param name="resistencia">Resistencia del personaje</param>
        /// <param name="velMovimiento">Velocidad de movimiento del personaje</param>
        public clsPersonaje(string nombre, string alias, double vida, double regeneracion, double danno, double armadura, double velAtaque, double resistencia, double velMovimiento)
        {
            this.nombre = nombre;
            this.alias = alias;
            this.vida = vida;
            this.regeneracion = regeneracion;
            this.danno = danno;
            this.armadura = armadura;
            this.velAtaque = velAtaque;
            this.resistencia = resistencia;
            this.velMovimiento = velMovimiento;
        }
        #region Get & Set de los atributos
        public int idPersonaje { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public double vida { get; set; }
        public double regeneracion { get; set; }
        public double danno { get; set; }
        public double armadura { get; set; }
        public double velAtaque { get; set; }
        public double resistencia { get; set; }
        public double velMovimiento { get; set; }
        public string imagenPrincipal { get; set; }
        public ArrayList fotos { get; set; }
        #endregion
    }
}
