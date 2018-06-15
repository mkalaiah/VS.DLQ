using DLQMobileApp.Interfaces;
using DLQMobileApp.Utilities;
using DLQMobileApp.Models;

namespace DLQMobileApp.ViewModels
{
    public class ReportIllegalActivtyViewModel
    {
        private readonly IReportIllegalActivityService _service;

        public bool SaveSuccess = false;

        public ReportIllegalActivtyViewModel ()
        {
            _service = ServiceContainer.Resolve<IReportIllegalActivityService>();
        }

        public void SubmitIllegalActivity(CreateReportIllegalActivityDto illegalActivity)
        {
            var result = _service.Create(illegalActivity).Result;

            if(result.Equals("success"))
            {
                SaveSuccess = true;
            }
            else
            {
                SaveSuccess = false;
            }
        }
    }
}
