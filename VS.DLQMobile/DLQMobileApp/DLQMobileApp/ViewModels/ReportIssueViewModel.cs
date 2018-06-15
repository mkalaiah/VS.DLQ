using DLQMobileApp.Interfaces;
using DLQMobileApp.Utilities;
using DLQMobileApp.Models;

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

        public void SubmitIssue (CreateReportIssueDto issue)
        {
            var result = _service.Create(issue).Result;

            if(result.Equals("success"))
            {
                SaveSuccess = true;
            } else
            {
                SaveSuccess = false;
            }
        }
    }
}
