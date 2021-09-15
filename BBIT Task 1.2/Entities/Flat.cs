using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBIT_Task_1._2.Entities
{
    public class Flat
    {
        // Fields
        [Key]
        public Guid Guid { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfTenants { get; set; }
        public int FullArea { get; set; }
        public int LivingSpace { get; set; }
        public Guid BuildingId { get; set; }

        // Relations

        [ForeignKey("BuildingId")]
        public virtual Building Building { get; set; }

        [InverseProperty("Flat")]
        public virtual ICollection<Tenant> Tenants { get; set; }
    }
}
