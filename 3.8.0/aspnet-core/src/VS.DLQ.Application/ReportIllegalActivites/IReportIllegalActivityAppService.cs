using System.Threading.Tasks;
using Abp.Application.Services;
using VS.DLQ.ReportIllegalActivites.Dto;

namespace VS.DLQ.ReportIllegalActivites
{
    public interface IReportIllegalActivityAppService: IApplicationService
    {
        Task<string> CreateAsync(CreateReportIllegalActivityDto input);
    }
}
