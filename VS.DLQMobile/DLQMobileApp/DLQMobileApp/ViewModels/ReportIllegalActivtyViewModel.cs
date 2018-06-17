using DLQMobileApp.Interfaces;
using DLQMobileApp.Utilities;
using DLQMobileApp.Models;
using System.Threading.Tasks;

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

        public async Task<bool> SubmitIllegalActivity(CreateReportIllegalActivityDto illegalActivity)
        {
            var result = await _service.Create(illegalActivity);

            if(result.Equals("success"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
