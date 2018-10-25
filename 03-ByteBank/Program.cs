using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaRodolfo = new ContaCorrente();
            contaRodolfo.agencia = 111;
            contaRodolfo.numero = 222;
            contaRodolfo.titular = "Rodolfo José";
            contaRodolfo.saldo = 50500;


            ContaCorrente contaRodolfoSantos = new ContaCorrente();
            contaRodolfoSantos.agencia = 1121;
            contaRodolfoSantos.numero = 2242;
            contaRodolfoSantos.titular = "Rodolfo";
            contaRodolfoSantos.saldo = 5500;

            Console.WriteLine(contaRodolfo == contaRodolfoSantos);

            contaRodolfo = contaRodolfoSantos;

            Console.WriteLine(contaRodolfo == contaRodolfoSantos);

            Console.ReadLine();
        }
    }
}
