using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__RA_6322100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nome: Jaime Egidio da Silva Junior Ra: 6322100
            Filme fil = new Filme();
            Entrada ent = new Entrada();

            Console.WriteLine("Digite o Sinopse: ");
            string sinopse = Console.ReadLine();
            Console.WriteLine("Digite o Genero: ");
            string genero = Console.ReadLine();
            Console.WriteLine("Classificação: ");
            string classificacao = Console.ReadLine();
            Console.WriteLine("Digite o Titulo: ");
            string titulo = Console.ReadLine();
            fil.Receber(sinopse, genero, classificacao, titulo);
            Console.WriteLine(fil.Mostrar());
            
            Console.WriteLine("Digite valor do Filme: ");
            ent.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a Poltrona que Deseja: ");
            ent.SetPoltrona(Console.ReadLine());
            Console.WriteLine("Digite a Data que deseja: ");
            ent.SetData(Console.ReadLine());
            Console.WriteLine("Digite a Hora que deseja ver o filme: ");
            ent.Sethora(Console.ReadLine());

            Console.WriteLine("Valor: "+ent.GetValor().ToString("C") + "\nPoltrona: "+ ent.GetPoltrona()+ "\nData: "+ ent.Getdata()+
                "\nHora: "+ ent.Gethora());
            Console.ReadKey();

        }
    }
}
