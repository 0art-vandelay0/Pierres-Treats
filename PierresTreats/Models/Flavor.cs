using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }
        [Required(ErrorMessage = "Flavor name is required.")]
        public string Name { get; set; }
        public List<FlavorTreat> JoinEntities { get; set; }

        public ApplicationUser User { get; set; }
    }
}