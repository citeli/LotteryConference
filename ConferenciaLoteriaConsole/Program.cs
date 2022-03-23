using System;
using System.Collections.Generic;
using System.IO;
using ConferenciaLoteriaConsole.Enums;
using ConferenciaLoteriaConsole.Model;
using ConferenciaLoteriaConsole.Services;
using IronOcr;

namespace ConferenciaLoteriaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ocr = new IronTesseract();

            //using (var Input = new OcrInput("D:/OneDrive/Camera Celular/jogo.jpg"))
            //{
            //    // Input.Deskew();  // use if image not straight
            //    // Input.DeNoise(); // use if image contains digital noise                
            //    var Result = ocr.Read(Input);
            //    Console.WriteLine(Result.Text);
            //}

            var apostas = new Apostas();
            var volante1 = new Volante(TipoLoteria.Lotofacil, "Bolao 16 dezenas 1 A", new List<int> {1,3,4,5,6,8,9,10,11,12,14,16,17,18,19,20});
            var volante2 = new Volante(TipoLoteria.Lotofacil, "Bolao 16 dezenas 1 B", new List<int> {1,4,6,7,9,10,12,13,14,15,16,21,22,23,24,25});
            var volante3 = new Volante(TipoLoteria.Lotofacil, "Bolao 16 dezenas 1 C", new List<int> {1,2,4,5,6,8,14,15,16,17,20,21,22,23,24,25});
            var volante4 = new Volante(TipoLoteria.Lotofacil, "Bolao 16 dezenas 2 A", new List<int> {1,3,4,5,6,9,10,11,12,13,14,15,20,21,23,24});
            var volante5 = new Volante(TipoLoteria.Lotofacil, "Bolao 16 dezenas 2 B", new List<int> {1,3,5,9,12,13,14,15,16,18,19,20,21,22,24,25});
            var volante6 = new Volante(TipoLoteria.Lotofacil, "Bolao 16 dezenas 2 C", new List<int> {1,2,3,4,5,6,7,9,14,16,18,21,22,23,24,25});

            apostas.Volantes.Add(volante1);
            apostas.Volantes.Add(volante2);
            apostas.Volantes.Add(volante3);
            apostas.Volantes.Add(volante4);
            apostas.Volantes.Add(volante5);
            apostas.Volantes.Add(volante6);
            

            ProcessResult.ProcessLotteryResult(apostas);
        }
    }
}