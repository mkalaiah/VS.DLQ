using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.DataServices
{
    class ReportIssueService : IReportIssueService
    {
        public async Task<string> Create(CreateReportIssueDto request, CancellationToken cancellationToken = default(CancellationToken))
        {
            string data = await ServiceProxy.GetPostDataAsync("/ReportIssue/Create", request);
            Dictionary<string, string> response = ServiceProxy.GetDeserializedDataFromJson<Dictionary<string, string>>(data);
            return response["result"];
        }
    }
}
