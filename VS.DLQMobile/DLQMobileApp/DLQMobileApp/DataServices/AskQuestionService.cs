using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.DataServices
{
    class AskQuestionService : IAskQuestionService
    {
        public async Task<string> Create(CreateQueryDto request, CancellationToken cancellationToken = default(CancellationToken))
        {
            string data = await ServiceProxy.GetPostDataAsync("/Query/Create", request);
            Dictionary<string, string> response= ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, string>>(data);
            return response["result"];
        }
    }
}
