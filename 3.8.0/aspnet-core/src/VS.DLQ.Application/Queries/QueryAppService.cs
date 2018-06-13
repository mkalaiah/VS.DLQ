using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using VS.DLQ.Engagement;
using VS.DLQ.Queries.Dto;

namespace VS.DLQ.Queries
{
    //[AbpAuthorize(PermissionNames.Pages_Query)]
    //public class QueryAppService : AsyncCrudAppService<Query, QueryDto, int, PagedResultRequestDto, CreateQueryDto, QueryDto>, IQueryAppService
    public class QueryAppService : DLQAppServiceBase,  IQueryAppService
    {
        private readonly IRepository<Query> _queryRepository;

        public QueryAppService(IRepository<Query> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<string> CreateAsync(CreateQueryDto input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            var query = ObjectMapper.Map<Query>(input);
            await _queryRepository.InsertAsync(query);

            return "success";
        }

        public async Task<ListResultDto<QueryDto>> GetAll()
        {
            var queries = await _queryRepository
                .GetAll()                
                .OrderByDescending(t => t.TimeStamp)
                .ToListAsync();

            return new ListResultDto<QueryDto>(
                ObjectMapper.Map<List<QueryDto>>(queries)
            );
        }


        //protected virtual void CheckErrors(IdentityResult identityResult)
        //{
        //    identityResult.CheckErrors(LocalizationManager);
        //}
    }
}
