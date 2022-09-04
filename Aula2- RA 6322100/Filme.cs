using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__RA_6322100
{
    internal class Filme
    {
        string sinopse;
        string genero;
        string classificacao;
        string titulo;

       public void Receber ( string si, string ge, string cla, string ti)
        {
            this.sinopse = ge;
            this.genero = si;
            this.classificacao = cla;
            this.titulo = ti;
        }
        public string Mostrar()
        {
            return "TItulo: "+ this.titulo + "\nSinopse: "+this.sinopse +"\nGenero: "+ this.genero + "\nClassificação: "+ this.classificacao;
        }

    }
}
