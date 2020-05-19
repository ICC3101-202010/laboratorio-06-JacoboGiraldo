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
        protected List<Division> divisions = new List<Division>();
        public List<Division> Divisions { get => divisions; set => divisions = value; }
       
        public Empresa(string N, string R/*, List<Division> Div*/)
        {
            Nombre_Empresa = N;
            Rut_Empresa = R;
            /*divisions = Div;*/
        }

        public string IETS()
        {
            string empty = "";
            empty += "Nombre de la Empresa: " + Nombre_Empresa + "\n" + "Rut de la Empresa: " + Rut_Empresa + "\n";
            empty += "Trabajadores: " + "\n";
            foreach(Division div in divisions)
                empty += div.ShowInfo(div.Enc, div.Pers) +"\n";
            return empty;
        }

        public void CreateDiv(int Param)
        {
            switch (Param)
            {
                case 1: // Bloque
                    Bloque Bloque = new Bloque();
                    Bloque.NombreDiv("Bloque");
                    Bloque.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP1 = int.Parse(Console.ReadLine());
                    Bloque.CrearPersonal(NP1);
                    divisions.Add(Bloque);
                    break;
                case 2: // Seccion + Bloque
                    Seccion Seccion = new Seccion();
                    Seccion.NombreDiv("Seccion");
                    Seccion.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP2 = int.Parse(Console.ReadLine());
                    Seccion.CrearPersonal(NP2);   
                    Bloque Bloque1 = new Bloque();
                    Bloque1.NombreDiv("Bloque");
                    Bloque1.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP3 = int.Parse(Console.ReadLine());
                    Bloque1.CrearPersonal(NP3);
                    divisions.Add(Seccion);
                    divisions.Add(Bloque1);
                    break;
                case 3: // Departamento + Seccion + Bloque
                    Departamento Departamento = new Departamento();
                    Departamento.NombreDiv("Departamento");
                    Departamento.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP4 = int.Parse(Console.ReadLine());
                    Departamento.CrearPersonal(NP4);
                    Seccion Seccion1 = new Seccion();
                    Seccion1.NombreDiv("Seccion");
                    Seccion1.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP5 = int.Parse(Console.ReadLine());
                    Seccion1.CrearPersonal(NP5);
                    Bloque Bloque2 = new Bloque();
                    Bloque2.NombreDiv("Bloque");
                    Bloque2.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP6 = int.Parse(Console.ReadLine());
                    Bloque2.CrearPersonal(NP6);
                    divisions.Add(Departamento);
                    divisions.Add(Seccion1);
                    divisions.Add(Bloque2);
                    break;
                case 4: // Area + Departamento + Seccion + Bloque
                    Area Area = new Area();
                    Area.NombreDiv("Area");
                    Area.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP7 = int.Parse(Console.ReadLine());
                    Area.CrearPersonal(NP7);
                    Departamento Departamento1 = new Departamento();
                    Departamento1.NombreDiv("Departamento");
                    Departamento1.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP8 = int.Parse(Console.ReadLine());
                    Departamento1.CrearPersonal(NP8);
                    Seccion Seccion2 = new Seccion();
                    Seccion2.NombreDiv("Seccion");
                    Seccion2.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP9 = int.Parse(Console.ReadLine());
                    Seccion2.CrearPersonal(NP9);
                    Bloque Bloque3 = new Bloque();
                    Bloque3.NombreDiv("Bloque");
                    Bloque3.CrearEncargado();
                    Console.Write("Cuanto personal desea crear?");
                    int NP10 = int.Parse(Console.ReadLine());
                    Bloque3.CrearPersonal(NP10);
                    divisions.Add(Area);
                    divisions.Add(Departamento1);
                    divisions.Add(Seccion2);
                    divisions.Add(Bloque3);
                    break;
                
            }
        }
    }
}
