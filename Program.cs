using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            int preco_agua = 35;
            int preco_bolachas = 75;
            int preco_acucar=90;
            double preco_mouse = 1.200;
            double preco_caregador = 2.150;
            Console.WriteLine("Escolha o codigo do produto");
            Console.WriteLine("[1] - AGUA MINERAL 1.5L (35mt) \n [2] - BOLACHAS (75mt) \n [3] - AÇUCAR (90mt) \n [4] - MOUSE WIRELESS (1.200mt) \n [5] - CARREGADOR HP (2.150mt)");
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto");
            int quantidade = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: Console.WriteLine("Total de agua a pagar = " + (preco_agua * quantidade)); break;
                case 2: Console.WriteLine("Total de bolachas a pagar = " + (preco_bolachas * quantidade)); break;
                case 3: Console.WriteLine(" total de acucar a pagar = "+ (preco_acucar*quantidade));break;
                case 4: Console.WriteLine(" Total de mouse wireless = " + (preco_mouse * quantidade)); break;
                case 5: Console.WriteLine("Total de carregador a pagar = " + (preco_caregador * quantidade)); break;


            }


        }
    }
}
