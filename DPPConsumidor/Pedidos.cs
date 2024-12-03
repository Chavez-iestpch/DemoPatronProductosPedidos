using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPPConsumidor
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Pedidos(int id, string nombre, string correo)
        {
            Id = id;
            Nombre = nombre;
            CorreoElectronico = correo;
            FechaCreacion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"id:{Id}, Nombre:{Nombre}, Correo:{CorreoElectronico}, Fecha:{FechaCreacion}";
        }
    }
}
    

