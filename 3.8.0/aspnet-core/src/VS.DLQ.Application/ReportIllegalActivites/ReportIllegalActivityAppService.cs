using System.Threading.Tasks;
using VS.DLQ.ReportIllegalActivites.Dto;
using Abp.Domain.Repositories;
using VS.DLQ.Engagement;

namespace VS.DLQ.ReportIllegalActivites
{
    public class ReportIllegalActivityAppService : DLQAppServiceBase, IReportIllegalActivityAppService
    {

        private readonly IRepository<ReportIllegalActivity, long> _reportIllegalActivity;

        public ReportIllegalActivityAppService(IRepository<ReportIllegalActivity, long> reportIllegalActivity)
        {
            _reportIllegalActivity = reportIllegalActivity;
        }

        public async Task<string> Create(CreateReportIllegalActivityDto input)
        {
            string returnText = string.Empty;
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            var reportIilegalactivity = ObjectMapper.Map<ReportIllegalActivity>(input);

            var reportId = await _reportIllegalActivity.InsertAndGetIdAsync(reportIilegalactivity);

            if (reportId != 0)
                returnText = "success";
            else
                returnText = "failed";
            return returnText;
        }
    }
}
