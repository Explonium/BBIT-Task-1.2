using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBIT_Task_1._2.Models
{
    public class BuildingPostModel
    {
        [Required(ErrorMessage = "Building number is required")]
        public String Number { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public String Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        public String City { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public String Country { get; set; }

        [Required(ErrorMessage = "Postal index is required")]
        public String PostalIndex { get; set; }
    }
}
