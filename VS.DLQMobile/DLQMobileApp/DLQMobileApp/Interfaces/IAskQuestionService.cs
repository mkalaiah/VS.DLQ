using DLQMobileApp.Models;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.Interfaces
{
    public interface IAskQuestionService
    {
        Task<string> Create(CreateQueryDto request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
