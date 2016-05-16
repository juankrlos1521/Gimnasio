using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models.Models
{
    public class Seguimiento
    {
        public Int32 Id { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Peso { get; set; }
        public Decimal Altura { get; set; }
        public Decimal Brazo { get; set; }
        public Decimal Pierna { get; set; }
        public Decimal Cintura { get; set; }
        public Decimal Abdomen { get; set; }
        public Decimal Pecho { get; set; }
        public String Observaciones { get; set; }

        public Int32? ClienteId { get; set; }
        public Cliente Cliente { get; set; }



    }
}
