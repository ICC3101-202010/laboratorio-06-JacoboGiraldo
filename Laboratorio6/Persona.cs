using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio6
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string rut;
        private string cargo;

        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.cargo = cargo;
        }

        public string IP()
        {
            string str = "Nombre: " + nombre + "\n" + "Apellido: " + apellido + "\n" + "Rut: " + rut + "\n" + "Cargo: " + cargo;
            return str;
        }
    }
}
