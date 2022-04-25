using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Mascotas miPerrito = new Mascotas(123456789123456);


            miPerrito.Nombre = "Cachupin";


            Console.WriteLine("Mi mascota se llama "+miPerrito.Nombre);
            Console.WriteLine("Su codigo es " + miPerrito.Codigo);

            Console.ReadKey();



        }
    }
}
