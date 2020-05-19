using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio6
{
    [Serializable]
    public class Empresa
    {
        protected string Nombre_Empresa;
        protected string Rut_Empresa;

        public Empresa(string N, string R)
        {
            Nombre_Empresa = N;
            Rut_Empresa = R;
        }

         public string IETS()
         {
            return "Nombre de la Empresa: " + Nombre_Empresa + "\n" + "Rut de la Empresa: " + Rut_Empresa;
         }
        
    }
}
