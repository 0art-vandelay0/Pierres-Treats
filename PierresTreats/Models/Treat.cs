using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        [Required(ErrorMessage = "Treat Name required")]
        public string Name { get; set; }
        public List<FlavorTreat> JoinEntities { get; set; }

        public ApplicationUser User { get; set; }
    }
}