using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IFactoryDTO
    {
        int Id { get; set; }
        string? Location { get; set; }
        string? Name { get; set; }
        string? Description { get; set; }

    }
}
