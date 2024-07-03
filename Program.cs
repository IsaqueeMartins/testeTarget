using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random faturamento = new Random();
            int[] faturamentoAno = Enumerable.Range(0, 365).Select(_ => faturamento.Next(0, 10000)).Distinct().ToArray();
            double mediaFaturamento = faturamentoAno.Where(ignoraZero => ignoraZero != 0).Average();
            int maiorFaturamentoDia = faturamentoAno.Max();
            int menorFaturamentoDia = faturamentoAno.Min();
            int diasAcimaMedia = 0;
            foreach (int dia in faturamentoAno)
            {
                if (dia > mediaFaturamento)
                {
                    diasAcimaMedia++;
                }
            }
            Console.WriteLine($"Menor valor de faturamento ocorrido em um dia do ano: {menorFaturamentoDia}");
            Console.WriteLine($"Maior valor de faturamento ocorrido em um dia do ano: {maiorFaturamentoDia}");
            Console.WriteLine($"Número de dias no ano em que o valor de faturamento diário foi superior à média anual: {diasAcimaMedia}");
        }



    }
}
