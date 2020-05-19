using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Menu = "Bienvenido a su administrador de personal generico.";
            Console.WriteLine(Menu);

            List<Empresa> EmpresaX = new List<Empresa>();

            string m1 = "Desea cargar el archivo de empresas? (Si/No)";
            string m2 = "Deseas crear una empresa y agregarla al archivo? (Si/No)";
            while (true)
            {
                Console.WriteLine(m1);
                string choice = Console.ReadLine();

                if (choice == "Si")
                {
                    try
                    {
                        EmpresaX = Load();
                        
                    }
                    catch
                    {
                        Console.WriteLine("El archivo esta vacio, no hay ninguna empresa creada \n");

                    }
                    foreach (Empresa empresa in EmpresaX)
                        Console.WriteLine("\n"+empresa.IETS());
                    Console.WriteLine("");
                    
                    Console.WriteLine(m2);
                    string ichoice = Console.ReadLine();
                    if (ichoice == "Si")
                    {
                        añadirEmpresa(EmpresaX);
                        Save(EmpresaX);
                        break;
                    }
                    else if (ichoice == "No")
                    {
                        break;
                    }
                    
                    
                }
                else if (choice == "No")
                {
                    añadirEmpresa(EmpresaX);
                    Save(EmpresaX);
                    break;
                }

            }

        }
        static public void añadirEmpresa(List<Empresa> empresax)
        {
            Console.Write("Nombre de la Empresa: ");
            string nom = Console.ReadLine();
            Console.Write("Rut de la Empresa: ");
            string rut = Console.ReadLine();     
            empresax.Add(new Empresa(nom, rut));
        }

        static private void Save(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }

        static private List<Empresa> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresa = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresa;
        }




    }
}
