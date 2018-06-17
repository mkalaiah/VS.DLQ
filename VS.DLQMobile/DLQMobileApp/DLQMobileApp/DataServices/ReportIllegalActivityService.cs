using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.DataServices
{
    class ReportIllegalActivityService : IReportIllegalActivityService
    {
        public async Task<string> Create(CreateReportIllegalActivityDto request, CancellationToken cancellationToken = default(CancellationToken))
        {
            string data = await ServiceProxy.GetPostDataAsync("/ReportIllegalActivity/Create", request);
            Dictionary<string, string> response = ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, string>>(data);
            return response["result"];
        }
    }
}
