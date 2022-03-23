using System.Collections.Generic;

namespace ConferenciaLoteriaConsole.Model
{
    public class Apostas
    {
        public Apostas()
        {
            Volantes = new List<Volante>();
        }
        public List<Volante> Volantes { get; set; }
    }
}
