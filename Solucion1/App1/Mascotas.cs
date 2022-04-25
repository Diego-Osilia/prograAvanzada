using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{


    /// <summary>
    /// Clase de las mascotas
    /// </summary>

    internal class Mascotas
    {

        private long codigo;
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;
        private string raza;

        public long Codigo { get => codigo; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }


        /// <summary>
        /// Constructor solo con el codigo de la mascota
        /// </summary>
        /// <param name="codigoMascota">Nro del chip 15 digitos</param>



        






        public Mascotas(long codigo, string nombre, DateTime fechaNacimiento, string especie, string raza)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
            this.raza = raza;
        }

        public Mascotas(long codigo)
        {
            this.codigo = codigo;
        }
    }
}
