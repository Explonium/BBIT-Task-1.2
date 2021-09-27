using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBIT_Task_1._2.Models
{
    public class ApartmentPostModel
    {
        [Required(ErrorMessage = "Apartment number is required")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Floor is required")]
        public int Floor { get; set; }

        [Required(ErrorMessage = "Number of rooms is required")]
        public int NumberOfRooms { get; set; }

        [Required(ErrorMessage = "Number of tenants is required")]
        public int NumberOfTenants { get; set; }

        [Required(ErrorMessage = "Full area is required")]
        public int FullArea { get; set; }

        [Required(ErrorMessage = "Living space is required")]
        public int LivingSpace { get; set; }

        [Required(ErrorMessage = "Building is required")]
        public Guid BuildingId { get; set; }
    }
}
