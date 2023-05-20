using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace TyrellCorp.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class ReplicantsController : ControllerBase
    {
        IReplicantManager _replicantManager;
        public ReplicantsController(IReplicantManager replicantManager) 
        { 
        
         _replicantManager = replicantManager;
        
        }
        
        [HttpGet]
        public async Task<IEnumerable<ReplicantDTO>> Get()
        {
            return await _replicantManager.GetReplicantDTOsAsync();
        }



    }
}
