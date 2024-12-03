using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPPConsumidor
{
    public class Consumidor
    {
        public Cola<Pedidos> _cola;

        public Consumidor(Cola<Pedidos> cola)
        {
            _cola = cola;
        }

        public Pedidos Consumir()
        {
            Pedidos usuario = _cola.Extraer();
            Thread.Sleep(5000);
            return usuario;
        }
    }
}

