using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KineMovil.Model
{
    internal class MusculoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public byte[] Punto { get; set; }
        
        public int PuntoId { get; set; }
    }
}
