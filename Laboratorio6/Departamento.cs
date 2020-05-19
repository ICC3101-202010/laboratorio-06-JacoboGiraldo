using System;
namespace Laboratorio6
{
    [Serializable]
    public class Departamento : Division
    {
        
        public virtual void NombreDiv(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
