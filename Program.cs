using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Trabalho09_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Projeto: E-commerce
             *Título:Marketplace
             *Data: 08/06
             *Autores: Lucas e Murilo
             */

            //  Variaveis
            double quant;
            double cod;
            double quantT = 0;
            double quantTT = 0;
            string resp = "S";
            int pag;
            string senha = "";
            double valor = 0;
            double troco = 0;

                while (resp.ToUpper() == "S") 
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("------------MARKETPLACE-------------");
                    Console.WriteLine("| 1) Fofura 90G :         R$2,25  |");
                    Console.WriteLine("| 2) Monster 269ml :      R$5,99  |");
                    Console.WriteLine("| 3) Bala Fini 90G :      R$3,50  |");
                    Console.WriteLine("| 4) Trident 6UN :        R$2,00  |");
                    Console.WriteLine("| 5) Mentos 180G :        R$2,70  |");
                    Console.WriteLine("| 6) Trakinas 126G :      R$3,99  |");
                    Console.WriteLine("| 7) Coca-cola LT:        R$2,50  |");
                    Console.WriteLine("| 8) Choc. Laka 110G :    R$6,79  |");
                    Console.WriteLine("| 9) Nutella 310G :       R$24,99 |");
                    Console.WriteLine("| 10) Club Social 114G :   R$4,90 |");
                    Console.WriteLine("------------------------------------");

                    Console.Write("Qual produto deseja escolher?: ");
                    cod = double.Parse(Console.ReadLine());

                    Console.Write("Qual a quantidade?: ");
                    quant = int.Parse(Console.ReadLine());

                    //switch
                    switch (cod)
                    {
                        case 1:
                            quantT = 2.25 * quant;
                            break;
                        case 2:
                            quantT = 5.99 * quant;
                            break;
                        case 3:
                            quantT = 3.50 * quant;
                            break;
                        case 4:
                            quantT = 2.00 * quant;
                            break;
                        case 5:
                            quantT = 2.70 * quant;
                            break;
                        case 6:
                            quantT = 3.99 * quant;
                            break;
                        case 7:
                            quantT = 2.50 * quant;
                            break;
                        case 8:
                            quantT = 6.79 * quant;
                            break;
                        case 9:
                            quantT = 24.99 * quant;
                            break;
                        case 10:
                            quantT = 4.90 * quant;
                            break;

                        default:
                            Console.Write("Produto Inválido");
                            break;
                    }
                    quantTT += quantT;
                    Console.Write("\nValor do produto: R${0}", quantT);
                    Console.Write("\nDeseja adicionar outro produto?(S)im ou (N)ão?: ");
                    resp = Console.ReadLine();

                    Console.Clear();
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("_____Qual a forma de pagamento?_____");
                Console.WriteLine("|1) Débito                         |");
                Console.WriteLine("|2) Crédito                        |");
                Console.WriteLine("|3) Dinheiro                       |");
                Console.WriteLine("|4) Pix                            |");
                Console.WriteLine("------------------------------------");

                Console.Write("\nValor a ser pago: R${0, 4:F2}", quantTT);
                Console.Write("\nDigite a forma de pagamento: ");
                pag = int.Parse(Console.ReadLine());

                if (pag == 1)
                {
                    Console.Write("\nInsira o cartão.");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write('.');

                    while ((senha.Length < 4))
                    {
                        Console.Write("\nDigite a senha: ");
                        senha = Console.ReadLine();
                    }

                    Console.Write("Aguardando resposta.");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write('.');
                    Console.Write("\nPagamento efetuado com sucesso! :D");

                }
                else if (pag == 2)
                {
                    Console.Write("\nInsira o cartão.");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write('.');

                    while ((senha.Length < 4))
                    {
                        Console.Write("\nDigite a senha: ");
                        senha = Console.ReadLine();
                    }

                    Console.Write("Aguardando resposta.");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write('.');
                    Console.Write("\nPagamento efetuado com sucesso! :D");

                }
                else if (pag == 3)
                {
                    Console.Write("\nDigite o valor recebido: ");
                    valor = double.Parse(Console.ReadLine());
                    troco = valor - quantTT;
                    Console.Write("\nO troco a receber é de R${0, 4:F2}.", troco);
                }
                else if (pag == 4)
                {
                    Console.Write("\n\nEscaneie o qr code");

                    Thread.Sleep(2000);

                    Console.Write("\nAguardando resposta.");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write('.');

                    Console.Write("\nPagamento efetuado com sucesso! :D");
                }
                else if((pag != 1) || (pag != 2) || (pag != 3) || (pag != 4))
                {
                Console.Write("Forma de pagamento inválida!");     
                }

            Console.ReadKey();

        }
    }
}
