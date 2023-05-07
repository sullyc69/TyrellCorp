
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Replicant
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }

        [ForeignKey("Factory")]
       public int FactoryId { get; set; }
        public Factory? Factory { get; set; }
        [ForeignKey("NexusModel")]
        public NexusModel? Nexus { get; set; }

        public DateTime? InceptDate { get; set; }
        public string? FunctionIds { get; set; }
        public string? PhysicalAbility { get; set; }

        public string? MentalAbility { get; set; }

        public DateTime? RetirementDate { get; set; }
        public string? Image { get; set; }

        
       


    }
}
