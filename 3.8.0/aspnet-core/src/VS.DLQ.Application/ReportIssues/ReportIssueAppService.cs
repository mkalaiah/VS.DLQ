using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using VS.DLQ.Engagement;
using VS.DLQ.ReportIllegalActivites.Dto;
using VS.DLQ.ReportIssues.Dto;

namespace VS.DLQ.ReportIssues
{

    public class ReportIssueAppService : DLQAppServiceBase, IReportIssueAppService
    {
        private readonly IRepository<ReportIssue,long> _reportIssueRepository;

        public ReportIssueAppService(IRepository<ReportIssue,long> reportIssueRepository)
        {
            _reportIssueRepository = reportIssueRepository;
        }

        public async Task CreateAsync(CreateReportIssueDto input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            var reportIssue = ObjectMapper.Map<ReportIssue>(input);
            await _reportIssueRepository.InsertAsync(reportIssue);
        }
    }
}

