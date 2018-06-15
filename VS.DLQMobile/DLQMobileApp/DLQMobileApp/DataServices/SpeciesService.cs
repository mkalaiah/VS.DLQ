using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.DataServices
{
    class SpeciesService : ISpeciesService
    {
        public async Task<List<SpeciesDto>> GetAll(CancellationToken cancellationToken = default(CancellationToken))
        {
            string data = await ServiceProxy.GetDataAsync("/Species/GetAll");
            return ServiceProxy.GetDeserializedDataFromJson<List<SpeciesDto>>(data);
        }
    }
}
