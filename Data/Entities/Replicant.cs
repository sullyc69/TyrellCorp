using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Replicant
    {
        public int Id { get; set; }

        public string? Model { get; set; }

        public string? Sex { get; set; }

        public string? Description { get; set; }

        public DateTime? InceptDate { get; set; }
        public List<Function>? Function { get; set; }
        public string? PhysicalAbility { get; set; }

        public string? MentalAbility { get; set; }

        public DateTime? RetirementDate { get; set; }
        public string? PhotoIdName { get; set; }
    }
}
