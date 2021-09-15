using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBIT_Task_1._2.Entities
{
    public class Building
    {
        // Fields

        [Key]
        public Guid Id { get; set; }
        public String Number { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public String PostalIndex { get; set; }

        // Relations

        [InverseProperty("Building")]
        public virtual ICollection<Flat> Flats { get; set; }
    }
}
