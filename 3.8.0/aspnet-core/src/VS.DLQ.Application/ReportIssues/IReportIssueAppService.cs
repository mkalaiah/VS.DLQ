using System.Threading.Tasks;
using Abp.Application.Services;
using VS.DLQ.ReportIllegalActivites.Dto;
using VS.DLQ.ReportIssues.Dto;

namespace VS.DLQ.ReportIssues
{
    public interface IReportIssueAppService : IApplicationService
    {
        Task<string> Create(CreateReportIssueDto input);
    }
}
