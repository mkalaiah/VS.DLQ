using DLQMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DLQMobileApp.Interfaces
{
    public interface IRulesService
    {
        Task<List<RuleDto>> GetAll(CancellationToken cancellationToken = default(CancellationToken));
    }
}
