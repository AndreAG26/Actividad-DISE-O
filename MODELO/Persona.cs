using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.MODELO
{
    public class Persona : Comparable
    {
        private int id;
        private DateTime fechaNacimiento;
        private String nombre;
        private Maquinaria miMaquina;

        Persona(int id, DateTime fechaNacimiento, string nombre)
        {
            this.id = id;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public string ConsultarDepreciacion()
        {
            if (miMaquina == null)
            {
                return "No se ha asignado maquinaria a esta persona.";
            }

            var resultado = new StringBuilder();
            resultado.AppendLine("Año\tCuota de depreciación\tDepreciación acumulada\tValor neto en libros");


            var cuotaDepreciacion = miMaquina.ValorActivo / miMaquina.VidaUtil;
            var depreciacionAcumulada = 0m;

            for (int ano = 1; ano <= miMaquina.VidaUtil; ano++)
            {
                depreciacionAcumulada += cuotaDepreciacion;
                var valorNetoLibros = miMaquina.ValorActivo - depreciacionAcumulada;

                resultado.AppendLine($"{ano}\t{cuotaDepreciacion.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"))}" +
                                     $"\t{depreciacionAcumulada.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"))}" +
                                     $"\t{valorNetoLibros.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"))}");
            }

            return resultado.ToString();
        }

        public bool menorQue(Comparable obj)
        {
            return String.Compare(this.getNombre(), ((Persona)obj).getNombre()) < 0;
        }

        public void asignarMaquinaria(Maquinaria obj) //FUNCIÓN PENDIENTE
        {
            if (obj != null)
            {
                miMaquina = obj;
            }
            else
            {
                Console.WriteLine("Error")

            }
        }
    }
}
