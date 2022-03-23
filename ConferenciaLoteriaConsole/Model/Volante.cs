using System.Collections.Generic;
using ConferenciaLoteriaConsole.Enums;

namespace ConferenciaLoteriaConsole.Model
{
    public class Volante
    {
        public Volante(TipoLoteria loteria, string codigoVolante, List<int> dezenas)
        {
            TipoLoteria = loteria;
            CodigoVolante = codigoVolante;
            Dezenas = dezenas;
        }
        public TipoLoteria TipoLoteria { get; set; }
        public string CodigoVolante { get; set; }
        public List<int> Dezenas { get; set; }
    }
}
