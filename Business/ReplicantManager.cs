using Models.Models;
using Data;
using Data.Interfaces;
using Mapster;
using Business.Interfaces;

namespace Business
{
    public class ReplicantManager : IReplicantManager
    {
        private IReplicants _replicants;
        public ReplicantManager(IReplicants replicants) 
        { 
        _replicants = replicants;
        
        }


        public async Task<List<ReplicantDTO>> GetReplicantDTOsAsync() 
        { 
            var replicantDTOList = new List<ReplicantDTO>();

            var replicantList = await _replicants.GetReplicantsAsync();

            foreach(var r in replicantList)
            {
                var repDTO = new ReplicantDTO();

                repDTO.Adapt(r);

                replicantDTOList.Add(repDTO);


            }

            return replicantDTOList;
        
        }

    }
}