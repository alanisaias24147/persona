using System;

namespace alumnos
{
    class Persona
    {
        string nombre;
        public string apellido;

        public string nombreCompleto
         {
            get => this.nombre + " " + this.apellido;
         }

        private string colorFavorito;

        public string ColorFavorito
        {
            get => this.colorFavorito;
            set => this.colorFavorito = value;
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

       

        public void presentarse()
        {
            Console.WriteLine("hola mi nombre es" + this.nombreCompleto);
        }
        
    }
}
