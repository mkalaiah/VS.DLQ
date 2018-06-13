using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;
using VS.DLQ.Engagement;
using VS.DLQ.Queries.Dto;
using VS.DLQ.Roles.Dto;

namespace VS.DLQ.Queries
{
    public class QueryAppService : DLQAppServiceBase, IQueryAppService
    {
        private readonly IRepository<Query> _queryRepository;

        public QueryAppService(IRepository<Query> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task CreateAsync(CreateQueryDto input)
        {
            var query = ObjectMapper.Map<Query>(input);
            await _queryRepository.InsertAsync (query);
        }
    }
}
