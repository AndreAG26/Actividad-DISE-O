using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.MODELO
{
    public abstract class Maquinaria: Comparable
    {
        protected double valor;
        protected int vidaUtil;
        protected String marca;
        protected String descripcion;
        protected Persona encargado;

       public Maquinaria(double valor, int vidaUtil, string marca, string descricion)
        {
            this.valor = valor;
            this.vidaUtil = vidaUtil;
            this.marca = marca;
            this.descricion = descricion;
        }

        public abstract String calcularDepreciacion();

        public String getDescripcion() {return descripcion;}
        public double getValor() {return valor; }


        public String consultarNombreEncargado() 
        {
            return encargado.getNombre();
        }

        public bool menorQue(Comparable obj)
        {
            return this.valor<((Maquinaria)obj).getValor();
        }

        public void asignarEncargado(Persona obj) 
        {
            encargado = obj;
        }
    }
}
