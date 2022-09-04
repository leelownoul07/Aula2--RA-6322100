using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__RA_6322100
{
    internal class Entrada
    {
        double valor;
        string poltrona;
        string data;
        string hora;
        
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return this.valor;

        }
        public void SetPoltrona(string poltrona)
        {
            this.poltrona = poltrona;
        }
        public string GetPoltrona()
        {
            return this.poltrona;
        }
        public void SetData(string data )
        {
            this.data = data;
        }
        public string Getdata()
        {
            return this.data;
        }
        public void Sethora(string hora)
        {
            this.hora = hora; 
        }
        public string Gethora()
        {
            return this.hora;

        }

    }
}
