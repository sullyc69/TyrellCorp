using Data.Data;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Replicants : IReplicants
    {
        public async Task<List<Replicant>> GetReplicantsAsync()
        {
            var replicants = new List<Replicant>();
            using (var db = new TyrellCorporationContext())
            {
                replicants = await (from r in db.Replicants orderby r.InceptDate select r).ToListAsync();

            }
            return replicants;
        }
    }
}
