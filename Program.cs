using System;

namespace T09_Ejercicio4
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.SetNombre("Pepe");
            persona1.Saludar();
            Persona persona2 = new Persona();
            persona2.SetNombre("Lola");
            persona2.Saludar();
        }
    }
}