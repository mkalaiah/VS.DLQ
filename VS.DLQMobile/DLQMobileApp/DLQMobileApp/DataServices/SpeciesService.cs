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
            Dictionary<string,object>response = ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, object>>(data);
            Dictionary<string, object> resultArray = ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, object>>(response["result"].ToString());
            return ServiceProxy.GetDeserializedDataFromJson <List<SpeciesDto>> (resultArray["items"].ToString());
        }
    }
}
