using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IReplicantDTO
    {
        int Id { get; set; }  
        string? Model { get; set; }
        string? Sex { get; set; }
        string? Description { get; set; }
        DateTime? InceptDate { get; set; }
        List<string>? Function { get; set; }
        string? PhysicalAbility { get; set; }
        string? MentalAbility { get; set; } 
        DateTime? RetirementDate { get; set; }
        string? PhotoIdName { get; set; }
    }
}
