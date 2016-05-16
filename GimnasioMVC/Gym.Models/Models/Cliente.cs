using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gym.Models.Models
{
    public class Cliente
    {
        [Key]
        public Int32 Id { get; set; }
        public String Nombre { get; set; }

        public List<Seguimiento> Seguimientos { get; set; }

    }
}
