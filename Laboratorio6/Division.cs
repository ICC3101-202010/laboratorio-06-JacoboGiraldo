using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio6
{
    [Serializable]
    public class Division
    {
        protected string Nombre;
        protected List<Persona> Encargado = new List<Persona>();
        protected List<Persona> Personal = new List<Persona>();

        public List<Persona> Enc { get => Encargado; set => Encargado = value; }
        public List<Persona> Pers { get => Personal; set => Personal = value; }
        public virtual void NombreDiv(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void CrearEncargado()
        {
            Console.WriteLine("Ingrese los datos de la persona encargada de el/la "+Nombre);
            Console.Write("Nombre: ");
            string Nom = Console.ReadLine();
            Console.Write("Apellido: ");
            string Ape = Console.ReadLine();
            Console.Write("Rut: ");
            string Rut = Console.ReadLine();
            string Car = "Encargado";
            Persona personx = new Persona(Nom,Ape,Rut,(Car+" de "+Nombre));
            Encargado.Add(personx);
        }
        public void CrearPersonal(int NumPer)
        {
            if (NumPer == 0)
                Console.WriteLine("No se agrego personal a el/la " + Nombre) ;
            for(int i = 0; i<NumPer; i++)
            {
                Console.WriteLine("Ingrese los datos del personal de el/la " + Nombre);
                Console.Write("Nombre: ");
                string Nom = Console.ReadLine();
                Console.Write("Apellido: ");
                string Ape = Console.ReadLine();
                Console.Write("Rut: ");
                string Rut = Console.ReadLine();
                string Car = "Personal";
                Persona PersonaX = new Persona(Nom, Ape, Rut, (Car + " de " + Nombre));
                Personal.Add(PersonaX);
            }
            
        }
        public string ShowInfo(List<Persona> enca, List<Persona> pers)
        {
            string str = "";
            str += enca[0].IP() + "\n";
            foreach (Persona px in pers)
            {
                str += px.IP() + "\n";
            }
            return str;
        }



    }
}
