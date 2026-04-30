using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("=== MENU DE OPÇÕES ===");

                Console.WriteLine("1 - Caulcular IMC");
                Console.WriteLine("2 - Verificar PAR ou ÌMPAR");
                Console.WriteLine("3 - Equação do 2 Grau");
                Console.WriteLine("4 - Maior e Menor ");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ExecutarIMC();
                        break;
                    case "2":
                        ExecutarParOuImpar();
                        break;
                    case "3":
                        ExecutarEquacaoSegundoGrau();
                        break;
                    case "4":
                        ExecutarMaiorOuMenor();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando");
                        break;


                }
                if (opcao != "0")
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                }
            } while (opcao != "0");

        }
        static void ExecutarIMC()
        {
            int peso;
            double altura, resultado;

            Console.WriteLine("Qual seu peso ?");
            peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual sua altura ?");
            altura = Convert.ToDouble(Console.ReadLine());

            resultado = (altura * peso);

            if (resultado < 18.5)
            {
                Console.WriteLine("Seu imc é frango");
            }
            else
            {
                if (resultado < 25)
                {
                    Console.WriteLine("Seu imc é normal");
                }
                else
                {
                    if (resultado < 30)
                    {
                        Console.WriteLine("Sobrepeso");
                    }
                    else
                    {
                        if (resultado < 35)
                        {
                            Console.WriteLine("Obesidade Grau 1 ");
                        }
                        else
                        {
                            if (resultado < 40)
                            {
                                Console.WriteLine("Obesidade Grau 2");
                            }
                            else
                            {
                                Console.WriteLine("Obesidade Grau 3");
                            }
                        }



                    }
                }
            }
        }

        static void ExecutarParOuImpar()
        {
            double numero;
            double resposta;

            Console.WriteLine("Digite o seu numoro ");
            numero = Convert.ToDouble(Console.ReadLine());

            resposta = (numero % 2);

            if (resposta == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }

        static void ExecutarEquacaoSegundoGrau()
        {
            Console.Write("Qual o valor de A ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor de B ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor de C ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("\nErro o valor de a nao ser zero ");
                return;
            }
            double delta = b * b - 4 * a * c;

            Console.WriteLine($"\nDelta = {delta}");

            if (delta < 0)
            {
                Console.WriteLine("\nA equação não possui raiz negativa");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");

            }
        }
        static void ExecutarMaiorOuMenor()
        {
            double n1, n2;

            Console.WriteLine("Qual o primeiro numero ?");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu segundo numero ?");
            n2 = double.Parse(Console.ReadLine());

            if ((n1 > n2))
            {
                Console.WriteLine($"O numero {n1} é o maior");
            }
            else
            {
                Console.WriteLine($"O numero {n2} é o maior");
            }
        }
    }

}


