using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BBIT_Task_1._2.Entities
{
    public class Tenant
    {
        // Fields

        [Key]
        public string PersonalCode { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid ApartmentId { get; set; }

        // Relations

        [ForeignKey("ApartmentId")]
        public virtual Apartment Apartment { get; set; }
    }
}
