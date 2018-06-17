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
            Dictionary<string, object> response = ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, object>>(data);
            Dictionary<string, object> resultArray = ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, object>>(response["result"].ToString());
            return ServiceProxy.GetDeserializedDataFromJson<List<RuleDto>>(resultArray["items"].ToString());
        }
    }
}
