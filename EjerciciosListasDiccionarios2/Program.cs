using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosListasDiccionarios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> departamento = new Dictionary<string, string>();
            departamento.Add("nombre", "Atlántida");
            departamento.Add("cabecera", "La Ceiba");
            departamento.Add("superficie", "4,135 km²");
            departamento.Add("población", "450,000 habitantes");

            Dictionary<string, string> departamento2 = new Dictionary<string, string>();
            departamento2.Add("nombre", "Cortés");
            departamento2.Add("cabecera", "San Pedro Sula");
            departamento2.Add("superficie", "3,954 km²");
            departamento2.Add("población", "1,500,000 habitantes");

            Dictionary<string, Dictionary<string, string>> departamentos = new Dictionary<string, Dictionary<string, string>>();
            departamentos.Add("Departamento 1", departamento);
            departamentos.Add("Departamento 2", departamento2);

            foreach (KeyValuePair<string, Dictionary<string, string>> depto in departamentos)
            {
                Console.WriteLine(depto.Key);
                foreach (KeyValuePair<string, string> dato in depto.Value)
                {
                    Console.WriteLine(dato.Key + ": " + dato.Value);
                }
            }


        }
    }
}
