using System;
using System.Collections.Generic;
using ConferenciaLoteriaConsole.Model;

namespace ConferenciaLoteriaConsole.Services
{
    public static class ProcessResult
    {
        public static void ProcessLotteryResult(Apostas apostas)
        {
            var espelho = new List<int>
            {
                2,5,7,8,9,10,11,13,15,16,17,20,21,23,25
            };

            foreach (var volante in apostas.Volantes)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine($"{volante.CodigoVolante}");
                Console.WriteLine("***********************");
                var acertos = 0;

                foreach (var dezena in volante.Dezenas)
                {

                    if (espelho.Contains(dezena))
                    {
                        Console.WriteLine($"No Acertado: {dezena}");
                        acertos++;
                    }
                }

                Console.WriteLine($"{Environment.NewLine}Acertos: {acertos}");
                Console.WriteLine("***********************");
                Console.WriteLine("===========================================================");
            }
        }
    }
}
