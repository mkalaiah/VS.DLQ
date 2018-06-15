using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.DataServices
{
    class RulesService : IRulesService
    {
        public async Task<List<RuleDto>> GetAll(CancellationToken cancellationToken = default(CancellationToken))
        {
            string data = await ServiceProxy.GetDataAsync("/Rules/GetAll");
            return ServiceProxy.GetDeserializedDataFromJson<List<RuleDto>>(data);
        }
    }
}
