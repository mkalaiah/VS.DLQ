using DLQMobileApp.Interfaces;
using DLQMobileApp.Utilities;
using DLQMobileApp.Models;
using System.Threading.Tasks;

namespace DLQMobileApp.ViewModels
{
    public class ReportIssueViewModel
    {
        private readonly IReportIssueService _service;

        public bool SaveSuccess = false;

        public ReportIssueViewModel ()
        {
            _service = ServiceContainer.Resolve<IReportIssueService>();
        }

        public async Task<bool> SubmitIssue (CreateReportIssueDto issue)
        {
            var result = await _service.Create(issue);

            if(result.Equals("success"))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
