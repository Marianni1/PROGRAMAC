using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinal
{
    class Conductor
    {
        public string NombreCon { get; set;}
        public int CedulaCon { get; set;}
        public string DireccionCon { get; set;}
        public string FechaCon { get; set;}


        public Conductor(string nombre, int cedula, string Direccion, string Fecha_nacimiento)
        {
            this.NombreCon = nombre;
            this.CedulaCon = cedula;
            this.DireccionCon = Direccion;
            this.FechaCon = Fecha_nacimiento;



        }

        public Conductor()
        {
        }
    }
}
