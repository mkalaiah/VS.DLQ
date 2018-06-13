using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace VS.DLQ.Rules
{
    public class RuleAppService : DLQAppServiceBase, IRuleAppService
    {
        private readonly IRepository<Rule> _ruleRepository;

        public RuleAppService(IRepository<Rule> ruleRepository)
        {
            _ruleRepository = ruleRepository;
        }

        public async Task<ListResultDto<RuleDto>> GetAll()
        {
            var rules = await _ruleRepository
                .GetAll()
                .OrderByDescending(t => t.TimeStamp)
                .ToListAsync();

            return new ListResultDto<RuleDto>(
                 ObjectMapper.Map<List<RuleDto>>(rules)
            );
        }
    }
}
