using DLQMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.Interfaces
{
    public interface IReportIssueService
    {
        Task<string> Create(CreateReportIssueDto request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
