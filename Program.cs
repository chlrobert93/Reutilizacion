using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reutilizacion
{

    public class usuario
    {
       public int id { get; set; }  
       public  string nombre { get; set; }   
    }
    public class ListaElementos<T>
    {
        //Declarar la lista generica
        private List<T> elementos;

        //Usar el constructor
        public ListaElementos()
        {
            elementos = new List<T>();
        }


        
        //Método
        public void Agregar (T nuevoelemento)
        {
            elementos.Add(nuevoelemento);
        }

        public void Eliminar (T eliminarelemento)
        {
            elementos.Remove(eliminarelemento);
        }
        static void Main(string[] args)
        {
            //Instanciar colección generica
            ListaElementos<int> Entero = new ListaElementos<int>();
            Entero.Agregar(1);
            Entero.Eliminar(1);

            ListaElementos<string> Cadenas = new ListaElementos<string>();
            Cadenas.Agregar("Ángel Arias");
            Cadenas.Eliminar("Ángel Arias");

            ListaElementos<usuario> Objeto = new ListaElementos<usuario>();
            Objeto.Agregar(new usuario { id = 1, nombre = "Ángel Arias" });
            Objeto.Eliminar(new usuario { id = 1, nombre = "Ángel Arias" });



        }
    }
}
