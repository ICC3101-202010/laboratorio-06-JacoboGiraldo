using System;
namespace Laboratorio6
{
    [Serializable]
    public class Area : Division
    {
        public virtual void NombreDiv(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
