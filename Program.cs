using System;
using System.Collections.Generic;
using System.Globalization;

namespace OperadorTernario
{
    public class Program
    {
        public static DateTime Now { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de abastecimento");
            Console.Write("\nInforme o valor da etanol: ");
            double etanol = double.Parse(Console.ReadLine());
            Console.Write("\nInforme o valor do gasolina: ");
            double gasolina = double.Parse(Console.ReadLine());

            double result;
            Console.WriteLine(result = etanol / gasolina);
            Console.WriteLine(result < 0.7 ? "A melhor opção de combustível é o Etanol" : "A melhor opção de combustível é a Gasolina");

            Console.WriteLine("\n>>> Bem vindo ao Posto de Combustível Ascari! <<<\n");
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe seu CPF: ");
            decimal cpf = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nQual combustivel gostaria de abastecer? ");
            Console.WriteLine("1 - Etanol");
            Console.WriteLine("2 - Gasolina\n");
            int combustivel = int.Parse(Console.ReadLine());
            Console.Write("Opcao escolhida: ");
            Console.Write((combustivel == 1) ? "Etanol" : "Gasolina");

            Console.WriteLine("\n\nQuais das opções abaixo deseja?");
            Console.WriteLine("1 - Abastecer um valor fixo em Reais");
            Console.WriteLine("2 - Abastecer um valor fixo em Litros");
            Console.WriteLine("3 - Completar");
            double abastecimento = double.Parse(Console.ReadLine());
            double reais = 50.00;
            double litros = 15;
            double completar = 20;
            switch (abastecimento)
            {
                case 1:

                    if (combustivel == 1)
                    {
                        litros = reais / etanol;
                        reais = etanol;
                    }
                    else if (combustivel == 2)
                    {
                        litros = reais / gasolina;
                        reais = gasolina;
                    }
                    break;
                case 2:
                    if (combustivel == 1)
                    {
                        reais = etanol;
                    }
                    else if (combustivel == 2)
                    {
                        reais = gasolina;
                    }
                    break;
                case 3:
                    if (combustivel == 1)
                    {
                        reais = etanol;
                        litros = completar;
                    }
                    else if (combustivel == 2)
                    {
                        reais = gasolina;
                        litros = completar;
                    }
                    break;
            }
            Console.WriteLine("\nAguardando Abastecimento");
            DateTime localDate = DateTime.Now;
            DateTime localFinalDate = DateTime.Now.AddMinutes(17).AddSeconds(35);
            Console.WriteLine(localDate.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n*****Nota Fiscal*****");
            Console.WriteLine(">Posto de Combustível Ascari<");
            Console.WriteLine($"\nCliente: {nome.ToUpper().Trim()}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine("Inicio do abastecimento: " + localDate.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Fim do abastecimento: " + localFinalDate.ToString(CultureInfo.InvariantCulture));
            Console.Write("Tipo de combustível: ");
            Console.Write((combustivel == 1) ? "Etanol" : "Gasolina");
            Console.WriteLine($"\nQuantidade abastecida: {litros} Litros");
            var total = litros * reais;
            Console.WriteLine("Valor Total Pago: " + total.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}