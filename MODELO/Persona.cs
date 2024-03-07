using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.MODELO
{
    internal class Persona: Comparable
    {
        int id;
        DateTime fechaNacimiento;
        String nombre;

        Persona (int id, DateTime fechaNacimiento, string nombre)
        {
            this.id = id;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String consultarDepreciacion() //FUNCIÓN PENDIENTE
        {
            return "FUNCIÓN PENDIENTE";
        }

        public bool menorQue(Comparable obj) 
        {
            return String.Compare(this.getNombre(), ((Persona)obj).getNombre()) < 0;
        }

        public void asignarMaquinaria(Maquinaria obj) //FUNCIÓN PENDIENTE
        {
            if (obj == null) { }
        }
    }
}
