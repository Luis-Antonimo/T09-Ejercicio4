using System;

namespace T09_Ejercicio4
{
    public class Persona
    {
        private string nombre;

        public Persona()
        {
        }

        public void SetNombre(string elnombre)
        {
            nombre = elnombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + nombre);
        }
    }
}