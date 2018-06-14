using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace VS.DLQ.Rules
{
    public class RulesAppService :  DLQAppServiceBase, IRulesAppservice
    {
        private readonly IRepository<Rule> _rulesRepository;

        public RulesAppService(IRepository<Rule> rulesRepository)
        {
            _rulesRepository = rulesRepository;
        }

        public async Task<ListResultDto<RuleDto>> GetAll()
        {
            var rules = await _rulesRepository
                .GetAll()
                .OrderByDescending(t => t.TimeStamp)
                .ToListAsync();

            return new ListResultDto<RuleDto>(
                 ObjectMapper.Map<List<RuleDto>>(rules)
            );
        }
    }
}
