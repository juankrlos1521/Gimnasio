using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Gym.Models.Models;
using Gym.DataBase.Mapping;

namespace Gym.DataBase.ActaModels
{
    public class GymContext: DbContext
    {
        public virtual IDbSet<Seguimiento> Seguimientos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add<Seguimiento>(new SeguimientoConfig());

        }
    }
}
