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

        public async Task CreateAsync(CreateReportIllegalActivityDto input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            var reportIilegalactivity = ObjectMapper.Map<ReportIllegalActivity>(input);
            await _reportIllegalActivity.InsertAsync(reportIilegalactivity);
        }
    }
}
